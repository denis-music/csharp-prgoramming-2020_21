﻿using DLWMS.WinForms.P10;
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
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza; //new KonekcijaNaBazu();

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            //frmNoviStudent frmNoviStudent = new frmNoviStudent();
            //frmNoviStudent.ShowDialog();
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? _baza.Studenti.ToList();  //InMemoryDB.Studenti;
        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form form = null;
            if (student != null)
            {
                if (e.ColumnIndex == 6) 
                    form = new frmStudentiPredmeti(student);
                else
                    form = new frmNoviStudent(student);
                //form.ShowDialog();
                PrikaziFormu(form);

                UcitajPodatkeOStudentima();
            }
        }
        private bool PretragaStudenata(Student s)
        {
            return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
                    || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text.ToLower();

            UcitajPodatkeOStudentima(_baza.Studenti
              .Where(s => s.Ime.ToLower().Contains(filter)
                  || s.Prezime.ToLower().Contains(filter)).ToList());
            //___ver___4
            //UcitajPodatkeOStudentima(InMemoryDB.Studenti
            //    .Where(s=> s.Ime.ToLower().Contains(filter)
            //        || s.Prezime.ToLower().Contains(filter)).ToList());
            //___ver___3
            //var rezultatPretrage =
            //    InMemoryDB.Studenti.Where(PretragaStudenata).ToList();
            //UcitajPodatkeOStudentima(rezultatPretrage);

            //___ver___2
            //var rezultatPretrage =
            //    InMemoryDB.Studenti.Where(s => s.Ime.ToLower().Contains(filter)
            //        || s.Prezime.ToLower().Contains(filter)).ToList();           
            //UcitajPodatkeOStudentima(rezultatPretrage);

            //___ver___1
            //var filter = txtPretraga.Text.ToLower();
            //List<Student> rezultatPretrage = new List<Student>();
            //foreach (var student in InMemoryDB.Studenti)
            //{
            //    if (student.Ime.ToLower().Contains(filter) 
            //        || student.Prezime.ToLower().Contains(filter))
            //        rezultatPretrage.Add(student);
            //}
            //UcitajPodatkeOStudentima(rezultatPretrage);



        }
    }
}
