namespace CarMainting.Screens;

public partial class SellerScreen : ContentPage
{
   
    public SellerScreen(SellersViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var nav = Navigation.NavigationStack;
        await Navigation.PopAsync();
    }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TraderScreen());

    
   
    }
}