using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryKasir;
using System.Text.RegularExpressions;

namespace ApliKasir_UI
{
    public partial class InputTransaksi : Form
    {
        public InputTransaksi()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DataTransaksi dataTransaksi = new DataTransaksi();
            List<DataTransaksi> dataTransaksiList = await Hitung.GetListTransaksi("https://localhost:7222");

            int LastId = dataTransaksiList.LastOrDefault()?.idTransaksi ?? 0;

            dataTransaksi.idTransaksi = LastId + 1;
            
            dataTransaksi.namaBarang = Regex.Replace(textBox1.Text.Trim(), "[^a-zA-Z\\s]", "");

            string totakHargaSanitized =
            Regex.Replace(textBox2.Text.Trim(), "[^0-9.]", "");

            dataTransaksi.totalHarga = double.TryParse(totakHargaSanitized, out double parsedTotalHarga) ? parsedTotalHarga : 0.0;

            string jumlahBarangSanitized = Regex.Replace(textBox3.Text.Trim(), "[^0-9]", "");
            dataTransaksi.jumlahBarang = int.TryParse(jumlahBarangSanitized, out int parsedJumlah) ? parsedJumlah : 0;

            Hitung.CreateTransaksi("https://localhost:7222", dataTransaksi);

            this.Hide();
        }
    }
}
