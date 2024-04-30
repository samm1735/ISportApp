//using System.Drawing;
using System.Net.NetworkInformation;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
namespace ISportApp.Views;




/// <summary>
/// 
///     Nom         : ISAAC 
///     Prenom      : Sammuel Ramclief
///     Cours       : C# II
///     Devoir III
///     Description : Application mobile developpée avec .Net MAUI pour faire des requetes a un API.
///                   Ce projet consiste a donner des informations de sport, plus précisément de Football
///                   Le projet utilise le système de design MVVM.
///                   
///                   Par conséquent notre folder structure est la suivante.
///                   
///                   Models    |
///                             |--> SearchedPlayer.cs    // Notre modèle pour les jouers de football
///                             |--> SearchedEvents.cs    // Notre modèle pour les matchs de football
///                             |--> Constants.cs   // Pour des variables constantes - Mainly used for databse integration
///                   
///                   
///                   Services  |
///                             |--> DatabaseService.cs    // Définition des méthodes de création de table, insertion et update de champs.
///                             |--> SearchingEventService.cs  // Requetes API et retourne une instance de SearchedEvents
///                             |--> SearchingPlayerService.cs  // Requetes API et retourne une instance de SearchedPlayer
///                                                             
///                   ViewModels|
///                             |--> MainPageViewModel.cs    // Utilisée pour le Binding de Views.MainPage.
///                             |--> PlayerDetailsViewModel.cs  // Utilisée pour le Binding de Views.PlayerDetails.
///                             |--> SearchingEventViewModel.cs  // Utilisée pour le Binding de Views.SearchingEventPage.
///                             |--> SearchingPlayerViewModel.cs  // Utilisée pour le Binding de Views.SearchingPlayerPage.
///                   
/// 
/// 
///                   Views     |
///                             |--> MainPage.xaml    // La page principale
///                             |--------> MainPage.xaml.cs //Le code behind de la page principale
///                             |--> PlayerDetails.xaml    // La page utilisée pour les details des joueurs
///                             |--> SearchingEventPage.xaml    // La page utilisée pour les matchs
///                             |--> SearchingPlayerPage.xaml    // La page utilisée la recherche de jouers
///                             
///                             
///                     
/// </summary>

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        if (IsInternetAvailable())
        {
            //Title = "Online";
            var titleView = new Label
            {
                Text = "Online",
                TextColor = Color.FromArgb("#00FF00"),
                FontSize = 24,
                Margin = new Thickness(20,20,0,0)
            };

            //NavigationPage.SetTitleView(this, titleView);
            Shell.SetTitleView(this, titleView);
            
        }
        else
        {
            //Title = "Offline";
            var titleView = new Label
            {
                Text = "Offline",
                TextColor = Color.FromArgb("#FF0000"),
                FontSize = 24,
                Margin = new Thickness(20, 20, 0, 0)
            };

            //NavigationPage.SetTitleView(this, titleView);
            Shell.SetTitleView(this, titleView );
        }
	}

    /// <summary>
    ///     Check if the device is connected to the internet
    /// </summary>
    /// <returns> True or Flase </returns>
    public static bool IsInternetAvailable()
    {
        if (!NetworkInterface.GetIsNetworkAvailable())
        {
            return false; // No Internet
        }

        try
        {
            using (var client = new System.Net.WebClient())
            using (var stream = client.OpenRead("http://www.google.com"))
            {
                return true; // Internet Available
            }
        }
        catch
        {
            return false; // En cas d'Exception return false
        }
    }


}