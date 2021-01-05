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

namespace DLWMS.WinForms.P13
{
    public partial class frmPredavanje13 : Form
    {
        public frmPredavanje13()
        {
            InitializeComponent();
        }

        private void btnGlavna_Click(object sender, EventArgs e)
        {
            frmGlavna frmGlavna = new frmGlavna();
            frmGlavna.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNoviStudent frmNoviStudent = new frmNoviStudent();
            frmNoviStudent.Show();
        }
    }
}
