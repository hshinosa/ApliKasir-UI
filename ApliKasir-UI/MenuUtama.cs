using System;
using System.Windows.Forms;
using LibraryKasir;

namespace ApliKasir_UI
{
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
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

        private void buttonDataBarang_Click(object sender, EventArgs e)
        {
            ShowForm<UIDataBarang>(); // Membuka form UIDataBarang
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            ShowForm<UITambah>(); // Membuka form UITambah
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            ShowForm<UIHapus>(); // Membuka form UIHapus
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ShowForm<UIEdit>(); // Membuka form UIEdit
        }
    }
}
