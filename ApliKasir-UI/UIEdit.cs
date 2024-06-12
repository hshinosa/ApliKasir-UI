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

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void transaksiTabel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //penggunaan percabangan untuk mengecek apakah ada baris yang dipilih (tabel transksai)
                if (transaksiTabel.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in transaksiTabel.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            //untuk mendapatkan nilai dari kolom idTransaksi dari baris yang dipilih
                            var idx = row.Cells["idTransaksi"].Value;

                            //Validasi input sebelum konversi
                            if (idx != null && int.TryParse(idx.ToString(), out int id))
                            {
                                EditTransaksi editTransaksi = new EditTransaksi();
                                editTransaksi.Show();
                            }
                            else
                            {
                                MessageBox.Show("ID Transaksi tidak valid.");
                            }

                        }
                    }
                }


                //penggunaan percabangan untuk tabel hutang
                else if (hutangTabel.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in hutangTabel.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            //untuk mendapatkan nilai dari kolom idHutang dari baris yang dipilih
                            var idx2 = row.Cells["idHutang"].Value;

                            if (idx2 != null && int.TryParse(idx2.ToString(), out int id2))
                            {
                                EditHutang editHutang = new EditHutang();
                                editHutang.Show();
                            }
                            else
                            {
                                MessageBox.Show("Id Hutang tidak valid.");
                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Silakan pilih baris yang ingin diedit.");
                }
            }
            catch (Exception ex)
            {
                //Jika terjadi pengecualian, pesan kesalahan yang sesuai ditampilkan kepada pengguna
                MessageBox.Show("Terjadi kesalahan saat menghapus data: " + ex.Message);
            }
        }
    }
}