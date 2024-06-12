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
            // Mendapatkan username dan password dari input pengguna
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Memeriksa apakah username atau password kosong
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tolong isi username dan password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Membuat objek DataUser baru untuk login
            DataUser loginUser = new DataUser { Username = username, Password = PasswordHasher.HashPassword(password) };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonData = JsonConvert.SerializeObject(loginUser);
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync($"{_apiBaseUrl}/login", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Login sukses!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Menyembunyikan form login dan menampilkan menu utama
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login gagal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metode untuk menangani klik tombol register
        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            // Mendapatkan username dan password dari input pengguna
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Memeriksa apakah username atau password kosong
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tolong isi username dan password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Membuat objek DataUser baru untuk registrasi
            DataUser newUser = new DataUser { Username = username, Password = PasswordHasher.HashPassword(password) };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonData = JsonConvert.SerializeObject(newUser);
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(_apiBaseUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Register berhasil!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (response.StatusCode == HttpStatusCode.Conflict)
                    {
                        MessageBox.Show("Username sudah ada. Tolong buat username yang lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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