using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryKasir;

namespace ApliKasir_UI
{
    public partial class InputHutang : Form
    {
        public InputHutang()
        {
            InitializeComponent();
        }

        // Event handler untuk tombol klik
        private async void button1_Click(object sender, EventArgs e)
        {
            var dataHutang = new DataHutang();

            // Mengambil daftar data hutang dari API
            var dataHutangList = await Hutang.GetListHutang("https://localhost:7222");

            // Menentukan ID hutang terakhir dan menambah 1 untuk ID baru
            int lastId = dataHutangList.LastOrDefault()?.idHutang ?? 0;
            dataHutang.idHutang = lastId + 1;

            // Membersihkan dan menyaring input pengguna
            dataHutang.namaPelanggan = SanitizeInput(textBox1.Text, "[^a-zA-Z\\s]");
            dataHutang.namaBarang = SanitizeInput(textBox2.Text, "[^a-zA-Z\\s]");

            // Mengubah input harga dan jumlah barang menjadi nilai numerik
            dataHutang.totalHarga = ParseDouble(SanitizeInput(textBox3.Text, "[^0-9.]"));
            dataHutang.jumlahBarang = ParseInt(SanitizeInput(textBox3.Text, "[^0-9]"));

            // Mengirim data hutang yang baru dibuat ke API
            await Hutang.CreateHutang("https://localhost:7222", dataHutang);

            // Menyembunyikan form setelah data hutang berhasil ditambahkan
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
