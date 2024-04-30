using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ISportApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISportApp.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {

        public MainPageViewModel() { }

        [RelayCommand]
        private async Task SearchPlayers()
        {
            await Shell.Current.GoToAsync(nameof(SearchingPlayerPage), true);
        }

        [RelayCommand]
        private async Task SearchEvents()
        {
            await Shell.Current.GoToAsync(nameof(SearchingEventPage), true);
        }

    }
}
