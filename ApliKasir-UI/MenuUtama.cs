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
        private static string jsonFilePath = "json\\barang.json";
        private string baseUrl = "https://localhost:7222";
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
            UIDataBarang dataBarangForm = new UIDataBarang();
            dataBarangForm.Show();
            this.Hide();
        }

        private async Task LoadData()
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelPemasukan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            UITambah tambahForm = new UITambah();
            tambahForm.Show();
            this.Hide();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            UIHapus hapusForm = new UIHapus();
            hapusForm.Show();
            this.Hide();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            UIEdit editForm = new UIEdit();
            editForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
