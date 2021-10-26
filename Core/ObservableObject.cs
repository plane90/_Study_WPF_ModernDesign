using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _Study_WPF_ModernDesign.Core
{
    // INotifyPropertyChanged: UI Update - Binding에 쓰임
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name =null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
