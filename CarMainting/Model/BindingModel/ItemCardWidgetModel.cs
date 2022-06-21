using CarMainting.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMainting.Model.BindingModel
{
    class ItemCardWidgetModel : ContentView
    {


        public static BindableProperty ServiceNameProperty = BindableProperty.Create(nameof(ServiceNameProperty), typeof(string), typeof(ItemCard), defaultValue: string.Empty, defaultBindingMode: BindingMode.OneWay);






        public string serviceName
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


        public string ImageUrl { get; set; }


    }
}
