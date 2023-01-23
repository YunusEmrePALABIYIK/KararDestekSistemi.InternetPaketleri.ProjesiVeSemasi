using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ttnetsistem
{
    public partial class Dakikaonemlimidir : Form
    {
        public Dakikaonemlimidir()
        {
            InitializeComponent();
        }

        private void telefonpaketi_Click(object sender, EventArgs e)
        {
            Telpaketuygunmudurr Telpaketuygunmudurrr = new Telpaketuygunmudurr();
            Telpaketuygunmudurrr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Azveozkonuspaket Azveozkonuspakett = new Azveozkonuspaket();
            Azveozkonuspakett.Show();
            this.Hide();
        }
    }
}
