using CarMainting.Service;

#nullable disable
namespace CarMainting.ViewModels
{
    [QueryProperty("ServiceName", "Service")]
    public partial class SellersViewModel : ExtendedBindableObject
    {
        TraderService _service;
        public SellersViewModel(TraderService service) 
        {
            _service = service;
            Task.Run(async () => await GetSeller());
        }


        [ObservableProperty]
        string serviceName;

        [ICommand]
        async Task GetSeller() {


            try
            {
             await _service.getClients();

            }
            catch (Exception ex) {

                var x = ex;
            }
         
        }
    }
}
