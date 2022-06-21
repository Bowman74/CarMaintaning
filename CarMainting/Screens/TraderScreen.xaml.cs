namespace CarMainting.Screens;

public partial class TraderScreen : ContentPage
{
	public TraderScreen()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}