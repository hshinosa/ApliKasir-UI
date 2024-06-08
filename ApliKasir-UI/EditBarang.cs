using LibraryKasir;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            dataBarang.namaBarang = Regex.Replace(textBoxNama.Text.Trim(), "[^a-zA-Z\\s]", "");

            string hargaBarangSanitized = Regex.Replace(textBoxHarga.Text.Trim(), "[^0-9.]", "");
            dataBarang.hargaBarang = double.TryParse(hargaBarangSanitized, out double parsedHarga) ? parsedHarga : 0.0;

            string jumlahBarangSanitized = Regex.Replace(textBoxJumlah.Text.Trim(), "[^0-9]", "");
            dataBarang.jumlahBarang = int.TryParse(jumlahBarangSanitized, out int parsedJumlah) ? parsedJumlah : 0;

            await Barang.UpdateBarang("https://localhost:7222", idBarang, dataBarang);
            this.Hide();
        }
    }
}
