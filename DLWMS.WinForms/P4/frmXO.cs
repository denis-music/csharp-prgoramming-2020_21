using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P4
{
    public partial class frmXO : Form
    {
        string _imePrvogIgraca;
        string _imeDrugogIgraca;

        public frmXO()
        {
            InitializeComponent();
        }
        public string PrviIgrac { get; set; }
        public frmXO(string prviIgrac, string drugiIgrac) : this()
        {
            _imePrvogIgraca = prviIgrac;
            _imeDrugogIgraca = drugiIgrac;
        }

        public int Brojac { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }
        void NapraviPotez(object sender)
        {
            Button button = sender as Button;
            if (button.Text == "")
            {
                if (Brojac % 2 == 0)
                    button.Text = "X";
                else
                    button.Text = "O";
                Brojac++;
                PrikaziNarednogIgraca();
            }
            if (KrajIgre()) { 
                this.Text = "KRAJ IGRE";
                OnemguciNastavakIgre();
            }
        }

        private void OnemguciNastavakIgre()
        {
            foreach (var item in Controls)
            {
                if(item is Button)
                {
                    (item as Button).Enabled = false;
                }
            }
        }

        private bool KrajIgre()
        {
            return ProvjeriRedove() || ProvjeriKolone() || ProvjeriDijagonale();
        }

        private bool ProvjeriDijagonale()
        {
            return ProvjeriDugmice(button1, button5, button9)
                || ProvjeriDugmice(button3, button5, button7);
        }

        private bool ProvjeriKolone()
        {
            return ProvjeriDugmice(button1, button4, button7)
                || ProvjeriDugmice(button2, button5, button8)
                || ProvjeriDugmice(button3, button6, button9);
        }

        private bool ProvjeriRedove()
        {
            return ProvjeriDugmice(button1, button2, button3)
                || ProvjeriDugmice(button4, button5, button6)
                || ProvjeriDugmice(button7, button8, button9);
        }

        private bool ProvjeriDugmice(Button button1, Button button2, Button button3)
        {
            if (!string.IsNullOrEmpty(button1.Text) && button1.Text == button2.Text && button1.Text == button3.Text) {
                button1.BackColor = button2.BackColor = button3.BackColor = Color.Blue;
                return true;
            }
            return false;
        }

        private void PrikaziNarednogIgraca()
        {         

            lblNaredniIgrac.Text = "Naredni >>> " + ( (Brojac % 2 == 0) ? _imePrvogIgraca : _imeDrugogIgraca);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NapraviPotez(sender);
        }

        private void frmXO_Load(object sender, EventArgs e)
        {
            PrikaziNarednogIgraca();
        }
    }
}
