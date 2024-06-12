using LibraryKasir;
using Newtonsoft.Json;

namespace API
{
    public class EditJsonBarang
    {
        private static string jsonFilePath = "json\\barang.json";
        private static List<DataBarang> databarang = InitializeDataFromJson(jsonFilePath);

        public static List<DataBarang> InitializeDataFromJson(string jsonFilePath)
        {
            List<DataBarang> data = new List<DataBarang>();
            if (System.IO.File.Exists(jsonFilePath))
            {
                string jsonData = System.IO.File.ReadAllText(jsonFilePath);
                data = JsonConvert.DeserializeObject<List<DataBarang>>(jsonData);
            }
            return data;
        }

        public static void SaveDataToJsonFile(List<DataBarang> data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                System.IO.File.WriteAllText(jsonFilePath, json);
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"An error occurred while saving data: {ex.Message}"); // Show error message
            }
        }

    }
}
