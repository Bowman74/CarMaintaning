using CarMainting.Screens;
using CarMainting.Widgets;

namespace CarMainting
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Register the routes of the detail pages
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("newevent", typeof(NewEventPage));
            Routing.RegisterRoute(nameof(SellerScreen), typeof(SellerScreen));
            Routing.RegisterRoute(nameof(ItemCard), typeof(ItemCard));
            Routing.RegisterRoute(nameof(DashBoard), typeof(DashBoard));
            Routing.RegisterRoute(nameof(NewShell), typeof(NewShell));
            Routing.RegisterRoute(nameof(TraderScreen), typeof(TraderScreen));
            


        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//login");
        }
    }
}
