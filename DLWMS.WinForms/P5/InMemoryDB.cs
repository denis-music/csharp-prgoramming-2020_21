using DLWMS.WinForms.P7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.P5
{
    public class InMemoryDB
    {
        public static List<Korisnik> Korisnici { get; set; }
        public static List<Student> Studenti { get; set; }


        static InMemoryDB()
        {
            Korisnici = new List<Korisnik>();
            Studenti = new List<Student>();
            UcitajBuildInKorisnike();
            UcitajBuildInStudente();
        }

        private static void UcitajBuildInStudente()
        {
            Studenti.Add(new Student()
            {
                Id = 1,
                Ime = "Jasmin",
                Prezime = "Azemovic",
                DatumRodjenja = DateTime.Now,
                Email = "jasmin@fit.ba",
                Indeks = "IB150051",
                GodinaStudija = 1,
                Aktivan = true
            });

        }

        private static void UcitajBuildInKorisnike()
        {
            Korisnici.Add(new Korisnik()
            {
                Id = 1,
                Ime = "Denis",
                Prezime = "Music",
                DatumRodjenja = DateTime.Now,
                KorisnickoIme = "denis",
                Lozinka = "denis",
                Aktivan = true
            }) ;
            Korisnici.Add(new Korisnik()
            {
                Id = 2,
                Ime = "Goran",
                Prezime = "Skondric",
                DatumRodjenja = DateTime.Now,
                KorisnickoIme = "goran",
                Lozinka = "goran",
                Aktivan = true
            });
        }
    }
}
