using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ttnetsistem
{
    public partial class Konuskanpaket : Form
    {
        public Konuskanpaket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sessizpaket Sessizpakett = new Sessizpaket();
            Sessizpakett.Show();
            this.Hide();
        }
    }
}
