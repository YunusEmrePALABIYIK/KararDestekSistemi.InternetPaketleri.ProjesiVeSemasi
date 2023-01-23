using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ttnetsistem
{
    public partial class Anambabampaket : Form
    {
        public Anambabampaket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kaplumbagapaketi Kaplumbagapaketii = new Kaplumbagapaketi();
            Kaplumbagapaketii.Show();
            this.Hide();
        }
    }
}
