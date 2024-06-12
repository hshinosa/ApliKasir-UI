using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace LibraryKasir
{
    public class RegisterService
    {
        private static readonly Lazy<RegisterService> _instance = new Lazy<RegisterService>(() => new RegisterService());
        public static RegisterService Instance => _instance.Value;

        private readonly string _apiBaseUrl = "https://localhost:7222/user";

        private RegisterService() { }

        public async Task<bool> RegisterUser(string username, string password)
        {
            DataUser newUser = new DataUser { Username = username, Password = PasswordHasher.HashPassword(password) };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonData = JsonConvert.SerializeObject(newUser);
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(_apiBaseUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else if (response.StatusCode == HttpStatusCode.Conflict)
                    {
                        throw new Exception("Username sudah ada. Tolong buat username yang lain.");
                    }
                    else
                    {
                        throw new Exception($"Gagal mendaftarkan pengguna: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal mendaftarkan pengguna: {ex.Message}");
            }
        }
    }
}
