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
            button4 = new Button();
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
            panelBg.Controls.Add(button4);
            panelBg.Controls.Add(buttonEdit);
            panelBg.Controls.Add(buttonHapus);
            panelBg.Controls.Add(buttonTambah);
            panelBg.Controls.Add(buttonDataBarang);
            panelBg.Controls.Add(buttonLaporan);
            panelBg.Location = new Point(0, 0);
            panelBg.Margin = new Padding(4, 5, 4, 5);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(247, 784);
            panelBg.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(231, 65);
            label1.TabIndex = 6;
            label1.Text = "ApliKasir";
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(69, 687);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(107, 43);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.White;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(4, 438);
            buttonEdit.Margin = new Padding(4, 5, 4, 5);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(239, 47);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit Transaksi/Hutang";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.White;
            buttonHapus.FlatStyle = FlatStyle.Flat;
            buttonHapus.Location = new Point(4, 382);
            buttonHapus.Margin = new Padding(4, 5, 4, 5);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(239, 47);
            buttonHapus.TabIndex = 3;
            buttonHapus.Text = "Hapus Transaksi/Hutang";
            buttonHapus.UseVisualStyleBackColor = false;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.White;
            buttonTambah.FlatStyle = FlatStyle.Flat;
            buttonTambah.Location = new Point(4, 327);
            buttonTambah.Margin = new Padding(4, 5, 4, 5);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(239, 45);
            buttonTambah.TabIndex = 2;
            buttonTambah.Text = "Tambah Transaksi/Hutang";
            buttonTambah.UseVisualStyleBackColor = false;
            // 
            // buttonDataBarang
            // 
            buttonDataBarang.BackColor = Color.White;
            buttonDataBarang.FlatStyle = FlatStyle.Flat;
            buttonDataBarang.ForeColor = SystemColors.ControlText;
            buttonDataBarang.Location = new Point(4, 273);
            buttonDataBarang.Margin = new Padding(4, 5, 4, 5);
            buttonDataBarang.Name = "buttonDataBarang";
            buttonDataBarang.Size = new Size(239, 43);
            buttonDataBarang.TabIndex = 1;
            buttonDataBarang.Text = "Data Barang";
            buttonDataBarang.UseVisualStyleBackColor = false;
            // 
            // buttonLaporan
            // 
            buttonLaporan.BackColor = Color.White;
            buttonLaporan.FlatStyle = FlatStyle.Flat;
            buttonLaporan.Font = new Font("Segoe UI", 9F);
            buttonLaporan.ForeColor = SystemColors.ControlText;
            buttonLaporan.Location = new Point(4, 225);
            buttonLaporan.Margin = new Padding(4, 5, 4, 5);
            buttonLaporan.Name = "buttonLaporan";
            buttonLaporan.Size = new Size(239, 38);
            buttonLaporan.TabIndex = 0;
            buttonLaporan.Text = "Laporan";
            buttonLaporan.UseVisualStyleBackColor = false;
            // 
            // tabel_transaksi
            // 
            tabel_transaksi.AllowUserToOrderColumns = true;
            tabel_transaksi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabel_transaksi.BackgroundColor = SystemColors.ControlLightLight;
            tabel_transaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabel_transaksi.Location = new Point(299, 46);
            tabel_transaksi.Name = "tabel_transaksi";
            tabel_transaksi.RowHeadersWidth = 62;
            tabel_transaksi.Size = new Size(658, 309);
            tabel_transaksi.TabIndex = 1;
            tabel_transaksi.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabel_hutang
            // 
            tabel_hutang.AllowUserToOrderColumns = true;
            tabel_hutang.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabel_hutang.BackgroundColor = SystemColors.ControlLightLight;
            tabel_hutang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabel_hutang.Location = new Point(299, 402);
            tabel_hutang.Name = "tabel_hutang";
            tabel_hutang.RowHeadersWidth = 62;
            tabel_hutang.Size = new Size(810, 309);
            tabel_hutang.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(299, 364);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 6;
            label2.Text = "Hutang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(299, 15);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 7;
            label3.Text = "Transaksi";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(299, 728);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "Hapus";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // UIHapus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1143, 774);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tabel_hutang);
            Controls.Add(tabel_transaksi);
            Controls.Add(panelBg);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button button4;
        private Button buttonEdit;
        private Label label1;
        private DataGridView tabel_transaksi;
        private DataGridViewTextBoxColumn jenis;
        private DataGridViewTextBoxColumn tanggal;
        private DataGridView tabel_hutang;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}