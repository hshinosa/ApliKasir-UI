using LibraryKasir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApliKasir_UI
{
    public partial class MenuUtama : Form
    {
        private static readonly string jsonFilePath = "json\\barang.json";
        private readonly string baseUrl = "https://localhost:7222";
        private List<DataBarang> databarang;
        private List<DataTransaksi> datatransaksi;
        private List<DataHutang> datahutang;

        public MenuUtama()
        {
            InitializeComponent();
            LoadData();
        }

        private void buttonDataBarang_Click(object sender, EventArgs e)
        {
            using (UIDataBarang dataBarangForm = new UIDataBarang())
            {
                dataBarangForm.ShowDialog();
            }
        }

        private async Task LoadData()
        {
            try
            {
                //Clear data grid view
                dataGridBarang.DataSource = null;
                dataGridTransaksi.DataSource = null;
                dataGridHutang.DataSource = null;

                //Input data barang to data grid view
                databarang = await Barang.GetListBarang(baseUrl);
                datatransaksi = await Hitung.GetListTransaksi(baseUrl);
                datahutang = await Hutang.GetListHutang(baseUrl);
                dataGridBarang.DataSource = databarang;
                dataGridTransaksi.DataSource = datatransaksi;
                dataGridHutang.DataSource = datahutang;
            }
            catch (Exception ex)
            {
                // Log the exception or display an error message
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            using (UITambah tambahForm = new UITambah())
            {
                tambahForm.ShowDialog();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            using (UIHapus hapusForm = new UIHapus())
            {
                hapusForm.ShowDialog();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (UIEdit editForm = new UIEdit())
            {
                editForm.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Login loginForm = new Login())
            {
                loginForm.ShowDialog();
            }
        }
    }
}