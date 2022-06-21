
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarMainting.ViewModels
{
    public partial class ExtendedBindableObject : ObservableObject
    {

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(finishLoading))]
        bool loading;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title = "XXXX";



        public bool IsNotBusy => !isBusy;
        public bool finishLoading => !loading;
    }
}
