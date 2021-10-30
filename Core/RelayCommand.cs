using System;
using System.Windows.Input;

namespace _Study_WPF_ModernDesign.Core
{
    /* 결론
     * https://www.sysnet.pe.kr/2/0/10917
     * event 운용 인터페이스
     * event에 Action 등 Command를 수집하는 클래스이다.
     * CanExecuteChanged, CanExecute와 Execute함수가 
     * event 위를 layer(wrapper)로써 감싼것이 특징이다.
     * 즉, event를 통제하는 인터페이스이다.
     * 이 것은 WPF 컨트롤들에게 아주 유용하다.
     * http://ojc.asia/bbs/board.php?bo_table=WPF&wr_id=146
     * 예를들어, Button은 최초 CanExecute를 호출해 자신의 활성여부를 결정한다.
     * Button 안의 TextBox에 데이터가 입력되어야만 클릭가능하도록 만들고 싶다면
     * CanExecuteChanged에 데이터 입력여부를 전달해 호출하도록 한다.
     * 즉, 최초엔 CanExecute로 활성여부를 초기화하고 그 이후 업데이트는 CanExecuteChanged가 맡는다.
     * cf. UI의 활성화 여부는 항상 CanExecute로 판단한다.
     * cf. UI의 click 이벤트는 Execute 호출로 처리한다.
     */
    class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        // ICommand
        public event EventHandler CanExecuteChanged
        {
            // https://youtu.be/OTMyi2XrVyw
            // 사용자 정의 컨트롤은 CanExecute가 자동 호출되지 않으므로
            // CommandManager.ReqerySuggested에 CanExectueChanged를 위임해야 한다.
            // CommandManager는 모든 종류의 UI 상호작용을 통한 변경사항 호출 알림을 제공한다.
            // 즉, CommandManager에 의해 CanExecuteChanged가 간접호출되어 CanExcute 메소드가 호출된다.
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        // ICommand
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        // ICommand
        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
    }
}
