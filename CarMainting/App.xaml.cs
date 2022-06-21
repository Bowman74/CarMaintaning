using CarMainting.Controls;
using Microsoft.Maui.Platform;

namespace CarMainting
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


//            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderLessEntry), (handler, view) =>
//            {
//#if ANDROID
//                if (view is BorderLessEntry)
//                {

//                    handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());

//                    var Z = handler.PlatformView;


//                }
//#endif

//            });

            MainPage = new AppShell();
        }
    }
}
