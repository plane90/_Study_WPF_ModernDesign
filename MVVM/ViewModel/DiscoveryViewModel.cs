using _Study_WPF_ModernDesign.Core;
using System.Collections.ObjectModel;

namespace _Study_WPF_ModernDesign.MVM.ViewModel
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
    class DiscoveryViewModel : ObservableObject
    {
        private ObservableCollection<Person> _myList;
        public ObservableCollection<Person> MyList { get => _myList; }

        public DiscoveryViewModel()
        {
            _myList = new ObservableCollection<Person>()
            {
                new Person{ Name="Name 1", Age=24, Country="India"},
                new Person{ Name="Name 2", Age=24, Country="India"},
                new Person{ Name="Name 3", Age=24, Country="India"},
                new Person{ Name="Name 4", Age=24, Country="India"},
                new Person{ Name="Name 5", Age=24, Country="India"},
                new Person{ Name="Name 6", Age=24, Country="India"},
                new Person{ Name="Name 7", Age=24, Country="India"},
                new Person{ Name="Name 8", Age=24, Country="India"},
                new Person{ Name="Name 9", Age=24, Country="India"},
                new Person{ Name="Name 10", Age=24, Country="India"},
                new Person{ Name="Name 11", Age=24, Country="India"},
                new Person{ Name="Name 12", Age=24, Country="India"},
                new Person{ Name="Name 13", Age=24, Country="India"},
                new Person{ Name="Name 14", Age=24, Country="India"},
                new Person{ Name="Name 15", Age=24, Country="India"},
                new Person{ Name="Name 16", Age=24, Country="India"},
                new Person{ Name="Name 17", Age=24, Country="India"},
                new Person{ Name="Name 18", Age=24, Country="India"},
                new Person{ Name="Name 19", Age=24, Country="India"},
                new Person{ Name="Name 20", Age=24, Country="India"},
                new Person{ Name="Name 21", Age=24, Country="India"},
                new Person{ Name="Name 22", Age=24, Country="India"},
            };
        }
    }
}
