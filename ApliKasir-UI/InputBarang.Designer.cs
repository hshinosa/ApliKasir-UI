namespace ApliKasir_UI
{
    partial class InputBarang
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxNama = new TextBox();
            textBoxHarga = new TextBox();
            textBoxJumlah = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(118, 174);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonInput_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 7);
            label1.Name = "label1";
            label1.Size = new Size(141, 30);
            label1.TabIndex = 1;
            label1.Text = "Input Barang";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 60);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 97);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Harga :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 134);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Jumlah :";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(101, 60);
            textBoxNama.Margin = new Padding(3, 2, 3, 2);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(148, 23);
            textBoxNama.TabIndex = 5;
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(101, 97);
            textBoxHarga.Margin = new Padding(3, 2, 3, 2);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(148, 23);
            textBoxHarga.TabIndex = 6;
            // 
            // textBoxJumlah
            // 
            textBoxJumlah.Location = new Point(101, 132);
            textBoxJumlah.Margin = new Padding(3, 2, 3, 2);
            textBoxJumlah.Name = "textBoxJumlah";
            textBoxJumlah.Size = new Size(148, 23);
            textBoxJumlah.TabIndex = 7;
            // 
            // InputBarang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 233);
            Controls.Add(textBoxJumlah);
            Controls.Add(textBoxHarga);
            Controls.Add(textBoxNama);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InputBarang";
            Text = "InputBarang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxNama;
        private TextBox textBoxHarga;
        private TextBox textBoxJumlah;
    }
}