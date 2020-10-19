using System;

namespace DLWMS.DataAccess.P1
{
    public class Student
    {
        int _indeks;     
        public int Indeks { 
            get { return _indeks; } 
            set { 
                if(value>0 && value<300000)
                    _indeks = value; 
            } 
        }     
        public string Ime { get; set; }
        public string Prezime { get; private set; }

        public Student(int indeks, string ime, string prezime)
        {
            Indeks = indeks;
            Ime = ime;
            Prezime = prezime;
        }

        public override string ToString()
        {
            return $"({Indeks}) {Ime} {Prezime}";
        }
    }
}
