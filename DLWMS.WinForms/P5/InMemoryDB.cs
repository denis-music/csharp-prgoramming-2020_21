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

        static InMemoryDB()
        {
            Korisnici = new List<Korisnik>();
            UcitajBuildInKorisnike();
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
