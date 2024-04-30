//using System.Drawing;
using System.Net.NetworkInformation;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
namespace ISportApp.Views;

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