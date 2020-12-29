using DLWMS.WinForms.P4;
using DLWMS.WinForms.P5;
using DLWMS.WinForms.P7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = $"Trenutno -> {DateTime.Now.ToString()}";
        }

        private void izađiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                Poruke.IzlazIzPrograma,
                Poruke.Pitanje,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
                Application.Exit();
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudenti frmStudenti = new frmStudenti();
            frmStudenti.MdiParent = this;
            frmStudenti.Show();
        }

        private void xOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXO frmXO = new frmXO();
            frmXO.MdiParent = this;
            frmXO.Show();
        }
    }
}
