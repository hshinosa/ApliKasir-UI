using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryKasir;

namespace ApliKasir_UI
{
    public partial class InputTransaksi : Form
    {
        public InputTransaksi()
        {
            InitializeComponent();
        }

        // Event handler untuk klik pada tombol
        private async void buttonSimpan_Click(object sender, EventArgs e)
        {
            var dataTransaksi = new DataTransaksi();

            // Mengambil daftar data transaksi dari API
            var dataTransaksiList = await Hitung.GetListTransaksi("https://localhost:7222");

            // Menentukan ID transaksi terakhir dan menambah 1 untuk ID baru
            int lastId = dataTransaksiList.LastOrDefault()?.idTransaksi ?? 0;
            dataTransaksi.idTransaksi = lastId + 1;

            // Membersihkan dan menyaring input pengguna
            dataTransaksi.namaBarang = SanitizeInput(textBox1.Text, "[^a-zA-Z\\s]");

            // Mengubah input harga dan jumlah barang menjadi nilai numerik
            dataTransaksi.totalHarga = ParseDouble(SanitizeInput(textBox2.Text, "[^0-9.]"));
            dataTransaksi.jumlahBarang = ParseInt(SanitizeInput(textBox3.Text, "[^0-9]"));

            // Mengirim data transaksi yang baru dibuat ke API
            await Hitung.CreateTransaksi("https://localhost:7222", dataTransaksi);

            // Menyembunyikan form setelah data transaksi berhasil ditambahkan
            this.Hide();
        }

        // Fungsi untuk membersihkan input menggunakan regex
        private string SanitizeInput(string input, string pattern)
        {
            return Regex.Replace(input.Trim(), pattern, "");
        }

        // Fungsi untuk mengubah string menjadi double
        private double ParseDouble(string input)
        {
            return double.TryParse(input, out double result) ? result : 0.0;
        }

        // Fungsi untuk mengubah string menjadi integer
        private int ParseInt(string input)
        {
            return int.TryParse(input, out int result) ? result : 0;
        }
    }
}
