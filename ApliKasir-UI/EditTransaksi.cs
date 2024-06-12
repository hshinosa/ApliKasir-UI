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
using ApliKasir_UI;



namespace ApliKasir_UI
{
    public partial class EditTransaksi : Form
    {
        private static string jsonFilePath = "json\\transaksi.json";
        private string baseUrl = "https://localhost:7222";
        private List<DataTransaksi> dataTransaksi;

        public static DataTransaksi DataBoundItem { get; private set; }

        public EditTransaksi()
        {
            InitializeComponent();
            LoadData();

        }

        private async Task LoadData()
        {
            //input data transaksi ke data gridview
            dataTransaksi = await Hitung.GetListTransaksi(baseUrl);

        }
        private void EditForm_Load(object sender, EventArgs e)
        {

        }
      

        private void inputId_TextChanged(object sender, EventArgs e)
        {

        }

        private async void updatebtn_Click(object sender, EventArgs e)
        {
            if (EditTransaksi.DataBoundItem is DataTransaksi selectedDataTransaksi)
            {
                //mengedit data dengan method BuatTransaksi baru
                Hitung.CreateTransaksi(baseUrl, selectedDataTransaksi);
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
