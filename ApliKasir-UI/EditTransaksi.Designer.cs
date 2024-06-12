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
            label3 = new Label();
            label4 = new Label();
            inputNamaBarang = new TextBox();
            inputJumlahBarang = new TextBox();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 57);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Nama Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 95);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Jumlah Barang";
            // 
            // inputNamaBarang
            // 
            inputNamaBarang.Location = new Point(175, 57);
            inputNamaBarang.Name = "inputNamaBarang";
            inputNamaBarang.Size = new Size(148, 23);
            inputNamaBarang.TabIndex = 6;
            // 
            // inputJumlahBarang
            // 
            inputJumlahBarang.Location = new Point(175, 95);
            inputJumlahBarang.Name = "inputJumlahBarang";
            inputJumlahBarang.Size = new Size(148, 23);
            inputJumlahBarang.TabIndex = 7;
            // 
            // updatebtn
            // 
            updatebtn.Location = new Point(150, 158);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(103, 31);
            updatebtn.TabIndex = 9;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = true;
            updatebtn.Click += updatebtn_Click;
            // 
            // EditTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 238);
            Controls.Add(updatebtn);
            Controls.Add(inputJumlahBarang);
            Controls.Add(inputNamaBarang);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "EditTransaksi";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox inputNamaBarang;
        private TextBox inputJumlahBarang;
        private Button updatebtn;
    }
}