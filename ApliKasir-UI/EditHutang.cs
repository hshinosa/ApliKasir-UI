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
        private string baseUrl = "https://localhost:7222";
        private int idHutang;

        public static DataHutang DataBoundItem { get; set; }
        public EditHutang(int idHutang)
        {
            InitializeComponent();
            this.idHutang = idHutang;
        }

        private async void UpdateBtn_Click(object sender, EventArgs e)
        {
            int jumlahBarang;
            if (int.TryParse(inputJumlahBarang.Text, out jumlahBarang))
            {
                var dataHutang = new DataHutang
                {
                    idHutang = this.idHutang,
                    namaPelanggan = inputNamaPelanggan.Text,
                    namaBarang = inputNamaBarang.Text,
                    jumlahBarang = jumlahBarang
                };
                await Hutang.UpdateHutang(baseUrl, idHutang, dataHutang);
                this.Close();
            }
        }
    }
}
