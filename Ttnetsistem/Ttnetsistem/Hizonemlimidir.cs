using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ttnetsistem
{
    public partial class Hizonemlimidir : Form
    {
        public Hizonemlimidir()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void telefonpaketi_Click(object sender, EventArgs e)
        {
            Netpaketuygunmudur Netpaketuygunmudurr = new Netpaketuygunmudur();
            Netpaketuygunmudurr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kaplumbagapaketi Kaplumbagapaketii = new Kaplumbagapaketi();
            Kaplumbagapaketii.Show();
            this.Hide();
        }
    }
}
