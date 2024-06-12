namespace ApliKasir_UI
{
    partial class EditBarang
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
            buttonEdit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNama = new TextBox();
            textBoxHarga = new TextBox();
            textBoxJumlah = new TextBox();
            SuspendLayout();
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(137, 271);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 0;
            buttonEdit.Text = "Ubah";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 38);
            label1.TabIndex = 1;
            label1.Text = "Edit Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 108);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "Nama :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 162);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Harga :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 216);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 4;
            label4.Text = "Jumlah :";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(126, 101);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(154, 27);
            textBoxNama.TabIndex = 5;
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(126, 159);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(154, 27);
            textBoxHarga.TabIndex = 6;
            // 
            // textBoxJumlah
            // 
            textBoxJumlah.Location = new Point(126, 209);
            textBoxJumlah.Name = "textBoxJumlah";
            textBoxJumlah.Size = new Size(154, 27);
            textBoxJumlah.TabIndex = 7;
            // 
            // EditBarang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 364);
            Controls.Add(textBoxJumlah);
            Controls.Add(textBoxHarga);
            Controls.Add(textBoxNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonEdit);
            Name = "EditBarang";
            Text = "EditBarang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNama;
        private TextBox textBoxHarga;
        private TextBox textBoxJumlah;
    }
}