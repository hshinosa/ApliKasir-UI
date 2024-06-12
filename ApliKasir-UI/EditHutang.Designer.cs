namespace ApliKasir_UI
{
    partial class EditHutang
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            inputNamaPelanggan = new TextBox();
            inputNamaBarang = new TextBox();
            inputJumlahBarang = new TextBox();
            UpdateBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Edit Hutang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 65);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama Pelanggan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 101);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Nama Barang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 137);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "Jumlah Barang";
            // 
            // inputNamaPelanggan
            // 
            inputNamaPelanggan.Location = new Point(171, 62);
            inputNamaPelanggan.Name = "inputNamaPelanggan";
            inputNamaPelanggan.Size = new Size(147, 23);
            inputNamaPelanggan.TabIndex = 7;
            // 
            // inputNamaBarang
            // 
            inputNamaBarang.Location = new Point(171, 101);
            inputNamaBarang.Name = "inputNamaBarang";
            inputNamaBarang.Size = new Size(147, 23);
            inputNamaBarang.TabIndex = 8;
            // 
            // inputJumlahBarang
            // 
            inputJumlahBarang.Location = new Point(171, 137);
            inputJumlahBarang.Name = "inputJumlahBarang";
            inputJumlahBarang.Size = new Size(147, 23);
            inputJumlahBarang.TabIndex = 9;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(154, 179);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(92, 23);
            UpdateBtn.TabIndex = 11;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // EditHutang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 239);
            Controls.Add(UpdateBtn);
            Controls.Add(inputJumlahBarang);
            Controls.Add(inputNamaBarang);
            Controls.Add(inputNamaPelanggan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "EditHutang";
            Text = "EditHutang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox inputNamaPelanggan;
        private TextBox inputNamaBarang;
        private TextBox inputJumlahBarang;
        private Button UpdateBtn;
    }
}