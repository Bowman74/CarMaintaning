using CarMainting.ViewModels;
using System.Diagnostics;

namespace CarMainting.Screens;

public partial class DashBoard : ContentPage
{


    public string t{ get; set; }

    public DashBoard(DashBoardViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;

        t = viewModel.Title;


    }

    public string localDasboard   {get;set;}

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        
		Debug.WriteLine(" Grid Clicked");
        await Shell.Current.GoToAsync(nameof(SellerScreen));
    }

   

          private  void OpenDrawer(object sender, EventArgs e)
    {

         Shell.Current.FlyoutIsPresented = true;
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine("Button Cxliked");
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

       
    }

    private void collection_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
     
    }
}