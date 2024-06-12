using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryKasir
{
    public class LoginService
    {
        private static readonly Lazy<LoginService> _instance = new Lazy<LoginService>(() => new LoginService());
        public static LoginService Instance => _instance.Value;

        private readonly string _apiBaseUrl = "https://localhost:7222/user";

        private LoginService() { }

        public async Task<bool> LoginUser(string username, string password)
        {
            DataUser loginUser = new DataUser { Username = username, Password = PasswordHasher.HashPassword(password) };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonData = JsonConvert.SerializeObject(loginUser);
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{_apiBaseUrl}/login", content);

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Login gagal: {ex.Message}");
            }
        }
    }
}
