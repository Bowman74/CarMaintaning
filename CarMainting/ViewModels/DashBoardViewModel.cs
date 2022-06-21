using CarMainting.Screens;
using CarMainting.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMainting.ViewModels
{
   public partial class DashBoardViewModel : ExtendedBindableObject
    {

        public DashBoardViewModel( ) {

        }

        [ObservableProperty]
        string title = "Dashboard";

        //   get
        //{

        //    return base.GetValue(ServiceNameProperty)?.ToString();

        //}
        //set
        //{
        //    base.SetValue(ServiceNameProperty, value);

        //}


        private string _totalHours =  "423";



        public string TotalHours
        {
            get => _totalHours;
            set => SetProperty(ref _totalHours, value);

        }

        [ICommand]
        async Task Gotochsellers(string servicename) {

            await Shell.Current.GoToAsync(nameof(SellerScreen),true, new Dictionary<string, object> { {"Service",servicename } });
        
        }


       string convertPropert(string prop) {



            return prop+"412";
        }
    }
}
