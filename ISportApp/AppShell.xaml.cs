using ISportApp.Views;

namespace ISportApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SearchingPlayerPage), typeof(SearchingPlayerPage));

            Routing.RegisterRoute(nameof(SearchingEventPage), typeof(SearchingEventPage));

            Routing.RegisterRoute(nameof(PlayerDetails), typeof(PlayerDetails));

            Routing.RegisterRoute(nameof(AboutUsPage), typeof(AboutUsPage));


        }
    }
}
