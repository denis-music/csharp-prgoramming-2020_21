using DLWMS.WinForms.P7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P8
{
    public partial class frmPredavanje8 : Form
    {
        public frmPredavanje8()
        {
            InitializeComponent();
        }

        private void frmPredavanje8_Load(object sender, EventArgs e)
        {
            //ObjectVarDynamic();
            //AnonimniTipoviTuple();
            //DodatneMetode();
            Linq();
        }

        private void Linq()
        {
            var ocjene = new List<int>() { 6, 8, 9, 7, 6, 10 };

            var rezultat =                
                from o in ocjene
                where o > 7
                orderby o descending
                select o;

            txtRezultat.Text += string.Join($"{Environment.NewLine}", rezultat.ToList());

            txtRezultat.Text += $"{Environment.NewLine}-------------{Environment.NewLine}";

            Func<int, bool> func1 = ProvjeraOcjena1;
            Func<int, bool> func2 = ocjena => ocjena > 7;

            var rezultat1 = ocjene.Where(ProvjeraOcjena2);
            var rezultat2 = ocjene.Where(ocjena => ocjena > 7);

            txtRezultat.Text += string.Join($"{Environment.NewLine}", rezultat1.ToList());



        }

        private bool ProvjeraOcjena1(int ocjena) { return ocjena > 7; }
        private bool ProvjeraOcjena2(int ocjena) => ocjena > 7; 


        private void DodatneMetode()
        {
            var ime = "denis";
            ime.Enkripcija();
            Text = DateTime.Now.ToBIHFormat();

        }

        private dtoStudent AnonimniTipoviTuple()
        {
            var obj = new { Indeks = 150051, Ime = "Denis" };
            var tuple = (Indeks:150051, Ime:"Denis", Prosjek:3.6);

            return new dtoStudent() { Indeks = 150051, Ime = "Denis", Godina = 1};
        }

        private void ObjectVarDynamic()
        {
            object broj = 10;
            object ime = "Denis";
            object ocjene = new List<int>() { 6, 8, 9, 7, 6, 10 };

            var broj1 = 10;
            var ime1 = "Denis";
            var ocjene1 = new List<int>() { 6, 8, 9, 7, 6, 10 };
            var keyValuePairs = new Dictionary<ExceptionHandlingClauseOptions, AccessViolationException>();

            dynamic broj2;
            broj2 = 10;
            broj2 = "deset";
            broj2.OvaMetodaNePostoji();           


        }
        private void SlanjeParametara(dynamic parmetar) {
            parmetar.OvaMetodaNePostoji();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var ocjene = new List<int>() { 6, 8, 9, 7, 6, 10 };
            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                try
                {
                    int filter = int.Parse(txtFilter.Text);
                    var rezultat = ocjene.Where(ocjena => ocjena > filter);
                    txtRezultat.Text = string.Join($"{Environment.NewLine}", rezultat.ToList());
                }
                catch (Exception ex)
                {

                    Text = ex.Message;
                }
              
            }
        }
    }

    static class DodatneMetode
    {
        public static string ToBIHFormat(this DateTime obj)
        {
            return obj.ToString("dd.MM.yyyy hh:MM");
        }    

        public static string Enkripcija(this string obj) //obj = denis
        {
            var original = "abcdefghijklmnoprstuvz0123456789/*-+ ";
            var zamjenski= " +-*/9876543210zvutsrponmlkjihgfedcba";
            var kritptovani = "";
            for (int i = 0; i < obj.Length; i++) {
                int indeks = original.IndexOf(obj[i]);
                kritptovani += zamjenski[indeks];
            }
            return kritptovani;
        }
    }


    public class dtoStudent
    {
        public int Indeks { get; set; }
        public string Ime { get; set; }
        public int Godina { get; set; }
    }
}
