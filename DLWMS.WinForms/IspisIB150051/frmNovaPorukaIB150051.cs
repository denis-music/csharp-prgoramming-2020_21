using DLWMS.WinForms.P10;
using DLWMS.WinForms.P11;
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

namespace DLWMS.WinForms.IspisIB150051
{
    public partial class frmNovaPorukaIB150051 : Form
    {
        Student _student;
        StudentiPoruke _poruka;
        KonekcijaNaBazu _db = DLWMSdb.Baza;


        //public frmNovaPorukaIB150051()
        //{
        //    InitializeComponent();
        //}

        public frmNovaPorukaIB150051(Student student, StudentiPoruke poruka = null)
        {
            InitializeComponent();
            this._student = student;
            this._poruka = poruka;
        }

        private void btnSpasiPoruku_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var edit = _poruka != null;
                if(!edit)               
                    _poruka = new StudentiPoruke();

                _poruka.DatumVrijeme = DateTime.Now;
                _poruka.Poruka = txtSadrzaj.Text;
                _poruka.Student = _student;
                _poruka.Slika = ImageHelper.FromImageToByte(pbSlika.Image);
               
                if(edit)
                    _db.Entry(_poruka).State = System.Data.Entity.EntityState.Modified;
                else
                    _db.StudentiPoruke.Add(_poruka);
                _db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidanUnos()
        {
            return  Validator.ValidirajKontrolu(txtSadrzaj, err, Poruke.ObaveznaVrijednost) 
                && Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void frmNovaPorukaIB150051_Load(object sender, EventArgs e)
        {
            try
            {
                txtPrimalac.Text = _student.ToString();
                UcitajPoruku();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void UcitajPoruku()
        {
            if (_poruka != null)
            {
                txtSadrzaj.Text = _poruka.Poruka;
                pbSlika.Image = ImageHelper.FromByteToImage(_poruka.Slika);
            }
        }
    }
}
