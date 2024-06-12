
using LibraryKasir;
using System;
using System.Windows.Forms;
namespace ApliKasir_UI
{
    public partial class MenuUtama : Form
    {
        private readonly string baseUrl = "https://localhost:7222";
        private List<DataBarang> databarang;
        private List<DataTransaksi> datatransaksi;
        private List<DataHutang> datahutang;
        public MenuUtama()
        {
            InitializeComponent();
            LoadData();
        }
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Close(); // Menutup form MenuUtama
            Application.Restart(); // Me-restart aplikasi untuk kembali ke form Login
        }

        private void ShowForm<T>() where T : Form, new()
        {
            Hide();
            using (T form = new T())
            {
                form.ShowDialog();
            }
            Show();
        }

        
        // Mengambil data dari Json
        private async Task LoadData()
        {
            //Implementasi design by contract 
            try
            {
                //Clear data grid view
                dataGridBarang.DataSource = null;
                dataGridTransaksi.DataSource = null;
                dataGridHutang.DataSource = null;

                //Input data barang to data grid view
                databarang = await Barang.GetListBarang(baseUrl);
                datatransaksi = await Hitung.GetListTransaksi(baseUrl);
                datahutang = await Hutang.GetListHutang(baseUrl);
                dataGridBarang.DataSource = databarang;
                dataGridTransaksi.DataSource = datatransaksi;
                dataGridHutang.DataSource = datahutang;
            }
            catch (Exception ex)
            {
                // Log the exception or display an error message
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
        }

        // Event handler untuk berpindah menu
        private void buttonDataBarang_Click(object sender, EventArgs e) => ShowForm<UIDataBarang>();

        private void buttonTambah_Click(object sender, EventArgs e) => ShowForm<UITambah>();

        private void buttonHapus_Click(object sender, EventArgs e) => ShowForm<UIHapus>();

        private void buttonEdit_Click(object sender, EventArgs e) => ShowForm<UIEdit>();
    }
}