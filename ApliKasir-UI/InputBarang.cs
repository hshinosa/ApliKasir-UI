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
    public partial class InputBarang : Form
    {
        public InputBarang()
        {
            InitializeComponent();
        }

        private async void buttonInput(object sender, EventArgs e)
        {
            DataBarang dataBarang = new DataBarang();
            List<DataBarang> dataBarangList = await Barang.GetListBarang("https://localhost:7222"); // Assuming you have a list of DataBarang objects

            int total = dataBarangList.Count();
            int lastId = dataBarangList.LastOrDefault()?.idBarang ?? 0; // Get the last ID in the list, or 0 if the list is empty

            dataBarang.idBarang = total + 1;
            dataBarang.namaBarang = textBoxNama.Text;
            dataBarang.hargaBarang = double.Parse(textBoxHarga.Text);
            dataBarang.jumlahBarang = int.Parse(textBoxJumlah.Text);

            Barang.CreateBarang("https://localhost:7222", dataBarang);

            this.Hide();
        }
    }
}
