using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ttnetsistem
{
    public partial class Netpaketuygunmudur : Form
    {
        public Netpaketuygunmudur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jetpaket Jetpakett= new Jetpaket();
            Jetpakett.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anambabampaket Anambabampakett = new Anambabampaket();
            Anambabampakett.Show();
            this.Hide();
        }
    }
}
