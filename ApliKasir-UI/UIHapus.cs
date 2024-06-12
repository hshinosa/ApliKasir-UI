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
    public partial class UIHapus : Form
    {
        //deklarasi json untuk transaksi dan hutang
        private static string jsonFilePath = "json\\transaksi.json";
        private static string jsonFilePath2 = "json\\hutang.json";
        private string baseUrl = "https://localhost:7222";
        private List<DataTransaksi> datatransaksi;
        private List<DataHutang> dataHutang;
        public UIHapus()
        {
            InitializeComponent();
            LoadData();
        }

        //LoadData untuk menampilkan data dari json ke datagrid
        private async Task LoadData()
        {
            //Clear data grid view
            tabel_transaksi.DataSource = null;


            //Input data barang to data grid view
            datatransaksi = await Hitung.GetListTransaksi(baseUrl);
            dataHutang = await Hutang.GetListHutang(baseUrl);

            tabel_transaksi.DataSource = datatransaksi;
            tabel_hutang.DataSource = dataHutang;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //penggunaan try-catch  untuk menangani pengecualian yang mungkin terjadi selama proses penghapusan data
            try
            {
                //penggunaan percabangan untuk mengecek apakah ada baris yang dipilih
                if (tabel_transaksi.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in tabel_transaksi.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            //mendapatkan nilai id dari kolom idTransaksi dari baris yang dipilih
                            var idx = row.Cells["idTransaksi"].Value;

                            // Validasi input sebelum konversi
                            if (idx != null && int.TryParse(idx.ToString(), out int id))
                            {
                                //menghapus data dengan method DeleteTransaksi
                                Hitung.DeleteTransaksi(baseUrl, id);
                                MessageBox.Show("Data Berhasil Dihapus");
                                LoadData();
                            }
                            else
                            {
                                //memanggil MessageBox jika input tidak valid
                                MessageBox.Show("ID Transaksi tidak valid.");
                            }
                        }
                    }
                }
                //penggunaan percabangan untuk mengecek apakah ada baris yang dipilih
                else if (tabel_hutang.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in tabel_hutang.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            //mendapatkan nilai id dari kolom idTransaksi dari baris yang dipilih
                            var idx2 = row.Cells["idHutang"].Value;

                            // Validasi input sebelum konversi
                            if (idx2 != null && int.TryParse(idx2.ToString(), out int id2))
                            {
                                //menghapus data dengan method DeleteHutang
                                Hutang.DeleteHutang(baseUrl, id2);
                                MessageBox.Show("Data Berhasil Dihapus");
                                LoadData();
                            }
                            else
                            {
                                //memanggil MessageBox jika input tidak valid
                                MessageBox.Show("ID Hutang tidak valid.");
                            }
                        }
                    }
                }
                else
                {
                    //memanggil MessageBox tidak ada baris yang dipilih
                    MessageBox.Show("Pilih baris yang ingin dihapus.");
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
