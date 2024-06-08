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
            dataBarang.namaBarang = Regex.Replace(textBoxNama.Text.Trim(), "[^a-zA-Z\\s]", "");
            
            string hargaBarangSanitized = Regex.Replace(textBoxHarga.Text.Trim(), "[^0-9.]", "");
            dataBarang.hargaBarang = double.TryParse(hargaBarangSanitized, out double parsedHarga) ? parsedHarga : 0.0;

            string jumlahBarangSanitized = Regex.Replace(textBoxJumlah.Text.Trim(), "[^0-9]", "");
            dataBarang.jumlahBarang = int.TryParse(jumlahBarangSanitized, out int parsedJumlah) ? parsedJumlah : 0;

            Barang.CreateBarang("https://localhost:7222", dataBarang);

            this.Hide();
        }
    }
}
