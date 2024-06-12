using LibraryKasir;

namespace ApliKasir_UI
{
    partial class UIHapus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelBg = new Panel();
            label1 = new Label();
            buttonLogout = new Button();
            buttonEdit = new Button();
            buttonHapus = new Button();
            buttonTambah = new Button();
            buttonDataBarang = new Button();
            buttonLaporan = new Button();
            tabel_transaksi = new DataGridView();
            tabel_hutang = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabel_transaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tabel_hutang).BeginInit();
            SuspendLayout();
            // 
            // panelBg
            // 
            panelBg.BackColor = Color.Crimson;
            panelBg.Controls.Add(label1);
            panelBg.Controls.Add(buttonLogout);
            panelBg.Controls.Add(buttonEdit);
            panelBg.Controls.Add(buttonHapus);
            panelBg.Controls.Add(buttonTambah);
            panelBg.Controls.Add(buttonDataBarang);
            panelBg.Controls.Add(buttonLaporan);
            panelBg.Location = new Point(0, 0);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(173, 470);
            panelBg.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 45);
            label1.TabIndex = 6;
            label1.Text = "ApliKasir";
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.White;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Location = new Point(48, 412);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 26);
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.White;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(3, 263);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(167, 28);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit Transaksi/Hutang";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.White;
            buttonHapus.FlatStyle = FlatStyle.Flat;
            buttonHapus.Location = new Point(3, 229);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(167, 28);
            buttonHapus.TabIndex = 3;
            buttonHapus.Text = "Hapus Transaksi/Hutang";
            buttonHapus.UseVisualStyleBackColor = false;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.White;
            buttonTambah.FlatStyle = FlatStyle.Flat;
            buttonTambah.Location = new Point(3, 196);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(167, 27);
            buttonTambah.TabIndex = 2;
            buttonTambah.Text = "Tambah Transaksi/Hutang";
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // buttonDataBarang
            // 
            buttonDataBarang.BackColor = Color.White;
            buttonDataBarang.FlatStyle = FlatStyle.Flat;
            buttonDataBarang.ForeColor = SystemColors.ControlText;
            buttonDataBarang.Location = new Point(3, 164);
            buttonDataBarang.Name = "buttonDataBarang";
            buttonDataBarang.Size = new Size(167, 26);
            buttonDataBarang.TabIndex = 1;
            buttonDataBarang.Text = "Data Barang";
            buttonDataBarang.UseVisualStyleBackColor = false;
            buttonDataBarang.Click += buttonDataBarang_Click;
            // 
            // buttonLaporan
            // 
            buttonLaporan.BackColor = Color.White;
            buttonLaporan.FlatStyle = FlatStyle.Flat;
            buttonLaporan.Font = new Font("Segoe UI", 9F);
            buttonLaporan.ForeColor = SystemColors.ControlText;
            buttonLaporan.Location = new Point(3, 135);
            buttonLaporan.Name = "buttonLaporan";
            buttonLaporan.Size = new Size(167, 23);
            buttonLaporan.TabIndex = 0;
            buttonLaporan.Text = "Laporan";
            buttonLaporan.UseVisualStyleBackColor = false;
            buttonLaporan.Click += buttonLaporan_Click;
            // 
            // tabel_transaksi
            // 
            tabel_transaksi.AllowUserToOrderColumns = true;
            tabel_transaksi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabel_transaksi.BackgroundColor = SystemColors.ControlLightLight;
            tabel_transaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabel_transaksi.Location = new Point(209, 28);
            tabel_transaksi.Margin = new Padding(2);
            tabel_transaksi.Name = "tabel_transaksi";
            tabel_transaksi.RowHeadersWidth = 62;
            tabel_transaksi.Size = new Size(461, 185);
            tabel_transaksi.TabIndex = 1;
            tabel_transaksi.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabel_hutang
            // 
            tabel_hutang.AllowUserToOrderColumns = true;
            tabel_hutang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabel_hutang.BackgroundColor = SystemColors.ControlLightLight;
            tabel_hutang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabel_hutang.Location = new Point(209, 241);
            tabel_hutang.Margin = new Padding(2);
            tabel_hutang.Name = "tabel_hutang";
            tabel_hutang.RowHeadersWidth = 62;
            tabel_hutang.Size = new Size(567, 185);
            tabel_hutang.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 218);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Hutang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(209, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 7;
            label3.Text = "Transaksi";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(209, 430);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(78, 33);
            button1.TabIndex = 8;
            button1.Text = "Hapus";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // UIHapus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 464);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tabel_hutang);
            Controls.Add(tabel_transaksi);
            Controls.Add(panelBg);
            Name = "UIHapus";
            Text = "ApliKasir";
            Load += UIHapus_Load;
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabel_transaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)tabel_hutang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void UIHapus_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private Panel panelBg;
        private Button buttonLaporan;
        private Button buttonDataBarang;
        private Button buttonTambah;
        private Button buttonHapus;
        private Button buttonLogout;
        private Button buttonEdit;
        private Label label1;
        private DataGridView tabel_transaksi;
        private DataGridView tabel_hutang;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}