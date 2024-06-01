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
            buttonDataBarang = new Button();
            buttonLaporan = new Button();
            labelLaporan = new Label();
            labelStokBarang = new Label();
            labelPemasukan = new Label();
            labelPengeluaran = new Label();
            labelHutang = new Label();
            buttonTambah = new Button();
            buttonHapus = new Button();
            buttonEdit = new Button();
            button4 = new Button();
            label1 = new Label();
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
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(173, 451);
            panelBg.TabIndex = 0;
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
            // 
            // labelLaporan
            // 
            labelLaporan.AutoSize = true;
            labelLaporan.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLaporan.Location = new Point(433, 9);
            labelLaporan.Name = "labelLaporan";
            labelLaporan.Size = new Size(91, 30);
            labelLaporan.TabIndex = 1;
            labelLaporan.Text = "Laporan";
            labelLaporan.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelStokBarang
            // 
            labelStokBarang.AutoSize = true;
            labelStokBarang.Location = new Point(233, 96);
            labelStokBarang.Name = "labelStokBarang";
            labelStokBarang.Size = new Size(70, 15);
            labelStokBarang.TabIndex = 2;
            labelStokBarang.Text = "Stok Barang";
            // 
            // labelPemasukan
            // 
            labelPemasukan.AutoSize = true;
            labelPemasukan.Location = new Point(558, 96);
            labelPemasukan.Name = "labelPemasukan";
            labelPemasukan.Size = new Size(68, 15);
            labelPemasukan.TabIndex = 3;
            labelPemasukan.Text = "Pemasukan";
            // 
            // labelPengeluaran
            // 
            labelPengeluaran.AutoSize = true;
            labelPengeluaran.Location = new Point(233, 260);
            labelPengeluaran.Name = "labelPengeluaran";
            labelPengeluaran.Size = new Size(73, 15);
            labelPengeluaran.TabIndex = 4;
            labelPengeluaran.Text = "Pengeluaran";
            // 
            // labelHutang
            // 
            labelHutang.AutoSize = true;
            labelHutang.Location = new Point(558, 260);
            labelHutang.Name = "labelHutang";
            labelHutang.Size = new Size(47, 15);
            labelHutang.TabIndex = 5;
            labelHutang.Text = "Hutang";
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
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(48, 412);
            button4.Name = "button4";
            button4.Size = new Size(75, 26);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
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
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelHutang);
            Controls.Add(labelPengeluaran);
            Controls.Add(labelPemasukan);
            Controls.Add(labelStokBarang);
            Controls.Add(labelLaporan);
            Controls.Add(panelBg);
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