using API.Controllers;
using LibraryKasir;

namespace ApliKasir_UI
{
    public partial class UIDataBarang : Form
    {
        private const string _baseUrl = "https://localhost:7222";
        private List<DataBarang> _listDataBarang;

        // Konstruktor untuk menginisialisasi komponen dan memuat data barang
        public UIDataBarang()
        {
            InitializeComponent();
            _ = LoadBarang();
        }

        // Metode untuk memuat data barang dari file JSON
        private async Task LoadBarang()
        {
            dataGridBarang.DataSource = null;
            _listDataBarang = await Barang.GetListBarang(_baseUrl);
            dataGridBarang.DataSource = _listDataBarang;
        }

        // Event handler untuk klik tombol hapus barang
        private void ButtonDeleteBarang_Click(object sender, EventArgs e)
        {
            if (dataGridBarang.SelectedRows.Count > 0)
            {
                DeleteSelectedBarangs();
                UpdateDataGrid();
            }
            else
            {
                MessageBox.Show("Silakan pilih baris yang akan dihapus.");
            }
        }

        // Event handler untuk klik tombol edit barang
        private void ButtonEditBarang_Click(object sender, EventArgs e)
        {
            if (dataGridBarang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridBarang.SelectedRows[0];
                if (selectedRow.DataBoundItem is DataBarang selectedDataBarang)
                {
                    int idBarang = selectedDataBarang.idBarang;
                    this.Hide();
                    using (EditBarang editBarang = new EditBarang(idBarang))
                    {
                        editBarang.ShowDialog();
                    }
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Data yang dipilih tidak valid.");
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih baris yang akan diedit.");
            }
        }

        // Metode untuk menghapus barang yang dipilih dari daftar dan memperbarui data grid
        private void DeleteSelectedBarangs()
        {
            var itemsToRemove = new List<DataBarang>();

            foreach (DataGridViewRow row in dataGridBarang.SelectedRows)
            {
                if (row.DataBoundItem is DataBarang selectedDataBarang)
                {
                    itemsToRemove.Add(selectedDataBarang);
                    _ = Barang.DeleteBarang(_baseUrl, selectedDataBarang.idBarang);
                }
            }

            foreach (var item in itemsToRemove)
            {
                _listDataBarang.Remove(item);
            }

            EditJson.SaveDataBarangToJsonFile(_listDataBarang);
        }

        // Metode untuk memperbarui data grid dengan daftar data barang yang telah diperbarui
        private void UpdateDataGrid()
        {
            dataGridBarang.DataSource = null;
            dataGridBarang.DataSource = _listDataBarang;
        }

        // Metode generik untuk menampilkan form tipe T
        private void ShowForm<T>() where T : Form, new()
        {
            this.Hide();
            using (T form = new T())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        // Event handler untuk berpindah menu
        private void buttonTambahBarang_Click(object sender, EventArgs e) => ShowForm<InputBarang>();

        private void buttonRefresh_Click(object sender, EventArgs e) => _ = LoadBarang();

        private void buttonLaporan_Click(object sender, EventArgs e) => ShowForm<MenuUtama>();

        private void buttonTambah_Click(object sender, EventArgs e) => ShowForm<UITambah>();

        private void buttonHapus_Click(object sender, EventArgs e) => ShowForm<UIHapus>();

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Close(); // Menutup form MenuUtama
            Application.Restart(); // Me-restart aplikasi untuk kembali ke form Login
        }

        private void buttonEdit_Click(object sender, EventArgs e) => ShowForm<UIEdit>();
    }
}
