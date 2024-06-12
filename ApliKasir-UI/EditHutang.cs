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
    public partial class EditHutang : Form
    {
        private static string jsonFilePath2 = "json\\hutang.json";
        private string baseUrl = "https://localhost:7222";
        private List<DataHutang> dataHutang;

        public static DataHutang DataBoundItem { get; set; }
        public EditHutang()
        {
            InitializeComponent();
            LoadData();
        }

        private async Task LoadData()
        {
            //input data transaksi ke data gridview
            dataHutang = await Hutang.GetListHutang(baseUrl);

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (EditHutang.DataBoundItem is DataHutang selectedDataHutang)
            {
                //mengedit data dengan method BuatHutang baru
                Hitung.CreateHutang(baseUrl, selectedDataHutang);
                MessageBox.Show("Data berhasil diedit");
                LoadData();
            }
            else
            {   //memanggil MessageBox jika input tidak valid
                MessageBox.Show("Data yang dimasukkan tidak valid.");
            }
        }
    }
}
