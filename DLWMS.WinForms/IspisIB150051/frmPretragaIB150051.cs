using DLWMS.WinForms.P10;
using DLWMS.WinForms.P11;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspisIB150051
{
    public partial class frmPretragaIB150051 : Form
    {
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        public frmPretragaIB150051()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        private void txtNazivPredmeta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblProsjek.Text = "";
                var filter = txtNazivPredmeta.Text.ToLower();
                var polozeniPredmeti = _db.StudentiPredmeti.Where(x => x.Predmet.Naziv.ToLower().Contains(filter)).ToList();
                if (polozeniPredmeti != null)
                {
                    dgvPolozeniPredmeti.DataSource = null;
                    dgvPolozeniPredmeti.DataSource = polozeniPredmeti;
                    lblProsjek.Text = polozeniPredmeti.Count == 0 ? "0" : polozeniPredmeti.Average(x => x.Ocjena).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void dgvPolozeniPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 4)
            {
                var studentPredmet = dgvPolozeniPredmeti.SelectedRows[0].DataBoundItem as StudentiPredmeti;
                if(studentPredmet != null)
                {
                    frmPorukeIB150051 frmPorukeIB150051 = new frmPorukeIB150051(studentPredmet.Student);
                    frmPorukeIB150051.ShowDialog();
                }
            }
        }

        private void btnSumiraj_Click(object sender, EventArgs e)
        {
            lblSuma.Text = "";
            Thread thread = new Thread(Sumiraj);
            var n = long.Parse(txtN.Text);
            thread.Start(n);
        }

        private void Sumiraj(object obj)
        {
            var n = long.Parse(obj.ToString());
            long suma = 0;
            for (int i = 0; i < n; i++)
                suma += i;
            Action action = () => lblSuma.Text = suma.ToString();
            BeginInvoke(action);
        }
    }
}
