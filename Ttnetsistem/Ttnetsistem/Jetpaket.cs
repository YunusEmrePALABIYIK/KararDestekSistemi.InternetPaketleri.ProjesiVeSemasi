using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ttnetsistem
{
    public partial class Jetpaket : Form
    {
        public Jetpaket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anambabampaket Anambabampakett = new Anambabampaket();
            Anambabampakett.Show();
            this.Hide();
        }
    }
}
