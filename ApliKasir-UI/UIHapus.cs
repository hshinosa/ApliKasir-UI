using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using LibraryKasir;

namespace ApliKasir_UI
{
    public partial class UIHapus : Form
    {
        private static string jsonFilePath = "json\\transaksi.json";
        private static string jsonFilePath2 = "json\\hutang.json";
        private string baseUrl = "https://localhost:7222";
        private List<DataTransaksi> datatransaksi;
        private List<DataHutang> dataHutang;
        public UIHapus()
        {
            InitializeComponent();
            LoadData();
        }

        private async Task LoadData()
        {
            //Clear data grid view
            tabel_transaksi.DataSource = null;


            //Input data barang to data grid view
            datatransaksi = await Hitung.GetListTransaksi(baseUrl);
            dataHutang = await Hutang.GetListHutang(baseUrl);

            tabel_transaksi.DataSource = datatransaksi;
            tabel_hutang.DataSource = dataHutang;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tabel_transaksi.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in tabel_transaksi.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        var idx = row.Cells["idTransaksi"].Value;
                        int id = Convert.ToInt32(idx);
                        Hitung.DeleteTransaksi(baseUrl, id);
                        MessageBox.Show("Data Berhasil Dihapus");
                        LoadData();
                    }
                }
            }
            else if (tabel_hutang.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in tabel_hutang.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        var idx2 = row.Cells["idHutang"].Value;
                        int id2 = Convert.ToInt32(idx2);
                        Hutang.DeleteHutang(baseUrl, id2);
                        MessageBox.Show("Data Berhasil Dihapus");
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang ingin dihapus.");
            }
        }
    }
}
