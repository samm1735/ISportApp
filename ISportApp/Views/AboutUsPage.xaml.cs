namespace ISportApp.Views;

public partial class AboutUsPage : ContentPage
{
	public AboutUsPage()
	{
		InitializeComponent();
	}


    private void OnGitHubButtonClicked(object sender, EventArgs e)
    {
        try
        {
            
            Launcher.OpenAsync(new Uri("https://github.com/samm1735"));
        }
        catch (Exception ex)
        {
            
        }
    }

}