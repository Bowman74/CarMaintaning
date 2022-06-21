using CarMainting.Screens;
using CarMainting.Service;
using CarMainting.ViewModels.ModelWidget;
using CarMainting.Widgets;
using CommunityToolkit.Maui;

namespace CarMainting
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                      .UseMauiCommunityToolkit()
                      .UseMauiCommunityToolkitMarkup()
                      .ConfigureFonts(fonts =>
                      {
                       fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                       fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                   });


            // Services


            // Pages
         
            builder.Services.AddTransient<TraderService>();
            builder.Services.AddTransient<AuthService>();

            builder.Services.AddSingleton<DashBoard>();
            builder.Services.AddSingleton<DashBoardViewModel>();

            builder.Services.AddSingleton<ItemCard>();
            builder.Services.AddSingleton<ItemCardModel>();

            
        

            builder.Services.AddSingleton<SellerScreen>();
            builder.Services.AddSingleton<SellersViewModel>();
       
            
 
            return builder.Build();
        }
    }
}
