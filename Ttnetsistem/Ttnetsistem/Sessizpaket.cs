using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ttnetsistem
{
    public partial class Sessizpaket : Form
    {
        public Sessizpaket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Azveozkonuspaket Azveozkonuspakett = new Azveozkonuspaket();
            Azveozkonuspakett.Show();
            this.Hide();
        }
    }
}
