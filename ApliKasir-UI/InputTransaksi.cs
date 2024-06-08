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
            dataTransaksi.namaBarang = textBox1.Text;
            dataTransaksi.totalHarga = double.Parse(textBox2.Text);
            dataTransaksi.jumlahBarang = int.Parse(textBox3.Text);

            Hitung.CreateTransaksi("https://localhost:7222", dataTransaksi);

            this.Hide();
        }
    }
}
