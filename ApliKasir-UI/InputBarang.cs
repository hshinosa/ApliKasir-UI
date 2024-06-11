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
            // Membuat objek DataBarang baru dengan data yang telah disanitasi dan di-parse
            var newBarang = new DataBarang
            {
                idBarang = await GenerateNewId(),
                namaBarang = SanitizeName(textBoxNama.Text),
                hargaBarang = ParseHarga(textBoxHarga.Text),
                jumlahBarang = ParseJumlah(textBoxJumlah.Text)
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

        // Metode untuk mensanitasi nama barang agar hanya mengandung huruf dan spasi
        private string SanitizeName(string input)
        {
            return Regex.Replace(input.Trim(), "[^a-zA-Z\\s]", "");
        }

        // Metode untuk mensanitasi harga barang dari string ke double
        private double ParseHarga(string input)
        {
            string sanitizedInput = Regex.Replace(input.Trim(), "[^0-9.]", "");
            return double.TryParse(sanitizedInput, out double result) ? result : 0.0;
        }

        // Metode untuk mensanitasi jumlah barang dari string ke integer
        private int ParseJumlah(string input)
        {
            string sanitizedInput = Regex.Replace(input.Trim(), "[^0-9]", "");
            return int.TryParse(sanitizedInput, out int result) ? result : 0;
        }
    }
}
