using DLWMS.WinForms.IspisIB150051;
using DLWMS.WinForms.P7;
using DLWMS.WinForms.P9;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P12
{
    public partial class frmIzvjestaji : Form
    {
        private dtoStudentPrint _student;
        List<StudentiPoruke> _poruke;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(dtoStudentPrint student) : this()
        {
            this._student = student;
        }

        public frmIzvjestaji(List<StudentiPoruke> poruke) : this()
        {
            this._poruke = poruke;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            if (_student != null)
                PrinajUvjerenje();
            else if (_poruke != null)
                PrintajPoruke();
        }

        private void PrintajPoruke()
        {
          
            var tblPoruke = new dsDLWMS.PorukeDataTable();
            for (int i = 0; i < _poruke.Count; i++)
            {
                var red = tblPoruke.NewPorukeRow();                
                red.Datum = _poruke[i].DatumVrijeme.ToString();
                red.Sadrzaj = _poruke[i].Poruka;
                red.Primala = _poruke[i].Student.ToString();
                tblPoruke.Rows.Add(red);
            }
            var rds = new ReportDataSource();
            rds.Name = "noviPoruke";
            //rds.Value = tblPolozeni;
            //rds.Value = listaPolozeni;
            rds.Value = tblPoruke;

            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

        private void PrinajUvjerenje()
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Indeks", _student?.Indeks)); //"IB150051"));
            rpc.Add(new ReportParameter("ImePrezime", _student?.ImePrezime)); //"Denis Music"));

            #region ranije_verzije
            //var tblPolozeni = new dsDLWMS.PolozeniDataTable();
            //for (int i = 0; i < 5; i++)
            //{
            //    var red = tblPolozeni.NewPolozeniRow();
            //    red.Id = i + 1;
            //    red.Naziv = $"Predmet {i + 1}";
            //    red.Ocjena = 6;
            //    red.Datum = DateTime.Now.ToString();
            //    tblPolozeni.Rows.Add(red);
            //}
            //var listaPolozeni = new List<object>();
            //for (int i = 0; i < 5; i++)
            //{
            //    listaPolozeni.Add(
            //        new { 
            //        Id = i + 1,
            //        Naziv = $"an_Predmet {i + 1}",
            //        Ocjena = 6,
            //        Datum = DateTime.Now.ToString()
            //    });               
            //}
            #endregion

            var tblPolozeniNovi = new dsDLWMS.PolozeniDataTable();
            for (int i = 0; i < _student.Polozeni.Count; i++)
            {
                var red = tblPolozeniNovi.NewPolozeniRow();
                var polozeni = _student.Polozeni[i];
                red.Id = polozeni.Id;
                red.Naziv = polozeni.Predmet.Naziv;
                red.Ocjena = polozeni.Ocjena;
                red.Datum = polozeni.Datum.ToString();
                tblPolozeniNovi.Rows.Add(red);
            }
            var rds = new ReportDataSource();
            rds.Name = "dsPolozeni";
            //rds.Value = tblPolozeni;
            //rds.Value = listaPolozeni;
            rds.Value = tblPolozeniNovi;



            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(rpc);

            this.reportViewer1.RefreshReport();
        }
    }
}
