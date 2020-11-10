using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P5
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void frmPrijava_Load(object sender, EventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {               
                foreach (var korisnik in InMemoryDB.Korisnici)
                {
                //for (int i = 0; i < InMemoryDB.Korisnici.Count; i++)
                //{
                //    Korisnik korisnik = InMemoryDB.Korisnici[i];
                    if (korisnik.KorisnickoIme == txtKorisnickoIme.Text &&
                        korisnik.Lozinka == txtLozinka.Text)
                    {
                        if(korisnik.Aktivan)
                            MessageBox.Show($"{Poruke.DobroDosli} {korisnik}");
                        else
                            MessageBox.Show($"{Poruke.KorisnickiNalogNijeAktivan}");
                        return;
                    }
                }
                MessageBox.Show(Poruke.KorisnikNePostoji);
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtKorisnickoIme, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtLozinka, err, Poruke.ObaveznaVrijednost);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistracija frmRegistracija = new frmRegistracija();
            frmRegistracija.Show();
        }
    }
}
