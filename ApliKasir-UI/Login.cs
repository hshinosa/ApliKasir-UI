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
        private readonly string apiBaseUrl = "https://localhost:7222/user"; // Ubah sesuai dengan URL API Anda
        private List<DataUser> users;

        public Login()
        {
            InitializeComponent();
            // Memuat data pengguna dari API saat inisialisasi form
            LoadUserData();
        }

        private async void LoadUserData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiBaseUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string jsonData = await response.Content.ReadAsStringAsync();
                        users = JsonConvert.DeserializeObject<List<DataUser>>(jsonData);
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

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Memeriksa apakah username atau password kosong
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tolong isi username dan password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Membuat objek User baru untuk login
            DataUser loginUser = new DataUser { Username = username, Password = password };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonData = JsonConvert.SerializeObject(loginUser);
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{apiBaseUrl}/login", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Login sukses!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuUtama menuUtama = new MenuUtama();
                        menuUtama.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login gagal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Memeriksa apakah username atau password kosong
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tolong isi username dan password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Membuat objek User baru untuk registrasi
            DataUser newUser = new DataUser { Username = username, Password = password };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonData = JsonConvert.SerializeObject(newUser);
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(apiBaseUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Register berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (response.StatusCode == HttpStatusCode.Conflict)
                    {
                        MessageBox.Show("Username sudah ada. tolong buat username yang lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Gagal mendaftarkan pengguna: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mendaftarkan pengguna: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
