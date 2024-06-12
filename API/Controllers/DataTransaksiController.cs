using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using LibraryKasir;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataTransaksiController : ControllerBase
    {
        private static string jsonFilePath = "json\\transaksi.json";
        private static List<DataTransaksi> dataTransaksi = InitializeDataFromJson(jsonFilePath);

        private static List<DataTransaksi> InitializeDataFromJson(string jsonFilePath)
        {
            List<DataTransaksi> data = new List<DataTransaksi>();
            if (System.IO.File.Exists(jsonFilePath))
            {
                string jsonData = System.IO.File.ReadAllText(jsonFilePath);
                data = JsonConvert.DeserializeObject<List<DataTransaksi>>(jsonData);
            }
            return data;
        }

        private static void SaveDataToJsonFile(List<DataTransaksi> data)
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            System.IO.File.WriteAllText(jsonFilePath, jsonData);
        }

        [HttpGet]
        public IEnumerable<DataTransaksi> Get()
        {
            return dataTransaksi;
        }

        [HttpPost]
        public IActionResult Post([FromBody] DataTransaksi newvalue)
        {
            dataTransaksi.Add(newvalue);
            SaveDataToJsonFile(dataTransaksi);
            return Ok();
        }

        [HttpGet("{id}")]
        public ActionResult<DataTransaksi> Get(int id)
        {
            if (id < 0 || id >= dataTransaksi.Count)
            {
                return NotFound(); // Return 404 Not Found status if ID is out of range
            }
            return dataTransaksi[id];
        }

        [HttpDelete("{idTransaksi}")]
        public IActionResult Delete(int idTransaksi)
        {

            var transaksiToDelete = dataTransaksi.FirstOrDefault(t => t.idTransaksi == idTransaksi);

            if (transaksiToDelete == null)
            {
                return NotFound();
            }
            dataTransaksi.Remove(transaksiToDelete);
            SaveDataToJsonFile(dataTransaksi);
            return NoContent();
        }

        [HttpPut("{idTransaksi}")]
        public IActionResult Put(int idTransaksi, [FromBody] DataTransaksi updatedValue)
        {
            var item = dataTransaksi.FirstOrDefault(b => b.idTransaksi == idTransaksi);

            if (item == null)
            {
                return NotFound(); // Return 404 Not Found status if ID is not found
            }

            int index = dataTransaksi.IndexOf(item);
            dataTransaksi[index] = updatedValue;
            SaveDataToJsonFile(dataTransaksi);
            return NoContent();
        }
    }
}
