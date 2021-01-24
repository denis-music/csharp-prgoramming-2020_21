using DLWMS.WinForms.P10;
using DLWMS.WinForms.P11;
using DLWMS.WinForms.P12;
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
    public partial class frmPorukeIB150051 : Form
    {

        KonekcijaNaBazu _db = DLWMSdb.Baza;

        Student _student;

        public frmPorukeIB150051(Student student)
        {
            InitializeComponent();
            _student = student;
            dgvPoruke.AutoGenerateColumns = false;
        }

        private void frmPorukeIB150051_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPoruke();
                UcitajPodatkeOStudentu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void UcitajPodatkeOStudentu()
        {
            lblStudent.Text = _student.ToString();
        }

        private void UcitajPoruke()
        {
            try
            {
                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = _db.StudentiPoruke.Where(x => x.Student.Id == _student.Id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }

        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            frmNovaPorukaIB150051 frmNovaPorukaIB150051 = new frmNovaPorukaIB150051(_student);
            if (frmNovaPorukaIB150051.ShowDialog() == DialogResult.OK)
                UcitajPoruke();
            
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var poruka = dgvPoruke.SelectedRows[0].DataBoundItem as StudentiPoruke;
                if (e.ColumnIndex == 3)
                {
                    if (MessageBox.Show("Da li ste sigurni da želite obrisati poruku?",
                        "Upozorenje",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _db.StudentiPoruke.Remove(poruka);
                        _db.SaveChanges();
                    }
                }
                else
                {
                    frmNovaPorukaIB150051 frmNovaPorukaIB150051 = new frmNovaPorukaIB150051(_student, poruka);
                    frmNovaPorukaIB150051.ShowDialog();
                }

                UcitajPoruke();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void btnPrinaj_Click(object sender, EventArgs e)
        {
            var poruke = dgvPoruke.DataSource as List<StudentiPoruke>;
            if(poruke?.Count > 0)
            {
                frmIzvjestaji frmIzvjestaji = new frmIzvjestaji(poruke);
                frmIzvjestaji.ShowDialog();
            }
        }
    }
}
