using DLWMS.WinForms.P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P7
{
    public partial class frmNoviStudent : Form
    {
        private Student _student;
        private bool _promjena;

        public frmNoviStudent()
        {
            InitializeComponent();
            GenerisiBrojIndeksa();
        }

        public frmNoviStudent(Student student) : this()
        {
            this._student = student;
            UcitajPodatkeOStudentu();
            _promjena = true;
        }

        private void UcitajPodatkeOStudentu()
        {
            if (_student != null)
            {
                txtIme.Text = _student.Ime;
                txtPrezime.Text = _student.Prezime;
                dtpDatumRodjenja.Value = _student.DatumRodjenja;
                txtEmail.Text = _student.Email;
                txtIndeks.Text = _student.Indeks;
                cmbGodinaStudija.SelectedIndex = cmbGodinaStudija.Items.IndexOf(_student.GodinaStudija.ToString());
                cbAktivan.Checked = _student.Aktivan;
                pbSlikaStudenta.Image = _student.Slika;
            }
        }

        private void pbSlikaStudenta_Click(object sender, EventArgs e)
        {
            if (ofdOdabirSlike.ShowDialog() == DialogResult.OK)
            {
                pbSlikaStudenta.Image = Image.FromFile(ofdOdabirSlike.FileName);
            }
        }

        private void frmNoviStudent_Load(object sender, EventArgs e)
        {
        }

        private void GenerisiBrojIndeksa()
        {
            txtIndeks.Text = $"IB{((DateTime.Now.Year - 2000) * 10000) + InMemoryDB.Studenti.Count}";
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void GenerisiEmail()
        {
            txtEmail.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}@edu.fit.ba";
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiEmail();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                if (!_promjena)
                {
                    _student = new Student();
                    _student.Id = InMemoryDB.Studenti.Count + 1;
                }
                _student.Ime = txtIme.Text;
                _student.Prezime = txtPrezime.Text;
                _student.DatumRodjenja = dtpDatumRodjenja.Value;
                _student.Email = txtEmail.Text;
                _student.Indeks = txtIndeks.Text;
                _student.GodinaStudija = int.Parse(cmbGodinaStudija.Text);
                _student.Aktivan = cbAktivan.Checked;
                _student.Slika = pbSlikaStudenta.Image;
                
                if (_promjena == true)                
                    MessageBox.Show(Poruke.StudentPodaciUspjesnoModifikovani);
                else
                {
                    InMemoryDB.Studenti.Add(_student);
                    MessageBox.Show(Poruke.StudentUspjesnoDodan);
                }

                Close();
                // OcistiFormu();
            }
        }

        private void OcistiFormu()
        {
            //txtIme.Text = txtPrezime.Text = txtKorisnickoIme.Text = txtLozinka.Text = "";
            //cbAktivan.Checked = false;
        }

        private bool ValidirajUnos()
        {
            return
                Validator.ValidirajKontrolu(pbSlikaStudenta, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtIndeks, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtIme, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtPrezime, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtEmail, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbGodinaStudija, err, Poruke.ObaveznaVrijednost);
        }
    }
}

