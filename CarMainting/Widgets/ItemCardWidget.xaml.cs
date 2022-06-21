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

    public static BindableProperty ServiceNameProperty = BindableProperty.Create(nameof(ItemCard), typeof(string), typeof(ItemCardWidgetModel)
      , defaultValue: string.Empty, propertyChanged: TitleTextPropertyChaned);


    public static void TitleTextPropertyChaned(BindableObject bindable, object oldvalue, object newValue)
    {
        var control = (ItemCard)bindable;
        control.serviceName.Text = newValue?.ToString();

    }







    public string ServiceNameText
    {
        get
        {

            return base.GetValue(ServiceNameProperty)?.ToString();

        }
        set
        {
            base.SetValue(ServiceNameProperty, value);

        }
    }




    public static BindableProperty ImageProperty = BindableProperty.Create(nameof(ImageProperty), typeof(string), typeof(ItemCard)
    , defaultValue: string.Empty, propertyChanged: ImagePropertyChaned);


    public static void ImagePropertyChaned(BindableObject bindable, object oldvalue, object newValue)
    {
        var control = (ItemCard)bindable;
        control.image.Source = newValue?.ToString();

    }

    public object ImageUrl
    {
        get
        {

            return base.GetValue(ImageProperty)?.ToString();

        }
        set
        {
            base.SetValue(ImageProperty, value);

        }
    }





    private async void gotoSellerScreen(object sender, EventArgs e)
    {
     
        Debug.WriteLine("  Clicked");
    }
}
