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
using Newtonsoft.Json;
using API;

namespace ApliKasir_UI
{
    public partial class UITambah : Form
    {
        private static string jsonFilePath = "D:\\IYA\\API\\json\\transaksi.json";
        private string baseUrl = "https://localhost:7222";
        private List<DataTransaksi> datatransaksi;
        public UITambah()
        {
            InitializeComponent();
            _ = this.LoadTransaksi();
        }

        private async Task LoadTransaksi()
        {
            //Clear data grid view
            dataGridView1.DataSource = null;

            //Input data barang to data grid view
            datatransaksi = await Hitung.GetListTransaksi(baseUrl);
            dataGridView1.DataSource = datatransaksi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ = this.LoadTransaksi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputTransaksi inputTransaksi = new InputTransaksi();
            inputTransaksi.Show();
        }
    }
}
