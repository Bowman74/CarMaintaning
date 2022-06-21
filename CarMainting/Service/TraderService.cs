
using System.Net.Http.Json;
using System.Text;

namespace CarMainting.Service
{
    
    public  class TraderService
    {
        HttpClient httpClient;
       public TraderService()
        {
            httpClient = new HttpClient();

        }

       string baseUrl = "http://192.168.1.30:5003/";

       public async Task getClients() 
        {
            try                                                  
            {
                var user = JsonSerializer.Serialize(new User {
                Email ="mostafaihab2019@gmail.com",
                password="Mostafaihab5000@"
                });
                var requestContent = new StringContent(user, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(baseUrl + "api/Auth/Login", requestContent);
                if (response.IsSuccessStatusCode)
                {
                
                    var data = await response.Content.ReadAsStringAsync();
                    


                }
            }
            catch (Exception e) {

                var x = 3;
            }

        }
    }
}
