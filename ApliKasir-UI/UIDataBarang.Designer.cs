namespace ApliKasir_UI
{
    partial class UIDataBarang
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
            buttonLogOut = new Button();
            buttonEdit = new Button();
            buttonHapus = new Button();
            buttonTambah = new Button();
            buttonDataBarang = new Button();
            buttonLaporan = new Button();
            label2 = new Label();
            dataGridBarang = new DataGridView();
            buttonDeleteBarang = new Button();
            buttonTambahBarang = new Button();
            buttonRefresh = new Button();
            buttonEditBarang = new Button();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBarang).BeginInit();
            SuspendLayout();
            // 
            // panelBg
            // 
            panelBg.BackColor = Color.Crimson;
            panelBg.Controls.Add(label1);
            panelBg.Controls.Add(buttonLogOut);
            panelBg.Controls.Add(buttonEdit);
            panelBg.Controls.Add(buttonHapus);
            panelBg.Controls.Add(buttonTambah);
            panelBg.Controls.Add(buttonDataBarang);
            panelBg.Controls.Add(buttonLaporan);
            panelBg.Location = new Point(0, 0);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(174, 451);
            panelBg.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 45);
            label1.TabIndex = 6;
            label1.Text = "ApliKasir";
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.White;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Location = new Point(53, 391);
            buttonLogOut.Margin = new Padding(2);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(60, 26);
            buttonLogOut.TabIndex = 5;
            buttonLogOut.Text = "Logout";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogout_Click;
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
            buttonHapus.Click += buttonHapus_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(405, 21);
            label2.Name = "label2";
            label2.Size = new Size(138, 30);
            label2.TabIndex = 1;
            label2.Text = "Tabel Barang";
            // 
            // dataGridBarang
            // 
            dataGridBarang.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBarang.Location = new Point(206, 71);
            dataGridBarang.Margin = new Padding(3, 2, 3, 2);
            dataGridBarang.Name = "dataGridBarang";
            dataGridBarang.RowHeadersWidth = 51;
            dataGridBarang.Size = new Size(451, 346);
            dataGridBarang.TabIndex = 3;
            // 
            // buttonDeleteBarang
            // 
            buttonDeleteBarang.Location = new Point(673, 158);
            buttonDeleteBarang.Margin = new Padding(2);
            buttonDeleteBarang.Name = "buttonDeleteBarang";
            buttonDeleteBarang.Size = new Size(83, 27);
            buttonDeleteBarang.TabIndex = 4;
            buttonDeleteBarang.Text = "Delete";
            buttonDeleteBarang.UseVisualStyleBackColor = true;
            buttonDeleteBarang.Click += ButtonDeleteBarang_Click;
            // 
            // buttonTambahBarang
            // 
            buttonTambahBarang.BackColor = SystemColors.ActiveCaption;
            buttonTambahBarang.Location = new Point(673, 97);
            buttonTambahBarang.Margin = new Padding(3, 2, 3, 2);
            buttonTambahBarang.Name = "buttonTambahBarang";
            buttonTambahBarang.Size = new Size(83, 22);
            buttonTambahBarang.TabIndex = 5;
            buttonTambahBarang.Text = "Tambah";
            buttonTambahBarang.UseVisualStyleBackColor = true;
            buttonTambahBarang.Click += buttonTambahBarang_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = SystemColors.ActiveCaption;
            buttonRefresh.Location = new Point(673, 189);
            buttonRefresh.Margin = new Padding(3, 2, 3, 2);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(83, 34);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonEditBarang
            // 
            buttonEditBarang.Location = new Point(673, 123);
            buttonEditBarang.Margin = new Padding(2);
            buttonEditBarang.Name = "buttonEditBarang";
            buttonEditBarang.Size = new Size(83, 31);
            buttonEditBarang.TabIndex = 7;
            buttonEditBarang.Text = "Edit";
            buttonEditBarang.UseVisualStyleBackColor = true;
            buttonEditBarang.Click += ButtonEditBarang_Click;
            // 
            // UIDataBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 451);
            Controls.Add(buttonEditBarang);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonTambahBarang);
            Controls.Add(buttonDeleteBarang);
            Controls.Add(dataGridBarang);
            Controls.Add(label2);
            Controls.Add(panelBg);
            Name = "UIDataBarang";
            Text = "ApliKasir";
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBarang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBg;
        private Button buttonLaporan;
        private Button buttonDataBarang;
        private Button buttonTambah;
        private Button buttonHapus;
        private Button buttonLogOut;
        private Button buttonEdit;
        private Label label1;
        private Label label2;
        private DataGridView dataGridBarang;
        private Button buttonDeleteBarang;
        private Button buttonTambahBarang;
        private Button buttonRefresh;
        private Button buttonEditBarang;
    }
}