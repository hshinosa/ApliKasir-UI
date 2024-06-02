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
            button4 = new Button();
            buttonEdit = new Button();
            buttonHapus = new Button();
            buttonTambah = new Button();
            buttonDataBarang = new Button();
            buttonLaporan = new Button();
            label2 = new Label();
            dataGridBarang = new DataGridView();
            buttonSave = new Button();
            buttonTambahBarang = new Button();
            buttonRefresh = new Button();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBarang).BeginInit();
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
            panelBg.Margin = new Padding(3, 4, 3, 4);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(198, 601);
            panelBg.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 12);
            label1.Name = "label1";
            label1.Size = new Size(191, 54);
            label1.TabIndex = 6;
            label1.Text = "ApliKasir";
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(55, 549);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 35);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.White;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(3, 351);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(191, 37);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit Transaksi/Hutang";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.White;
            buttonHapus.FlatStyle = FlatStyle.Flat;
            buttonHapus.Location = new Point(3, 305);
            buttonHapus.Margin = new Padding(3, 4, 3, 4);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(191, 37);
            buttonHapus.TabIndex = 3;
            buttonHapus.Text = "Hapus Transaksi/Hutang";
            buttonHapus.UseVisualStyleBackColor = false;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.White;
            buttonTambah.FlatStyle = FlatStyle.Flat;
            buttonTambah.Location = new Point(3, 261);
            buttonTambah.Margin = new Padding(3, 4, 3, 4);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(191, 36);
            buttonTambah.TabIndex = 2;
            buttonTambah.Text = "Tambah Transaksi/Hutang";
            buttonTambah.UseVisualStyleBackColor = false;
            // 
            // buttonDataBarang
            // 
            buttonDataBarang.BackColor = Color.White;
            buttonDataBarang.FlatStyle = FlatStyle.Flat;
            buttonDataBarang.ForeColor = SystemColors.ControlText;
            buttonDataBarang.Location = new Point(3, 219);
            buttonDataBarang.Margin = new Padding(3, 4, 3, 4);
            buttonDataBarang.Name = "buttonDataBarang";
            buttonDataBarang.Size = new Size(191, 35);
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
            buttonLaporan.Location = new Point(3, 180);
            buttonLaporan.Margin = new Padding(3, 4, 3, 4);
            buttonLaporan.Name = "buttonLaporan";
            buttonLaporan.Size = new Size(191, 31);
            buttonLaporan.TabIndex = 0;
            buttonLaporan.Text = "Laporan";
            buttonLaporan.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(462, 28);
            label2.Name = "label2";
            label2.Size = new Size(175, 38);
            label2.TabIndex = 1;
            label2.Text = "Tabel Barang";
            // 
            // dataGridBarang
            // 
            dataGridBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBarang.Location = new Point(236, 95);
            dataGridBarang.Name = "dataGridBarang";
            dataGridBarang.RowHeadersWidth = 51;
            dataGridBarang.Size = new Size(509, 461);
            dataGridBarang.TabIndex = 3;
            dataGridBarang.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(783, 145);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonTambahBarang
            // 
            buttonTambahBarang.Location = new Point(783, 95);
            buttonTambahBarang.Name = "buttonTambahBarang";
            buttonTambahBarang.Size = new Size(94, 29);
            buttonTambahBarang.TabIndex = 5;
            buttonTambahBarang.Text = "Tambah";
            buttonTambahBarang.UseVisualStyleBackColor = true;
            buttonTambahBarang.Click += button1_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(783, 199);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(94, 29);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // UIDataBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonTambahBarang);
            Controls.Add(buttonSave);
            Controls.Add(dataGridBarang);
            Controls.Add(label2);
            Controls.Add(panelBg);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button4;
        private Button buttonEdit;
        private Label label1;
        private Label label2;
        private DataGridView dataGridBarang;
        private Button buttonSave;
        private Button buttonTambahBarang;
        private Button buttonRefresh;
    }
}