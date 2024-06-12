namespace ApliKasir_UI
{
    partial class EditTransaksi
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            inputId = new TextBox();
            inputNamaBarang = new TextBox();
            inputJumlahBarang = new TextBox();
            inputTotalHarga = new TextBox();
            updatebtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Edit Transaksi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 63);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Id Transaksi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 97);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 135);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Jumlah Barang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 176);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Total Harga";
            // 
            // inputId
            // 
            inputId.Location = new Point(150, 63);
            inputId.Name = "inputId";
            inputId.Size = new Size(79, 23);
            inputId.TabIndex = 5;
            inputId.TextChanged += inputId_TextChanged;
            // 
            // inputNamaBarang
            // 
            inputNamaBarang.Location = new Point(150, 97);
            inputNamaBarang.Name = "inputNamaBarang";
            inputNamaBarang.Size = new Size(148, 23);
            inputNamaBarang.TabIndex = 6;
            // 
            // inputJumlahBarang
            // 
            inputJumlahBarang.Location = new Point(150, 135);
            inputJumlahBarang.Name = "inputJumlahBarang";
            inputJumlahBarang.Size = new Size(79, 23);
            inputJumlahBarang.TabIndex = 7;
            // 
            // inputTotalHarga
            // 
            inputTotalHarga.Location = new Point(150, 176);
            inputTotalHarga.Name = "inputTotalHarga";
            inputTotalHarga.Size = new Size(105, 23);
            inputTotalHarga.TabIndex = 8;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(162, 226);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(103, 31);
            updatebtn.TabIndex = 9;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 278);
            Controls.Add(updatebtn);
            Controls.Add(inputTotalHarga);
            Controls.Add(inputJumlahBarang);
            Controls.Add(inputNamaBarang);
            Controls.Add(inputId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox inputId;
        private TextBox inputNamaBarang;
        private TextBox inputJumlahBarang;
        private TextBox inputTotalHarga;
        private Button updatebtn;
    }
}