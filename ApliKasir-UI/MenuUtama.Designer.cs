namespace ApliKasir_UI
{
    partial class MenuUtama
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
            labelLaporan = new Label();
            labelStokBarang = new Label();
            labelPemasukan = new Label();
            labelPengeluaran = new Label();
            labelHutang = new Label();
            panelBg.SuspendLayout();
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
            panelBg.Size = new Size(247, 752);
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
            buttonHapus.Click += buttonHapus_Click;
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
            // labelLaporan
            // 
            labelLaporan.AutoSize = true;
            labelLaporan.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLaporan.Location = new Point(619, 15);
            labelLaporan.Margin = new Padding(4, 0, 4, 0);
            labelLaporan.Name = "labelLaporan";
            labelLaporan.Size = new Size(139, 45);
            labelLaporan.TabIndex = 1;
            labelLaporan.Text = "Laporan";
            labelLaporan.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelStokBarang
            // 
            labelStokBarang.AutoSize = true;
            labelStokBarang.Location = new Point(333, 160);
            labelStokBarang.Margin = new Padding(4, 0, 4, 0);
            labelStokBarang.Name = "labelStokBarang";
            labelStokBarang.Size = new Size(107, 25);
            labelStokBarang.TabIndex = 2;
            labelStokBarang.Text = "Stok Barang";
            // 
            // labelPemasukan
            // 
            labelPemasukan.AutoSize = true;
            labelPemasukan.Location = new Point(797, 160);
            labelPemasukan.Margin = new Padding(4, 0, 4, 0);
            labelPemasukan.Name = "labelPemasukan";
            labelPemasukan.Size = new Size(101, 25);
            labelPemasukan.TabIndex = 3;
            labelPemasukan.Text = "Pemasukan";
            // 
            // labelPengeluaran
            // 
            labelPengeluaran.AutoSize = true;
            labelPengeluaran.Location = new Point(333, 433);
            labelPengeluaran.Margin = new Padding(4, 0, 4, 0);
            labelPengeluaran.Name = "labelPengeluaran";
            labelPengeluaran.Size = new Size(108, 25);
            labelPengeluaran.TabIndex = 4;
            labelPengeluaran.Text = "Pengeluaran";
            // 
            // labelHutang
            // 
            labelHutang.AutoSize = true;
            labelHutang.Location = new Point(797, 433);
            labelHutang.Margin = new Padding(4, 0, 4, 0);
            labelHutang.Name = "labelHutang";
            labelHutang.Size = new Size(71, 25);
            labelHutang.TabIndex = 5;
            labelHutang.Text = "Hutang";
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(labelHutang);
            Controls.Add(labelPengeluaran);
            Controls.Add(labelPemasukan);
            Controls.Add(labelStokBarang);
            Controls.Add(labelLaporan);
            Controls.Add(panelBg);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MenuUtama";
            Text = "ApliKasir";
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBg;
        private Label labelLaporan;
        private Label labelStokBarang;
        private Label labelPemasukan;
        private Label labelPengeluaran;
        private Label labelHutang;
        private Button buttonLaporan;
        private Button buttonDataBarang;
        private Button buttonTambah;
        private Button buttonHapus;
        private Button button4;
        private Button buttonEdit;
        private Label label1;
    }
}