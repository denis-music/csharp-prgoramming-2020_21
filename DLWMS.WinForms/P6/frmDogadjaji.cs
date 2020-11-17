using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P6
{
    public partial class frmDogadjaji : Form
    {

        delegate void Notifikacije(string poruka);
        event Notifikacije PrestanakRada4GMreze;

        event Notifikacije CudnoPonasanjeKorisnika;


        public frmDogadjaji()
        {
            InitializeComponent();

            //PrestanakRada4GMreze += BHTelecom;
            //PrestanakRada4GMreze += HTEronet;
            //PrestanakRada4GMreze += MTel;

            //btn4GNedostupna.Click += KliknutDugmic;
            CudnoPonasanjeKorisnika += NotificirajAdministratora;
        }

        private void NotificirajAdministratora(string poruka)
        {
            MessageBox.Show($"Detektovan unos -> {poruka}");
        }

        private void KliknutDugmic(object sender, EventArgs e)
        {
            MessageBox.Show("Dugmic kliknut!");
        }

        private void BHTelecom(string poruka)
        {
            MessageBox.Show($"BHTelecom -> {poruka}");
        }
        private void HTEronet(string poruka)
        {
            MessageBox.Show($"HTEronet -> {poruka}");
        }
        private void MTel(string poruka)
        {
            MessageBox.Show($"MTel -> {poruka}");
        }
        private void frmDogadjaji_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("frmDogadjaji_Load....");
        }

        private void FormaUcitana(object sender, EventArgs e)
        {
            //MessageBox.Show("Forma ucitana....");
        }

        private void btn4GNedostupna_Click(object sender, EventArgs e)
        {
            PrestanakRada4GMreze?.Invoke("4G mreza ce biti nedostupna do 13h.");
        }

        private void cbBHTelcom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBHTelcom.Checked)
                PrestanakRada4GMreze += BHTelecom;
            else
                PrestanakRada4GMreze -= BHTelecom;
        }

        private void cbHTEronet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHTEronet.Checked)
                PrestanakRada4GMreze += HTEronet;
            else
                PrestanakRada4GMreze -= HTEronet;
        }

        private void cbMTel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMTel.Checked)
                PrestanakRada4GMreze += MTel;
            else
                PrestanakRada4GMreze -= MTel;
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            PrestanakRada4GMreze?.Invoke(txtPoruka.Text);
        }

        private void txtPoruka_TextChanged(object sender, EventArgs e)
        {
            if (txtPoruka.Text.Contains("$$#"))
                CudnoPonasanjeKorisnika("Detektovan unos $$#");
        }

        private void btnPozovi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Rezultat -> {MathUtil.Calc(Kvariraj,5,2,6,8)}");
            MessageBox.Show($"Rezultat -> {MathUtil.Calc(broj => broj*broj, 5, 2, 6, 8)}");
            MessageBox.Show($"Rezultat -> {MathUtil.Calc(Kubiraj, 5, 2, 6, 8)}");
           //MessageBox.Show($"Rezultat CalcFunc -> {MathUtil.CalcFunc(Kubiraj, 5, 2, 6, 8)}");

            Func<int,int> func = Kvariraj;
        }
        public int Kvariraj(int broj){ return broj * broj; }
        public int Kubiraj(int broj) => broj * broj * broj;

        private void btnYield_Click(object sender, EventArgs e)
        {
            Student denis = new Student();
            //var enumerator = "denis".GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    MessageBox.Show(enumerator.Current.ToString());
            //}

            foreach (var ocjena in denis)
            {
                MessageBox.Show($"Ocjena -> {ocjena}");
            }
        }
        public class Student
        {
            public List<int> Ocjene { get; set; } = new List<int>() { 6, 8, 6 };

            public IEnumerator GetEnumerator()
            {
                for (int i = 0; i < Ocjene.Count; i++)
                    yield return Ocjene[i];

                //yield return Ocjene[0];
                //yield return Ocjene[1];
                //yield return Ocjene[2];
            }
        }
    }    
}
