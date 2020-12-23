using DLWMS.WinForms.P10;
using DLWMS.WinForms.P11;
using DLWMS.WinForms.P12;
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

        KonekcijaNaBazu _baza = DLWMSdb.Baza;

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
                UcitajUloge();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcitajUloge()
        {
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = student.Uloge.ToList();
           // dataGridView1.DataSource = _baza.StudentiUloge.Where(x=>x.Student.Id == student.Id).ToList();

        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = _baza.StudentiPredmeti.Where(x => x.Student.Id == student.Id).ToList(); //student.PolozeniPredmeti;
            //    new BindingSource()
            //{
            //    DataSource = student.PolozeniPredmeti
            //};
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.DataSource = _baza.Predmet.ToList(); //InMemoryDB.NPP;
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.ValueMember = "Id";
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            //TODO: Na svim lokacijama na kojima je potrebno, dodati odgovarajucu obradu izuzetaka
            if (ValidanUnos())
            {

                _baza.StudentiPredmeti.Add(new StudentiPredmeti()
                {                    
                    Datum = dtpDatumPolaganja.Value,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    Predmet = cmbPredmeti.SelectedItem as Predmet,
                    Student = student
                });
                _baza.SaveChanges();
                //student.PolozeniPredmeti.Add(new PolozeniPredmet()
                //{
                //    Id = student.PolozeniPredmeti.Count + 1,
                //    DatumPolaganja = dtpDatumPolaganja.Value,
                //    Ocjena = int.Parse(cmbOcjene.Text),
                //    Predmet = cmbPredmeti.SelectedItem as Predmet
                //});
                UcitajPolozenePredmete();
                OnemoguciDodavanje();
                UcitajStatistiku();
            }
        }

        private void UcitajStatistiku()
        {
            //TODO: Korigovati na nacin da se podaci preuzimaju iz baze
            //TODO: Neke od podataka iskazati u procentima
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                student.Uloge.Add(_baza.Uloge.Find(2));
                _baza.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            var dtoStudentPrint = new dtoStudentPrint()
            {
                Indeks = student.Indeks,
                ImePrezime = $"{student.Ime} {student.Prezime}",
                Polozeni = dgvPolozeniPredmeti.DataSource as List<StudentiPredmeti>
            };

            frmIzvjestaji frmIzvjestaji = new frmIzvjestaji(dtoStudentPrint);
            frmIzvjestaji.ShowDialog();
        }
    }

    public class dtoStudentPrint
    {
        public string Indeks { get; set; }
        public string ImePrezime { get; set; }
        public List<StudentiPredmeti> Polozeni { get; set; }

    }
}
