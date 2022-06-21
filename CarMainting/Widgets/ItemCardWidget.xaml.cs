using CarMainting.Screens;
using CarMainting.ViewModels.ModelWidget;
using System.Diagnostics;

namespace CarMainting.Widgets;

public partial class ItemCard : ContentView
{
    public ItemCard()
    {
        InitializeComponent();
    }

    public string a7a { get; set; }

    public static BindableProperty ServiceNameTextProperty = BindableProperty.Create(nameof(ServiceNameText), typeof(string), typeof(ItemCard)
      , defaultValue: string.Empty);


    public string ServiceNameText
    {
        get => (string)GetValue(ServiceNameTextProperty);
        set => SetValue(ServiceNameTextProperty, value);
    }

    public static BindableProperty ImageUrlProperty = BindableProperty.Create(nameof(ImageUrl), typeof(string), typeof(ItemCard)
    , defaultValue: string.Empty);

    public string ImageUrl
    {
        get => (string)GetValue(ImageUrlProperty);
        set => SetValue(ImageUrlProperty, value);
    }

    private async void gotoSellerScreen(object sender, EventArgs e)
    {
     
        Debug.WriteLine("  Clicked");
    }
}
