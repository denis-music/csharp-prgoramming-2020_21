using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLWMS.WinForms.P7;
namespace DLWMS.WinForms.P10
{
    public partial class frmSQLite : Form
    {

        KonekcijaNaBazu _db = new KonekcijaNaBazu();

        public frmSQLite()
        {
            InitializeComponent();
        }

        private void frmSQLite_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }


        private void UcitajPodatke()
        {
            try
            {
                dgvPrisustva.DataSource = null;
                dgvPrisustva.DataSource = _db.Prisustva.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void btnDodajPrisustvo_Click(object sender, EventArgs e)
        {
            _db.Prisustva.Add(new Prisustva()
            {
                BrojIndeks = $"IB150{(100 + DateTime.Now.Second).ToString()}",
                Ime = $"Ime {DateTime.Now.Second}",
                Prezime = $"Prezime {DateTime.Now.Second}"
            });
            _db.SaveChanges();
            UcitajPodatke();
        }

        private void btnStudenti_Click(object sender, EventArgs e)
        {
            frmStudenti frmStudenti = new frmStudenti();
            frmStudenti.ShowDialog();
        }
    }
}
