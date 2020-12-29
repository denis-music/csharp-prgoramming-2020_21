using DLWMS.WinForms.P10;
using DLWMS.WinForms.P11;
using DLWMS.WinForms.P5;
using DLWMS.WinForms.P9;
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

        KonekcijaNaBazu _db = DLWMSdb.Baza; //new KonekcijaNaBazu();

        private Student _student;
        private bool _promjena;

        public frmNoviStudent()
        {
            InitializeComponent();
            UcitajPodatke();
            
        }
        public frmNoviStudent(Student student) : this()
        {
            this._student = student;
            UcitajPodatkeOStudentu();
            _promjena = true;
        }
        private void UcitajPodatke()
        {
            GenerisiBrojIndeksa();
            UcitajSpolove();
            UcitajUloge();
        }

        private void UcitajUloge()
        {
            var uloge = _db.Uloge.ToList();
            clbUloge.DataSource = uloge;
            clbUloge.DisplayMember = "Naziv";
        }

        private void UcitajSpolove()
        {
            cmbSpol.DataSource = _db.Spolovi.ToList(); //InMemoryDB.Spolovi;
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
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
                if(_student.Spol != null)
                    cmbSpol.SelectedValue = _student.Spol.Id;
                cbAktivan.Checked = _student.Aktivan;
                pbSlikaStudenta.Image = ImageHelper.FromByteToImage(_student.Slika);

                var uloge = clbUloge.Items.Cast<Uloga>().ToList();
                for (int i = 0; i < uloge.Count ; i++)
                {
                    if(_student.Uloge.Where(x=>x.Id == uloge[i].Id).Count() > 0 )
                        clbUloge.SetItemChecked(i, true);
                }


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
            //txtIndeks.Text = $"IB{((DateTime.Now.Year - 2000) * 10000) + InMemoryDB.Studenti.Count}";
            txtIndeks.Text = $"IB{((DateTime.Now.Year - 2000) * 10000) + _db.Studenti.Count()}";

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
                    //_student.Id = InMemoryDB.Studenti.Count + 1;
                }
                _student.Ime = txtIme.Text;
                _student.Prezime = txtPrezime.Text;
                _student.DatumRodjenja = dtpDatumRodjenja.Value;
                _student.Email = txtEmail.Text;
                _student.Indeks = txtIndeks.Text;
                _student.GodinaStudija = int.Parse(cmbGodinaStudija.Text);
                _student.Aktivan = cbAktivan.Checked;
                _student.Slika = ImageHelper.FromImageToByte(pbSlikaStudenta.Image);
                _student.Spol = cmbSpol.SelectedItem as Spol;
                _student.Uloge = clbUloge.CheckedItems.Cast<Uloga>().ToList();

                if (_promjena == true)
                {
                    _db.Entry(_student).State = System.Data.Entity.EntityState.Modified;
                    MessageBox.Show(Poruke.StudentPodaciUspjesnoModifikovani);
                }
                else
                {
                    //InMemoryDB.Studenti.Add(_student);
                    _db.Studenti.Add(_student);
                    MessageBox.Show(Poruke.StudentUspjesnoDodan);
                }
                _db.SaveChanges();
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
                Validator.ValidirajKontrolu(cmbSpol, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtEmail, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbGodinaStudija, err, Poruke.ObaveznaVrijednost);
        }
    }
}

