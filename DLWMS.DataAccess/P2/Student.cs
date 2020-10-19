using System;
using System.Collections.Generic;
using System.Text;

namespace DLWMS.DataAccess.P2
{
    public class Student : Osoba
    {
        public int? BrojKartice;//-1 0 897546561
        public int Indeks { get; set; }
        public string ImePrezime { get; set; }

        int[] ocjene = new int[] { 6, 8, 9, 10, 9, 6, 6 };

        public int this[int lokacija]
        {
            get
            {
                if (lokacija < 0 || lokacija > ocjene.Length)
                    throw new Exception(Poruke.NepostojecaLokacija);
                return ocjene[lokacija];
            }
            set
            {
                ocjene[lokacija] = value;
            }
        }

        public void Deconstruct(out int indeks, out string imePrezime)
        {
            indeks = Indeks;
            imePrezime = ImePrezime;
        }
        public override string ToString() => $"{Indeks} {ImePrezime}";

    }
}
