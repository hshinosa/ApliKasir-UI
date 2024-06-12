﻿using System.ComponentModel;

namespace ApliKasir_UI
{
    internal class InitializeComponentsBase
    {

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
        }


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent2 () 
        {
            panelBg = new Panel();
            label1 = new Label();
            button4 = new Button();
            buttonEdit = new Button();
            buttonHapus = new Button();
            buttonTambah = new Button();
            buttonDataBarang = new Button();
            buttonLaporan = new Button();
            panelBg.SuspendLayout();
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
            // UIDataBarang
            //
        }
        private Panel panelBg;
        private Button buttonLaporan;
        private Button buttonDataBarang;
        private Button buttonTambah;
        private Button buttonHapus;
        private Button button4;
        private Button buttonEdit;
        private Label label1;
        private Container components;
    }
}