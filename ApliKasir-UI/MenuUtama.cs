using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApliKasir_UI
{
    public partial class MenuUtama : Form
    {

        //Constructor
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            UIEdit editForm = new UIEdit();
            editForm.Show();
            this.Hide();
        }
    }
}
