using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using LibraryKasir;
using System.Text;
using System.Net;

namespace ApliKasir_UI
{
    public partial class Login : Form
    {
        private readonly string _apiBaseUrl = "https://localhost:7222/user"; // Ubah sesuai dengan URL API Anda
        private Dictionary<string, DataUser> _users;

        public Login()
        {
            InitializeComponent();
            // Memuat data pengguna dari API saat inisialisasi form
            LoadUserData();
        }

        // Metode untuk memuat data pengguna di json dari API ke dalam dictionary
        private async void LoadUserData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(_apiBaseUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();
                        // Mengonversi JSON menjadi list
                        List<DataUser> userList = JsonConvert.DeserializeObject<List<DataUser>>(jsonData);

                        // Membuat dictionary dari list
                        _users = userList.ToDictionary(user => user.Username);

                    }
                    else
                    {
                        MessageBox.Show($"Gagal mengambil data user: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengambil data user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metode untuk menangani klik tombol login
        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tolong isi username dan password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool loginSuccess = await LoginService.Instance.LoginUser(username, password);

                if (loginSuccess)
                {
                    MessageBox.Show("Login sukses!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    using (MenuUtama menuUtama = new MenuUtama())
                    {
                        menuUtama.ShowDialog();
                    }
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Username atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metode untuk menangani klik tombol register
        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tolong isi username dan password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool registerSuccess = await RegisterService.Instance.RegisterUser(username, password);

                if (registerSuccess)
                {
                    MessageBox.Show("Register berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this) // Kecuali form utama (opsional)
                {
                    form.Close();
                }
            }
            // Menutup form utama (jika diperlukan)
            this.Close();
        }
    }
}