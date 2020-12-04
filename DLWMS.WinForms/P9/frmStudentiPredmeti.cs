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

namespace DLWMS.WinForms.P9
{
    public partial class frmStudentiPredmeti : Form
    {
        Student student;
        public frmStudentiPredmeti(Student student)
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            this.student = student;
        }

        private void frmStudentiPredmeti_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPredmete();
                UcitajPolozenePredmete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = student.PolozeniPredmeti;
            //    new BindingSource()
            //{
            //    DataSource = student.PolozeniPredmeti
            //};
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = InMemoryDB.NPP;
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                student.PolozeniPredmeti.Add(new PolozeniPredmet()
                {
                    Id = student.PolozeniPredmeti.Count + 1,
                    DatumPolaganja = dtpDatumPolaganja.Value,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    Predmet = cmbPredmeti.SelectedItem as Predmet
                }) ;
                UcitajPolozenePredmete();
                OnemoguciDodavanje();
                UcitajStatistiku();
            }
        }

        private void UcitajStatistiku()
        {
            var brojZapisa = student.PolozeniPredmeti.Count;
            lblBrojZapisa.Text = $"Broj zapisa {brojZapisa}";
            if (brojZapisa > 0)
                lblProsjek.Text = $"Prosjecna ocjena {student.PolozeniPredmeti.Average(x => x.Ocjena)}";
        }

        private bool ValidanUnos()
        {
            return
               Validator.ValidirajKontrolu(cmbPredmeti, err, Poruke.ObaveznaVrijednost) &&
               Validator.ValidirajKontrolu(cmbOcjene, err, Poruke.ObaveznaVrijednost);
               
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnemoguciDodavanje();
        }

        private void OnemoguciDodavanje()
        {
            var odabraniPredmet = cmbPredmeti.SelectedItem as Predmet;
            var postoji = student.PolozeniPredmeti.Where(polozeni => polozeni.Predmet.Id == odabraniPredmet.Id).Count() > 0;
            btnDodajPolozeni.Enabled = !postoji;
        }
    }
}
