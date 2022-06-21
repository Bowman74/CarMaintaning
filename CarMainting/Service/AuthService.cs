

using System.Net.Http;
using System.Text;

namespace CarMainting.Service;

public class AuthService
{

    HttpClient httpClient;
    AuthService()
    {
        httpClient = new HttpClient();
    }

    string baseUrl = "http://192.168.1.30:5003/";


    public async Task Login(User _user) 
    {
        {
            try
            {
                var user = JsonSerializer.Serialize(_user);
             
                var requestContent = new StringContent(user, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(baseUrl + "api/Auth/Login", requestContent);
                if (response.IsSuccessStatusCode)
                {

                    var data = await response.Content.ReadAsStringAsync();



                }
            }
            catch (Exception e)
            {

                var x = 3;
            }

        }
    }
}
