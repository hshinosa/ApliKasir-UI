using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApliKasir_UI
{
    public partial class UIEdit : Form
    {
        private string connectionString = ""; // Ganti SERVER_NAME dengan nama server Anda

        //Constructor
        public UIEdit()
        {
            InitializeComponent();
        }

        // Inisialisasi komponen
        private void InitializeComponent()
        {
            this.lblProductName = new Label();
            this.txtProductName = new TextBox();
            this.lblPrice = new Label();
            this.txtPrice = new TextBox();
            this.lblQuantity = new Label();
            this.txtQuantity = new TextBox();
            this.btnSave = new Button();
            this.btnLoad = new Button();
            this.dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(12, 15);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(87, 15);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Nama Produk";

            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(105, 12);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(167, 23);
            this.txtProductName.TabIndex = 1;

            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 44);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 15);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Harga";

            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(105, 41);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(167, 23);
            this.txtPrice.TabIndex = 3;

            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 73);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(51, 15);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Jumlah";

            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(105, 70);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(167, 23);
            this.txtQuantity.TabIndex = 5;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(105, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);

            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(197, 99);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new EventHandler(this.btnLoad_Click);

            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(12, 128);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(260, 150);
            this.dgvProducts.TabIndex = 8;

            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 290);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Name = "EditProductForm";
            this.Text = "Edit Produk";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Event handler untuk tombol Simpan
        private void btnSave_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            decimal price;
            int quantity;

            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Nama produk tidak boleh kosong.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Harga harus berupa angka dan tidak boleh negatif.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Jumlah harus berupa angka dan tidak boleh negatif.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Produk (Nama, Harga, Jumlah) VALUES (@Nama, @Harga, @Jumlah)";
                {
                    command.Parameters.AddWithValue("@Nama", productName);
                    command.Parameters.AddWithValue("@Harga", price);
                    command.Parameters.AddWithValue("@Jumlah", quantity);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Produk berhasil disimpan.");
            ClearFields();
        }

        // Event handler untuk tombol Load Data
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Produk";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dgvProducts.DataSource = dt;
                    }
                }
            }
        }

        private void ClearFields()
        {
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnSave;
        private Button btnLoad;
        private DataGridView dgvProducts;

    }
}
