namespace ApliKasir_UI
{
    partial class UIEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIEdit));
            panelBg = new Panel();
            label1 = new Label();
            button4 = new Button();
            buttonEdit = new Button();
            buttonHapus = new Button();
            buttonTambah = new Button();
            buttonDataBarang = new Button();
            buttonLaporan = new Button();
            label2 = new Label();
            transaksiTabel = new DataGridView();
            label3 = new Label();
            hutangTabel = new DataGridView();
            button1 = new Button();
            panelBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transaksiTabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hutangTabel).BeginInit();
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
            panelBg.Margin = new Padding(4, 5, 4, 5);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(173, 511);
            panelBg.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 10);
            label1.Name = "label1";
            label1.Size = new Size(231, 65);
            label1.TabIndex = 6;
            label1.Text = "ApliKasir";
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(48, 467);
            button4.Name = "button4";
            button4.Size = new Size(75, 29);
            button4.TabIndex = 5;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.White;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(3, 298);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(167, 32);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit Transaksi/Hutang";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.White;
            buttonHapus.FlatStyle = FlatStyle.Flat;
            buttonHapus.Location = new Point(3, 260);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(167, 32);
            buttonHapus.TabIndex = 3;
            buttonHapus.Text = "Hapus Transaksi/Hutang";
            buttonHapus.UseVisualStyleBackColor = false;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.White;
            buttonTambah.FlatStyle = FlatStyle.Flat;
            buttonTambah.Location = new Point(3, 222);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(167, 31);
            buttonTambah.TabIndex = 2;
            buttonTambah.Text = "Tambah Transaksi/Hutang";
            buttonTambah.UseVisualStyleBackColor = false;
            // 
            // buttonDataBarang
            // 
            buttonDataBarang.BackColor = Color.White;
            buttonDataBarang.FlatStyle = FlatStyle.Flat;
            buttonDataBarang.ForeColor = SystemColors.ControlText;
            buttonDataBarang.Location = new Point(3, 186);
            buttonDataBarang.Name = "buttonDataBarang";
            buttonDataBarang.Size = new Size(167, 29);
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
            buttonLaporan.Location = new Point(3, 153);
            buttonLaporan.Name = "buttonLaporan";
            buttonLaporan.Size = new Size(167, 26);
            buttonLaporan.TabIndex = 0;
            buttonLaporan.Text = "Laporan";
            buttonLaporan.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(209, 47);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 10;
            label2.Text = "Transaksi";
            label2.Click += label2_Click;
            // 
            // transaksiTabel
            // 
            transaksiTabel.AllowUserToOrderColumns = true;
            transaksiTabel.BackgroundColor = SystemColors.ButtonFace;
            transaksiTabel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transaksiTabel.Location = new Point(209, 81);
            transaksiTabel.Name = "transaksiTabel";
            transaksiTabel.Size = new Size(549, 134);
            transaksiTabel.TabIndex = 9;
            transaksiTabel.CellContentClick += transaksiTabel_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(209, 251);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 10;
            label3.Text = "Hutang";
            // 
            // hutangTabel
            // 
            hutangTabel.BackgroundColor = SystemColors.ButtonFace;
            hutangTabel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hutangTabel.Location = new Point(209, 284);
            hutangTabel.Name = "hutangTabel";
            hutangTabel.Size = new Size(549, 134);
            hutangTabel.TabIndex = 11;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(209, 437);
            button1.Name = "button1";
            button1.Size = new Size(89, 33);
            button1.TabIndex = 12;
            button1.Text = "Edit data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // UIEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(button1);
            Controls.Add(hutangTabel);
            Controls.Add(label3);
            Controls.Add(transaksiTabel);
            Controls.Add(label2);
            Controls.Add(panelBg);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UIEdit";
            Text = "ApliKasir";
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transaksiTabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)hutangTabel).EndInit();
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
        private DataGridView transaksiTabel;
        private Label label3;
        private DataGridView hutangTabel;
        private Button button1;
    }
}