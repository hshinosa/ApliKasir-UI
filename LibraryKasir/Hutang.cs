﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static LibraryKasir.Barang;

namespace LibraryKasir
{
    public static class Hutang
    {
        public static async Task CreateHutang(string baseUrl, DataHutang hutang)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string json = JsonSerializer.Serialize(hutang);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{baseUrl}/DataHutang", content);
                    response.EnsureSuccessStatusCode(); // Throw if not a success code
                    Console.WriteLine($"Hutang berhasil ditambahkan dengan ID {hutang.idHutang}.");
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        public static async Task<List<DataHutang>> GetListHutang(string baseUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"{baseUrl}/DataHutang");
                    response.EnsureSuccessStatusCode(); // Throw if not a success code

                    string json = await response.Content.ReadAsStringAsync();
                    List<DataHutang> hutangList = JsonSerializer.Deserialize<List<DataHutang>>(json);

                    return hutangList;
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return null;
                }
            }
        }


        public static async Task DeleteHutang(string baseUrl, int idHutang)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Mengonstruksi URL dengan parameter idHutang
                    HttpResponseMessage response = await client.DeleteAsync($"{baseUrl}/DataHutang/{idHutang}");
                    response.EnsureSuccessStatusCode(); // Memastikan kode respons adalah kode sukses

                    Console.WriteLine($"Hutang with ID {idHutang} deleted successfully.");
                }
                catch (HttpRequestException ex)
                {
                    // Mencetak pesan error jika terjadi kesalahan dalam request HTTP
                    Console.WriteLine($"Error deleting hutang: {ex.Message}");
                }
            }
        }
    }
}
