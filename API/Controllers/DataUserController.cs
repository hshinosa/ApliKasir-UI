using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LibraryKasir;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        // Path file JSON untuk menyimpan data pengguna
        private static readonly string JsonFilePath = "json\\user.json";

        // Inisialisasi data pengguna dari file JSON saat aplikasi dimulai
        private static Dictionary<string, DataUser> _users = InitializeDataFromJson(JsonFilePath);

        // ID untuk pengguna berikutnya
        private static int _nextUserId = _users.Count > 0 ? _users.Max(u => u.Value.Id) + 1 : 1;

        // Metode untuk menginisialisasi data pengguna dari file JSON
        private static Dictionary<string, DataUser> InitializeDataFromJson(string jsonFilePath)
        {
            if (System.IO.File.Exists(jsonFilePath))
            {
                string jsonData = System.IO.File.ReadAllText(jsonFilePath);
                return JsonConvert.DeserializeObject<Dictionary<string, DataUser>>(jsonData);
            }
            return new Dictionary<string, DataUser>();
        }

        // Metode untuk menyimpan data pengguna ke file JSON
        private static void SaveDataToJsonFile(Dictionary<string, DataUser> data)
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            System.IO.File.WriteAllText(JsonFilePath, jsonData);
        }

        // Mengembalikan daftar semua pengguna
        [HttpGet]
        public ActionResult<IEnumerable<DataUser>> Get()
        {
            return _users.Values.ToList();
        }

        // Menambahkan pengguna baru
        [HttpPost]
        public IActionResult Post([FromBody] DataUser newUser)
        {
            // Memeriksa apakah username sudah ada
            if (_users.ContainsKey(newUser.Username))
            {
                return Conflict();
            }

            // Menambahkan ID baru ke pengguna
            newUser.Id = _nextUserId++;
            _users.Add(newUser.Username, newUser);
            SaveDataToJsonFile(_users);
            return Ok();
        }

        // Proses login pengguna
        [HttpPost("login")]
        public IActionResult Login([FromBody] DataUser loginUser)
        {
            if (_users.TryGetValue(loginUser.Username, out var user))
            {
                // Memeriksa apakah password cocok
                if (user.Password == loginUser.Password)
                {
                    return Ok(user);
                }
            }
            return NotFound("Username atau password salah.");
        }

        // Mendapatkan informasi pengguna berdasarkan ID
        [HttpGet("{id}")]
        public ActionResult<DataUser> Get(int id)
        {
            DataUser user = _users.Values.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }
    }
}
