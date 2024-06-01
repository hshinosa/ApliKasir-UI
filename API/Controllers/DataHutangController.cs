﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using LibraryKasir;

namespace API.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class DataHutangController : ControllerBase
        {
            private static string jsonFilePath = "json\\hutang.json";
            private static List<DataHutang> dataHutang = InitializeDataFromJson(jsonFilePath);

            private static List<DataHutang> InitializeDataFromJson(string jsonFilePath)
            {
                List<DataHutang> data = new List<DataHutang>();
                if (System.IO.File.Exists(jsonFilePath))
                {
                    string jsonData = System.IO.File.ReadAllText(jsonFilePath);
                    data = JsonConvert.DeserializeObject<List<DataHutang>>(jsonData);
                }
                return data;
            }

            private static void SaveDataToJsonFile(List<DataHutang> data)
            {
                string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
                System.IO.File.WriteAllText(jsonFilePath, jsonData);
            }

            [HttpGet]
            public IEnumerable<DataHutang> Get()
            {
                return dataHutang;
            }

            [HttpPost]
            public IActionResult Post([FromBody] DataHutang newValue)
            {
                dataHutang.Add(newValue);
                SaveDataToJsonFile(dataHutang);
                return Ok();
            }


            [HttpGet("{id}")]
            public ActionResult<DataHutang> Get(int id)
            {
                if (id < 0 || id >= dataHutang.Count)
                {
                    return NotFound();
                }

                return dataHutang[id];
            }

        [HttpDelete("{idHutang}")]
        public IActionResult Delete(int idHutang)
        {
            var item = dataHutang.FirstOrDefault(b => b.idHutang == idHutang);

            if (item == null)
            {
                return NotFound();
            }

            dataHutang.Remove(item);
            SaveDataToJsonFile(dataHutang);
            return NoContent();
        }
    }
    }

