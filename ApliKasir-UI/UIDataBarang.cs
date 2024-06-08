using LibraryKasir;
using System.Windows.Forms;

namespace ApliKasir_UI
{
    public partial class UIDataBarang : Form
    {
        private static string jsonFilePath = "json\\barang.json";
        private string baseUrl = "https://localhost:7222";
        private List<DataBarang> listDataBarang;
        public UIDataBarang()
        {
            InitializeComponent();
            _ = this.LoadBarang();
        }

        private async Task LoadBarang()
        {
            //Clear data grid view
            dataGridBarang.DataSource = null;

            //Input data barang to data grid view
            listDataBarang = await Barang.GetListBarang(baseUrl);
            dataGridBarang.DataSource = listDataBarang;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputBarang inputBarang = new InputBarang();
            inputBarang.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            _ = this.LoadBarang();
        }

        private void buttonLaporan_Click(object sender, EventArgs e)
        {
            MenuUtama menuUtama = new MenuUtama();
            this.Hide();
            menuUtama.Show();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            UITambah uITambah = new UITambah();
            this.Hide();
            uITambah.Show();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            UIHapus uIHapus = new UIHapus();
            this.Hide();
            uIHapus.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            UIEdit uIEdit = new UIEdit();
            this.Hide();
            uIEdit.Show();
        }

        private void buttonDeleteBarang_Click(object sender, EventArgs e)
        {
            if (dataGridBarang.SelectedRows.Count > 0)
            {
                // Create a list to store the selected items to be deleted
                List<DataBarang> itemsToRemove = new List<DataBarang>();

                // Collect the selected items to be deleted
                foreach (DataGridViewRow row in dataGridBarang.SelectedRows)
                {
                    DataBarang selectedDataBarang = row.DataBoundItem as DataBarang;
                    if (selectedDataBarang != null)
                    {
                        // Add to list for local removal
                        itemsToRemove.Add(selectedDataBarang);
                        // Call the API to delete the barang based on idBarang
                        Barang.DeleteBarang(baseUrl, selectedDataBarang.idBarang);
                    }
                }

                // Remove the selected items from listDataBarang
                foreach (var item in itemsToRemove)
                {
                    listDataBarang.Remove(item);
                }

                // Save the updated list to the JSON file
                API.EditJsonBarang.SaveDataToJsonFile(listDataBarang);

                // Refresh the DataGridView
                dataGridBarang.DataSource = null;
                dataGridBarang.DataSource = listDataBarang;
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

    }
}
