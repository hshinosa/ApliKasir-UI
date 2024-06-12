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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
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
            labelHutang = new Label();
            dataGridBarang = new DataGridView();
            dataGridTransaksi = new DataGridView();
            dataGridHutang = new DataGridView();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBarang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTransaksi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridHutang).BeginInit();
            SuspendLayout();
            // 
            // panelBg
            // 
            panelBg.BackColor = Color.DarkTurquoise;
            panelBg.Controls.Add(label1);
            panelBg.Controls.Add(button4);
            panelBg.Controls.Add(buttonEdit);
            panelBg.Controls.Add(buttonHapus);
            panelBg.Controls.Add(buttonTambah);
            panelBg.Controls.Add(buttonDataBarang);
            panelBg.Controls.Add(buttonLaporan);
            panelBg.Location = new Point(0, 0);
            panelBg.Margin = new Padding(3, 4, 3, 4);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(232, 661);
            panelBg.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 44);
            label1.Name = "label1";
            label1.Size = new Size(231, 65);
            label1.TabIndex = 6;
            label1.Text = "ApliKasir";
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Narrow", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(63, 532);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 39);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.White;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(21, 383);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(191, 40);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit Transaksi/Hutang";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.White;
            buttonHapus.FlatStyle = FlatStyle.Flat;
            buttonHapus.Location = new Point(21, 335);
            buttonHapus.Margin = new Padding(3, 4, 3, 4);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(191, 40);
            buttonHapus.TabIndex = 3;
            buttonHapus.Text = "Hapus Transaksi/Hutang";
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.White;
            buttonTambah.FlatStyle = FlatStyle.Flat;
            buttonTambah.Location = new Point(21, 287);
            buttonTambah.Margin = new Padding(3, 4, 3, 4);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(191, 40);
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
            buttonDataBarang.Location = new Point(21, 241);
            buttonDataBarang.Margin = new Padding(3, 4, 3, 4);
            buttonDataBarang.Name = "buttonDataBarang";
            buttonDataBarang.Size = new Size(191, 39);
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
            buttonLaporan.Location = new Point(21, 199);
            buttonLaporan.Margin = new Padding(3, 4, 3, 4);
            buttonLaporan.Name = "buttonLaporan";
            buttonLaporan.Size = new Size(191, 34);
            buttonLaporan.TabIndex = 0;
            buttonLaporan.Text = "Laporan";
            buttonLaporan.UseVisualStyleBackColor = false;
            // 
            // labelLaporan
            // 
            labelLaporan.AutoSize = true;
            labelLaporan.BackColor = SystemColors.MenuHighlight;
            labelLaporan.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLaporan.ForeColor = SystemColors.Window;
            labelLaporan.Location = new Point(581, 44);
            labelLaporan.Name = "labelLaporan";
            labelLaporan.Size = new Size(139, 45);
            labelLaporan.TabIndex = 1;
            labelLaporan.Text = "Laporan";
            labelLaporan.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelStokBarang
            // 
            labelStokBarang.AutoSize = true;
            labelStokBarang.BackColor = Color.Black;
            labelStokBarang.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStokBarang.ForeColor = SystemColors.Window;
            labelStokBarang.Location = new Point(301, 129);
            labelStokBarang.Name = "labelStokBarang";
            labelStokBarang.Size = new Size(137, 33);
            labelStokBarang.TabIndex = 2;
            labelStokBarang.Text = "Stok Barang";
            // 
            // labelPemasukan
            // 
            labelPemasukan.AutoSize = true;
            labelPemasukan.BackColor = Color.Black;
            labelPemasukan.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPemasukan.ForeColor = SystemColors.Window;
            labelPemasukan.Location = new Point(598, 129);
            labelPemasukan.Name = "labelPemasukan";
            labelPemasukan.Size = new Size(110, 33);
            labelPemasukan.TabIndex = 3;
            labelPemasukan.Text = "Transaksi";
            // 
            // labelHutang
            // 
            labelHutang.AutoSize = true;
            labelHutang.BackColor = Color.Black;
            labelHutang.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHutang.ForeColor = SystemColors.Window;
            labelHutang.Location = new Point(905, 129);
            labelHutang.Name = "labelHutang";
            labelHutang.Size = new Size(88, 33);
            labelHutang.TabIndex = 5;
            labelHutang.Text = "Hutang";
            // 
            // dataGridBarang
            // 
            dataGridBarang.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBarang.GridColor = SystemColors.GradientActiveCaption;
            dataGridBarang.Location = new Point(237, 179);
            dataGridBarang.Margin = new Padding(2, 3, 2, 3);
            dataGridBarang.Name = "dataGridBarang";
            dataGridBarang.RowHeadersWidth = 62;
            dataGridBarang.Size = new Size(285, 357);
            dataGridBarang.TabIndex = 6;
            // 
            // dataGridTransaksi
            // 
            dataGridTransaksi.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTransaksi.Location = new Point(526, 179);
            dataGridTransaksi.Margin = new Padding(2, 3, 2, 3);
            dataGridTransaksi.Name = "dataGridTransaksi";
            dataGridTransaksi.RowHeadersWidth = 62;
            dataGridTransaksi.Size = new Size(299, 357);
            dataGridTransaksi.TabIndex = 7;
            // 
            // dataGridHutang
            // 
            dataGridHutang.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridHutang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHutang.Location = new Point(829, 179);
            dataGridHutang.Margin = new Padding(2, 3, 2, 3);
            dataGridHutang.Name = "dataGridHutang";
            dataGridHutang.RowHeadersWidth = 62;
            dataGridHutang.Size = new Size(271, 357);
            dataGridHutang.TabIndex = 9;
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1107, 660);
            Controls.Add(dataGridHutang);
            Controls.Add(dataGridTransaksi);
            Controls.Add(dataGridBarang);
            Controls.Add(labelHutang);
            Controls.Add(labelPemasukan);
            Controls.Add(labelStokBarang);
            Controls.Add(labelLaporan);
            Controls.Add(panelBg);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuUtama";
            Text = "ApliKasir";
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBarang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridTransaksi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridHutang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBg;
        private Label labelLaporan;
        private Label labelStokBarang;
        private Label labelPemasukan;
        private Label labelHutang;
        private Button buttonLaporan;
        private Button buttonDataBarang;
        private Button buttonTambah;
        private Button buttonHapus;
        private Button button4;
        private Button buttonEdit;
        private Label label1;
        private DataGridView dataGridBarang;
        private DataGridView dataGridTransaksi;
        private DataGridView dataGridHutang;
    }
}