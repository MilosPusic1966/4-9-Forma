using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_9_Forma
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void prvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nova = new Form1();
            nova.Show();
            
        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Glavna_Load(object sender, EventArgs e)
        {
            prviToolStripMenuItem.Enabled = false;
            treciToolStripMenuItem.Visible = false;
        }

        private void saFKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFK nova = new FormFK();
            nova.Show();
        }
    }
}
