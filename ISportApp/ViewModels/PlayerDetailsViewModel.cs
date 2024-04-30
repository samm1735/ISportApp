using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ISportApp.Models;
using ISportApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISportApp.ViewModels
{
    [QueryProperty("SelectedPlayer", "SelectedPlayer")]
    public partial class PlayerDetailsViewModel: ObservableObject
    {

        [ObservableProperty]
        private Player selectedPlayer;

        private DatabaseService _databaseService = new();

        //public PlayerDetailsViewModel(DatabaseService databaseService)
        //{
        //    _databaseService = databaseService;
        //}



        [RelayCommand]
        private async Task Sauvegarder()
        {
            if (SelectedPlayer != null)
            {
                //if (SelectedPlayer.id == 0)
                //{
                    try
                    {
                        //Personne personne = new Personne(
                        //    nom: UnePersonne.Nom,
                        //    prenom: UnePersonne.Prenom,
                        //    email: UnePersonne.Email,
                        //    phone: UnePersonne.Phone,
                        //    photo: UnePersonne.Photo,
                        //    ddn: UnePersonne.Ddn
                        //    );




                        await _databaseService.SavePlayerAsync(SelectedPlayer);



                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                //}
                //else
                //{
                //    await _databaseService.SavePlayerAsync(SelectedPlayer);
                //    //_modelViewPersonnesPointer.GetData();
                //}
            }
            await Shell.Current.GoToAsync("..");
        }


        //[ObservableProperty]
        //public ObservableCollection<string> SelectedPlayerImages { get; set; }

        //public PlayerDetailsViewModel()
        //{
        //    // Initialize SelectedPlayerImages
        //    SelectedPlayerImages = new ObservableCollection<string>();


        //    for (int i = 1; i <= 4; i++)
        //    {
        //        string fanArtProperty = $"strFanart{i}";
        //        string fanArtUrl = SelectedPlayer.GetType().GetProperty(fanArtProperty)?.GetValue(SelectedPlayer) as string;

        //        if (!string.IsNullOrEmpty(fanArtUrl))
        //        {

        //            SelectedPlayerImages.Add(fanArtUrl);
        //        }
        //    }
        //}

        //public Player SelectedPlayer
        //{
        //    get => _selectedPlayer;
        //    set => SetProperty(ref _selectedPlayer, value);
        //}

        //[ObservableProperty]
        //private string selectedPlayerDescriptionEN;

        //public PlayerDetailsViewModel()
        //{
        //    SelectedPlayerDescriptionEN = TruncateText(SelectedPlayer.strDescriptionEN, 500);
        //}


        //[RelayCommand]
        //private async Task ShowMore()
        //{
        //    _ = SelectedPlayer.strDescriptionEN;
        //    await Task.CompletedTask;
        //}

        //private string TruncateText(string text, int limit)
        //{
        //    var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //    if (words.Length <= limit)
        //        return text;

        //    return string.Join(" ", words.Take(limit)) + "...";
        //}




        //public Player SelectedPlayer
        //{
        //    get => _selectedPlayer;
        //    set => SetProperty(ref _selectedPlayer, value);
        //}


        //private SearchingPlayerViewModel _modelViewPlayerPointer { get; set; }

        //private SelectedPlayerService _selectedPlayerService { get; set; }


        //public PlayerDetailsViewModel(SelectedPlayerService selectedPlayerService)
        //{
        //    //_modelViewPlayerPointer = modelViewPlayerPointer;
        //    //SelectedPlayer = _modelViewPlayerPointer.SelectedPlayer;

        //    _selectedPlayerService = selectedPlayerService;

        //    SelectedPlayer = _selectedPlayerService.SelectedPlayer;
        //}




    }
}
