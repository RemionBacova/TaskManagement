using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaskManagementInterface.Data;

namespace TaskManagementInterface.Data
{

    public class UserService : IUserService
    {

        public HttpClient _httpClient { get; }
        public string LoginMessage { get; set; }
        public string LoginSuccessMsg { get; set; }
        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task LoginAsync(Users_Model user)
        {
            string serializedUser = JsonConvert.SerializeObject(user);
            
            var requestMessage= new HttpRequestMessage(HttpMethod.Post, "Login");

            requestMessage.Content = new StringContent(serializedUser);
            requestMessage.Content.Headers.ContentType
             = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;
            
            var responseBody = await response.Content.ReadAsStringAsync();
            if (responseStatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                LoginMessage = "Invalid username or password";
                throw new Exception(LoginMessage);
            }
        }

        public async Task ChangePassAsync(ChangePass pass)
        {
            string serializedUser = JsonConvert.SerializeObject(pass);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/api/Auth/ChangePassword");

            requestMessage.Content = new StringContent(serializedUser);
            requestMessage.Content.Headers.ContentType
             = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);
            var responseStatusCode = response.StatusCode;

            var responseBody = await response.Content.ReadAsStringAsync();
            if (responseStatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                LoginMessage = "Invalid password";
                throw new Exception(LoginMessage);
            }
            else
            {
                LoginSuccessMsg = "Success";
                throw new Exception(LoginSuccessMsg);

            }
        }

    }
}
