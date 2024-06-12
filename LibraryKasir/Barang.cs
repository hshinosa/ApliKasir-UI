
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace LibraryKasir
{
    public static class Barang
    {
        public static async Task CreateBarang(string baseUrl, DataBarang barang)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = JsonSerializer.Serialize(barang);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{baseUrl}/DataBarang", content);
                    response.EnsureSuccessStatusCode(); // Throw if not a success code
                    Console.WriteLine($"Barang berhasil ditambahkan dengan ID {barang.idBarang}.");
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public static async Task DeleteBarang(string baseUrl, int idBarang)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Mengonstruksi URL dengan parameter idBarang
                    HttpResponseMessage response = await client.DeleteAsync($"{baseUrl}/DataBarang/{idBarang}");
                    response.EnsureSuccessStatusCode(); // Memastikan kode respons adalah kode sukses

                    Console.WriteLine($"Barang with ID {idBarang} deleted successfully.");
                }
                catch (HttpRequestException ex)
                {
                    // Mencetak pesan error jika terjadi kesalahan dalam request HTTP
                    Console.WriteLine($"Error deleting barang: {ex.Message}");
                }
            }
        }
        public static async Task<List<DataBarang>> GetListBarang(string baseUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{baseUrl}/DataBarang");
                    response.EnsureSuccessStatusCode(); // Throw if not a success code

                    string json = await response.Content.ReadAsStringAsync();
                    List<DataBarang> barangList = JsonSerializer.Deserialize<List<DataBarang>>(json);

                    return barangList;
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return null;
                }
            }
        }
        public static async Task UpdateBarang(string baseUrl, int idBarang, DataBarang updatedBarang)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = JsonSerializer.Serialize(updatedBarang);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PutAsync($"{baseUrl}/DataBarang/{idBarang}", content);
                    response.EnsureSuccessStatusCode(); // Ensures throwing an exception if the HTTP response status indicates failure

                    Console.WriteLine($"Barang with ID {idBarang} has been successfully updated.");
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error updating barang: {ex.Message}");
                }
            }
        }
    }
}
