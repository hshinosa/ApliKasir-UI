using LibraryKasir;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using API;

namespace ApliKasir_UI
{
    public partial class UITambah : Form
    {
        private static readonly string jsonFilePath1 = "D:\\IYA\\API\\json\\transaksi.json";
        private static readonly string jsonFilePath2 = "D:\\IYA\\API\\json\\hutang.json";
        private readonly string baseUrl = "https://localhost:7222";
        private List<DataTransaksi> dataTransaksi;
        private List<DataHutang> dataHutang;

        public UITambah()
        {
            InitializeComponent();
            LoadTransaksi();
            LoadHutang();
        }

        // Memuat data transaksi dari API dan menampilkannya di DataGridView
        private async Task LoadTransaksi()
        {
            // Mengosongkan DataGridView
            dataGridView1.DataSource = null;

            // Mengambil data transaksi dari API
            dataTransaksi = await Hitung.GetListTransaksi(baseUrl);

            // Menampilkan data transaksi di DataGridView
            dataGridView1.DataSource = dataTransaksi;
        }

        // Memuat data hutang dari API dan menampilkannya di DataGridView
        private async Task LoadHutang()
        {
            // Mengosongkan DataGridView
            dataGridView2.DataSource = null;

            // Mengambil data hutang dari API
            dataHutang = await Hutang.GetListHutang(baseUrl);

            // Menampilkan data hutang di DataGridView
            dataGridView2.DataSource = dataHutang;
        }

        // Event handler untuk tombol Refresh
        private async void button1_Click(object sender, EventArgs e)
        {
            await LoadTransaksi();
            await LoadHutang();
        }

        // Event handler untuk tombol Tambah Transaksi
        private void button2_Click(object sender, EventArgs e)
        {
            InputTransaksi inputTransaksi = new InputTransaksi();
            inputTransaksi.Show();
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // Event handler untuk tombol Tambah Hutang
        private void button3_Click(object sender, EventArgs e)
        {
            InputHutang inputHutang = new InputHutang();
            inputHutang.Show();
        }
    }
}
