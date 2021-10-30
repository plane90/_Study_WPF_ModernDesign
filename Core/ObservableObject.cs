using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _Study_WPF_ModernDesign.Core
{
    // INotifyPropertyChanged: UI Update - Binding에 쓰임
    abstract class ObservableObject : INotifyPropertyChanged
    {
        // INotifyPropertyChanged
        // delegate PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);
        // public class PropertyChangedEventArgs { public virtual string PropertyName { get; } }
        // 해당 EventHandler는 EventArgs로써 string PropertyName 을 파라미터로 받는다.
        public event PropertyChangedEventHandler PropertyChanged;

        // CallerMemberName은 Caller의 이름을 name에 초기화 해준다.
        protected void OnPropertyChanged([CallerMemberName] string name =null)
        {
            // CallerName = PropertyName
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
