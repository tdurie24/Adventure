using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Adventure.Mobile.ViewModels.Home
{
    public class HomePageViewModel : BindableBase
    {
        public ObservableCollection Monkeys { get; set; }
        public ObservableCollection<Grouping> MonkeysGrouped { get; set; }

        public ObservableCollection Zoos { get; set; }
        public HomePageViewModel()
        {

        }
    }
}
