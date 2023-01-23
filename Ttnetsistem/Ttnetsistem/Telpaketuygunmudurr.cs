using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ttnetsistem
{
    public partial class Telpaketuygunmudurr : Form
    {
        public Telpaketuygunmudurr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Konuskanpaket Konuskanpakett = new Konuskanpaket();
         Konuskanpakett.Show();
                this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sessizpaket Sessizpakett = new Sessizpaket();
            Sessizpakett.Show();
            this.Hide();
        }
    }
}
