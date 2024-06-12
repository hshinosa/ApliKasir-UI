using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using LibraryKasir;

namespace ApliKasir_UI
{
    public partial class UIEdit : Form
    {
        //deklarasi json untuk transaksi dan hutang
        private static string jsonFilePath = "json\\transaksi.json";
        private static string jsonFilePath2 = "json\\hutang.json";
        private string baseUrl = "https://localhost:7222";
        private List<DataTransaksi> dataTransaksi;
        private List<DataHutang> dataHutang;

        public UIEdit()
        {
            InitializeComponent();
            LoadData();
        }

        //LoadData untuk menampilkan data dari json ke datagrid
        private async Task LoadData()
        {
            //Refresh data grid view
            transaksiTabel.DataSource = null;
            hutangTabel.DataSource = null;

            //Input data barang ke data grid view
            dataTransaksi = await Hitung.GetListTransaksi(baseUrl);
            dataHutang = await Hutang.GetListHutang(baseUrl);

            transaksiTabel.DataSource = dataTransaksi;
            hutangTabel.DataSource = dataHutang;
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

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void transaksiTabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEditTransaksi_Click(object sender, EventArgs e)
        {
                //penggunaan percabangan untuk mengecek apakah ada baris yang dipilih (tabel transksai)
                if (transaksiTabel.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRowTransaksi = transaksiTabel.SelectedRows[0];
                    if (selectedRowTransaksi.DataBoundItem is DataTransaksi selectedDataTransaksi)
                    {
                        int idTransaksi = selectedDataTransaksi.idTransaksi;
                        this.Hide();
                        using (EditTransaksi editTransaksi = new EditTransaksi(idTransaksi))
                        {
                            editTransaksi.ShowDialog();
                        }
                        this.Show();
                    }
                }
                //penggunaan percabangan untuk tabel hutang
                else if (hutangTabel.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRowHutang = hutangTabel.SelectedRows[0];
                    if (selectedRowHutang.DataBoundItem is DataHutang selectedDataBarang)
                    {
                        int idHutang = selectedDataBarang.idHutang;
                        this.Hide();
                        using (EditHutang EditHutang = new EditHutang(idHutang))
                        {
                            EditHutang.ShowDialog();
                        }
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Silakan pilih baris yang ingin diedit.");
                }
        }

        private void buttonLaporan_Click(object sender, EventArgs e) => ShowForm<MenuUtama>();

        private void buttonDataBarang_Click(object sender, EventArgs e) => ShowForm<UIDataBarang>();

        private void buttonTambah_Click(object sender, EventArgs e) => ShowForm<UITambah>();

        private void buttonHapus_Click(object sender, EventArgs e) => ShowForm<UIHapus>();
        private void buttonEdit_Click(object sender, EventArgs e) => ShowForm<UIEdit>();

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Close(); // Menutup form MenuUtama
            Application.Restart(); // Me-restart aplikasi untuk kembali ke form Login
        }
    }
}