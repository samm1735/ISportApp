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
///     Description : Application mobile developp�e avec .Net MAUI pour faire des requetes a un API.
///                   Ce projet consiste a donner des informations de sport, plus pr�cis�ment de Football
///                   Le projet utilise le syst�me de design MVVM.
///                   
///                   Par cons�quent notre folder structure est la suivante.
///                   
///                   Models    |
///                             |--> SearchedPlayer.cs    // Notre mod�le pour les jouers de football
///                             |--> SearchedEvents.cs    // Notre mod�le pour les matchs de football
///                             |--> Constants.cs   // Pour des variables constantes - Mainly used for databse integration
///                   
///                   
///                   Services  |
///                             |--> DatabaseService.cs    // D�finition des m�thodes de cr�ation de table, insertion et update de champs.
///                             |--> SearchingEventService.cs  // Requetes API et retourne une instance de SearchedEvents
///                             |--> SearchingPlayerService.cs  // Requetes API et retourne une instance de SearchedPlayer
///                                                             
///                   ViewModels|
///                             |--> MainPageViewModel.cs    // Utilis�e pour le Binding de Views.MainPage.
///                             |--> PlayerDetailsViewModel.cs  // Utilis�e pour le Binding de Views.PlayerDetails.
///                             |--> SearchingEventViewModel.cs  // Utilis�e pour le Binding de Views.SearchingEventPage.
///                             |--> SearchingPlayerViewModel.cs  // Utilis�e pour le Binding de Views.SearchingPlayerPage.
///                   
/// 
/// 
///                   Views     |
///                             |--> MainPage.xaml    // La page principale
///                             |--------> MainPage.xaml.cs //Le code behind de la page principale
///                             |--> PlayerDetails.xaml    // La page utilis�e pour les details des joueurs
///                             |--> SearchingEventPage.xaml    // La page utilis�e pour les matchs
///                             |--> SearchingPlayerPage.xaml    // La page utilis�e la recherche de jouers
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