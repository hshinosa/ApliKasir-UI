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
        private string baseUrl = "https://localhost:7222";
        private int idTransaksi;

        public static DataTransaksi DataBoundItem { get; private set; }

        public EditTransaksi(int idTransaksi)
        {
            InitializeComponent();
            this.idTransaksi = idTransaksi;
        }

        private async void updatebtn_Click(object sender, EventArgs e)
        {
            int jumlahBarang;
            if (int.TryParse(inputJumlahBarang.Text, out jumlahBarang))
            {
                var dataTransaksi = new DataTransaksi
                {
                    idTransaksi = this.idTransaksi,
                    namaBarang = inputNamaBarang.Text,
                    jumlahBarang = jumlahBarang
                };
                await Hitung.UpdateTransaksi(baseUrl, idTransaksi, dataTransaksi);
                this.Close();
            }
        }
    }
}
