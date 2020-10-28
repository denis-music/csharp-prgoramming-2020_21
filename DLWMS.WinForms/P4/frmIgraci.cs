using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P4
{
    public partial class frmIgraci : Form
    {
        public frmIgraci()
        {
            InitializeComponent();
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            string prviIgrac = txtPrviIgrac.Text;
            string drugiIgrac = txtDrugiIgrac.Text;
            if(!string.IsNullOrEmpty(prviIgrac) && !string.IsNullOrEmpty(drugiIgrac))
            {
                frmXO forma = new frmXO(prviIgrac, drugiIgrac);
                forma.ShowDialog();
            }
        }
    }    
}
