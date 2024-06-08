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
    public partial class EditBarang : Form
    {
        int idBarang;
        public EditBarang(int idBarang)
        {
            InitializeComponent();
            this.idBarang = idBarang;
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            DataBarang dataBarang = new DataBarang();

            dataBarang.idBarang = this.idBarang;
            dataBarang.namaBarang = textBoxNama.Text;
            dataBarang.hargaBarang = double.Parse(textBoxHarga.Text);
            dataBarang.jumlahBarang = int.Parse(textBoxJumlah.Text);

            await Barang.UpdateBarang("https://localhost:7222", idBarang, dataBarang);
            this.Hide();
        }
    }
}
