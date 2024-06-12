using LibraryKasir;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApliKasir_UI
{
    public partial class EditBarang : Form
    {
        private const string BaseUrl = "https://localhost:7222";
        private int idBarang;

        // Konstruktor untuk menginisialisasi komponen
        public EditBarang(int idBarang)
        {
            InitializeComponent();
            this.idBarang = idBarang;
        }

        private async void buttonEdit_Click(object sender, EventArgs e)
        {
            // Validasi nama barang
            if (!ValidateName(textBoxNama.Text, out string validatedName))
            {
                MessageBox.Show("Nama barang hanya boleh mengandung huruf dan spasi.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Membuat objek DataBarang baru dengan data yang telah di-parse
            var dataBarang = new DataBarang
            {
                idBarang = this.idBarang,
                namaBarang = validatedName,
                hargaBarang = SanitizedHarga(textBoxHarga.Text),
                jumlahBarang = SanitizedJumlah(textBoxJumlah.Text)
            };

            // Mengirim data barang yang telah diperbarui ke server
            await Barang.UpdateBarang(BaseUrl, idBarang, dataBarang);
            this.Hide();
        }

        // Metode untuk memvalidasi nama barang agar hanya mengandung huruf dan spasi
        private bool ValidateName(string input, out string validatedName)
        {
            validatedName = input.Trim();
            if (Regex.IsMatch(validatedName, "^[a-zA-Z\\s]+$"))
            {
                return true;
            }
            validatedName = string.Empty;
            return false;
        }

        // Metode untuk mensanitasi harga barang dari string ke double
        private double SanitizedHarga(string input)
        {
            string sanitizedInput = Regex.Replace(input.Trim(), "[^0-9.]", "");
            return double.TryParse(sanitizedInput, out double result) ? result : 0.0;
        }

        // Metode untuk mensanitasi jumlah barang dari string ke integer
        private int SanitizedJumlah(string input)
        {
            string sanitizedInput = Regex.Replace(input.Trim(), "[^0-9]", "");
            return int.TryParse(sanitizedInput, out int result) ? result : 0;
        }
    }
}
