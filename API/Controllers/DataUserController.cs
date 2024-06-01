using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
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
        private static string jsonFilePath = "json\\user.json";
        private static List<DataUser> users = InitializeDataFromJson(jsonFilePath);
        private static int nextUserId = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1;

        private static List<DataUser> InitializeDataFromJson(string jsonFilePath)
        {
            List<DataUser> data = new List<DataUser>();
            if (System.IO.File.Exists(jsonFilePath))
            {
                string jsonData = System.IO.File.ReadAllText(jsonFilePath);
                data = JsonConvert.DeserializeObject<List<DataUser>>(jsonData);
            }
            return data;
        }

        private static void SaveDataToJsonFile(List<DataUser> data)
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            System.IO.File.WriteAllText(jsonFilePath, jsonData);
        }

        [HttpGet]
        public IEnumerable<DataUser> Get()
        {
            return users;
        }

        [HttpPost]
        public IActionResult Post([FromBody] DataUser newUser)
        {
            // Memeriksa apakah username sudah ada
            if (users.Any(u => u.Username == newUser.Username))
            {
                return Conflict();
            }

            // Menambahkan ID baru ke user
            newUser.Id = nextUserId++;

            users.Add(newUser);
            SaveDataToJsonFile(users);
            return Ok(); // Return 200 OK status
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] DataUser loginUser)
        {
            // Mencari pengguna dengan username yang cocok
            var user = users.FirstOrDefault(u => u.Username == loginUser.Username);

            // Memeriksa apakah pengguna ditemukan dan password cocok
            if (user != null && user.Password == loginUser.Password)
            {
                return Ok(user); // Return 200 OK status with user data
            }
            else
            {
                return NotFound("Username or password is incorrect."); // Return 404 Not Found status with error message
            }
        }



        [HttpGet("{id}")]
        public ActionResult<DataUser> Get(int id)
        {
            DataUser user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            users.Remove(user);
            SaveDataToJsonFile(users);
            return NoContent();
        }
    }
}
