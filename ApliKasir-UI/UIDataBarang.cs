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
using Newtonsoft.Json;
using API; 

namespace ApliKasir_UI
{
    public partial class UIDataBarang : Form
    {
        private static string jsonFilePath = "json\\barang.json";
        private string baseUrl = "https://localhost:7222";
        private List<DataBarang> databarang;
        

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
            databarang = await Barang.GetListBarang(baseUrl);
            dataGridBarang.DataSource = databarang;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableDataBarang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDataBarang_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var data = (List<DataBarang>)this.dataGridBarang.DataSource;
            API.EditJson.SaveDataBarangToJsonFile(data);
            _ = this.LoadBarang();
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
    }
}
