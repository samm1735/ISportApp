using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ISportApp.Models;
using ISportApp.Services;
using ISportApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISportApp.ViewModels
{
    public partial class SearchingPlayerViewModel : ObservableObject
    {
        [ObservableProperty]
        public String searchTerm = new("");

        //public string SearchTerm
        //{
        //    get => _searchTerm;
        //    set => SetProperty(ref _searchTerm, value);
        //}

        [ObservableProperty]
        public Player selectedPlayer = new();

        //public Player SelectedPlayer
        //{
        //    get => _selectedPlayer;
        //    set => SetProperty(ref _selectedPlayer, value);
        //}

        [ObservableProperty]
        public String errorMessage = new("");
        //public string ErrorMessage
        //{
        //    get => _errorMessage;
        //    set => SetProperty(ref _errorMessage, value);
        //}

        public bool IsErrorVisible => !string.IsNullOrEmpty(ErrorMessage);

        //[ObservableProperty]
        private readonly SelectedPlayerService _selectedPlayerService;

        //public SearchingPlayerViewModel(SelectedPlayerService selectedPlayerService)
        //{

        //    _selectedPlayerService = selectedPlayerService;

        //}

        //public SearchingPlayerViewModel() 
        //{


        //}



        public async Task GetPlayer()
        {
            try
            {
                SearchedPlayer searchedPlayer = await SearchingPlayerService.getSearchedPlayer(SearchTerm);

                if (searchedPlayer.player != null && searchedPlayer.player.Length > 0)
                {
                    SelectedPlayer = searchedPlayer.player[0];
                }
                else
                {
                    // No player instance found, set error message
                    ErrorMessage = "No player found for the entered search term.";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"An error occurred: {ex.Message}";
            }
        }





        [RelayCommand]
        private async Task Search()
        {
            string searchTerm = SearchTerm;
            searchTerm = FormatName(searchTerm);

            // Perform search based on searchTerm
            await GetPlayer();
        }

        [RelayCommand]
        private async Task SeePlayerDetails()
        {

            var parameters = new Dictionary<string, object>
            {
                {"SelectedPlayer", SelectedPlayer}
            };

            //await Shell.Current.GoToAsync(nameof(PlayerDetails), true, parameters);


            //_selectedPlayerService.SelectedPlayer = SelectedPlayer;

            await Shell.Current.GoToAsync(nameof(PlayerDetails), true, parameters);


        }







        public string FormatName(string name)
        {
            // Split the name into individual words
            string[] words = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Initialize a StringBuilder to store the formatted name
            StringBuilder formattedName = new StringBuilder();

            // Iterate through each word in the name
            for (int i = 0; i < words.Length; i++)
            {

                // Convert the first word to lowercase and append it directly
                if (i == 0)
                {
                    formattedName.Append(words[i]);
                }
                else
                {
                    // Convert subsequent words to lowercase and append them with an underscore
                    formattedName.Append("_").Append(words[i].ToLower());
                }
            }

            // Return the formatted name
            return formattedName.ToString();
        }

    }
}
