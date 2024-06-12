using LibraryKasir;
using Newtonsoft.Json;

namespace API
{
    public class EditJson
    {
        private static string jsonFilePath = "json\\barang.json";
        private static List<DataBarang> databarang = InitializeDataFromJsonBarang(jsonFilePath);
        private static string jsonFilePath2 = "json\\transaksi.json";
        private static List<DataTransaksi> dataTransaksi = InitializeDataFromJsonTransaksi(jsonFilePath2);
        private static string jsonFilePath3 = "json\\hutang.json";
        private static List<DataHutang> datahutang = InitializeDataFromJsonHutang(jsonFilePath3);


        public static List<DataBarang> InitializeDataFromJsonBarang(string jsonFilePath)
        {
            List<DataBarang> data = new List<DataBarang>();
            if (System.IO.File.Exists(jsonFilePath))
            {
                string jsonData = System.IO.File.ReadAllText(jsonFilePath);
                data = JsonConvert.DeserializeObject<List<DataBarang>>(jsonData);
            }
            return data;
        }

        public static void SaveDataBarangToJsonFile(List<DataBarang> data)
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            System.IO.File.WriteAllText(jsonFilePath, jsonData);
        }
        public static List<DataTransaksi> InitializeDataFromJsonTransaksi(string jsonFilePath2)
        {
            List<DataTransaksi> data = new List<DataTransaksi>();
            if (System.IO.File.Exists(jsonFilePath2))
            {
                string jsonData = System.IO.File.ReadAllText(jsonFilePath2);
                data = JsonConvert.DeserializeObject<List<DataTransaksi>>(jsonData);
            }
            return data;
        }


        public static void SaveDataTransaksiToJsonFile(List<DataTransaksi> data)
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            System.IO.File.WriteAllText(jsonFilePath2, jsonData);
        }

        

        public static List<DataHutang> InitializeDataFromJsonHutang(string jsonFilePath3)
        {
            List<DataHutang> data = new List<DataHutang>();
            if (System.IO.File.Exists(jsonFilePath3))
            {
                string jsonData = System.IO.File.ReadAllText(jsonFilePath3);
                data = JsonConvert.DeserializeObject<List<DataHutang>>(jsonData);
            }
            return data;
        }


        public static void SaveDataHutangToJsonFile(List<DataHutang> data)
        {
            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            System.IO.File.WriteAllText(jsonFilePath3, jsonData);
        }

    }
    
}

   


