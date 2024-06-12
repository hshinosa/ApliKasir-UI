using LibraryKasir;
using System.Text.RegularExpressions;

namespace ApliKasir_UI
{
    public partial class InputBarang : Form
    {
        private const string BaseUrl = "https://localhost:7222";

        // Konstruktor untuk menginisialisasi komponen
        public InputBarang()
        {
            InitializeComponent();
        }

        // Event handler untuk klik tombol input
        private async void ButtonInput_Click(object sender, EventArgs e)
        {
            // Validasi nama barang
            if (!ValidateName(textBoxNama.Text, out string validatedName))
            {
                MessageBox.Show("Nama barang hanya boleh mengandung huruf dan spasi.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Membuat objek DataBarang baru dengan data yang telah di-parse
            var newBarang = new DataBarang
            {
                idBarang = await GenerateNewId(),
                namaBarang = validatedName,
                hargaBarang = SanitizedHarga(textBoxHarga.Text),
                jumlahBarang = SanitizedJumlah(textBoxJumlah.Text)
            };

            // Mengirim data barang baru ke server
            await Barang.CreateBarang(BaseUrl, newBarang);
            this.Hide();
        }

        // Metode untuk menghasilkan ID baru berdasarkan daftar barang yang ada
        private async Task<int> GenerateNewId()
        {
            var dataBarangList = await Barang.GetListBarang(BaseUrl);
            return (dataBarangList.LastOrDefault()?.idBarang ?? 0) + 1;
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
