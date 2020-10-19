using DLWMS.DataAccess.P2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DLWMS.ConsoleApp.P2
{
    public class MainP2
    {
        public static void Run()
        {
            VrijednostiReference();
            PodrazumijevaneVrijednosti();
            NullProvjere();
            SlanjeParametara();
            Dekonstrukcija();
            Params();
            Indekseri();
        }
        private static void Indekseri()
        {
            var obj = new Student() { Indeks = 200200, ImePrezime = "Set by Method" };
            Console.WriteLine(obj[0]);
            obj[0] = 7;
        }
        private static void Params()
        {
            Console.WriteLine($"Suma -> {Sumiraj_ver1(3, 6, 7, 9)}");
            Console.WriteLine($"Suma -> {Sumiraj_ver1(3, 6, 7, 8, 9, 9)}");
            Console.WriteLine($"Suma -> {Sumiraj_ver1(new int[] { 3, 6, 7, 8, 9, 9 })}");
        }
        private static int Sumiraj_ver1(params int[] niz)
        {
            int suma = 0;
            for (int i = 0; i < niz.Length; i++)
                suma += niz[i];
            return suma;
        }
        private static int Sumiraj_ver2(params int[] niz)
        {
            return niz.Sum();
        }
        private static int Sumiraj_ver3(params int[] niz) => niz.Sum();
        private static void Dekonstrukcija()
        {
            //  int indeks; string imePrezime;
            var obj = new Student() { Indeks = 200200, ImePrezime = "Set by Method" };
            //obj.Deconstruct(out indeks, out imePrezime);

            //(int indeks, string imePrezime) = obj;

            var (indeks, imePrezime) = obj;
        }
        public (int, string) GetVrijednosti()
        {
            return (202020, "Denis Music");
        }
        private static void SlanjeParametara()
        {
            Student student;
            PostaviVrijednosti(out student);
            Console.WriteLine(student.ImePrezime);

            int broj;//321654
            if (int.TryParse("32d1654", out broj))
                Console.WriteLine($"Konverzija uspjesna -> {broj}");
        }
        private static void PostaviVrijednosti2(in Student obj)
        {
            //obj = new Student() { Indeks = 200200, ImePrezime = "Set by Method" };
        }
        private static void PostaviVrijednosti(out Student obj)
        {
            obj = new Student() { Indeks = 200200, ImePrezime = "Set by Method" };
        }

        private static void NullProvjere()
        {
            string email = GetEmailByIndeks("IB160016");
            Console.WriteLine(email?.ToLower());
            string emailMalaSlova = email?.ToLower() ?? "NOT VALID";
        }

        private static string GetEmailByIndeks(string indeks)
        {
            return null;
        }

        private static void PodrazumijevaneVrijednosti()
        {
            try
            {
                int a = 0;
                int b = new int();
                Student student = null;

                int? BrojKartice1 = null;
                Nullable<int> BrojKartice2 = null;

                student.BrojKartice = null; //<<<<null reference exception
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void VrijednostiReference()
        {
            Student[] prvaGodinaRedovni = new Student[3];
            for (int i = 0; i < prvaGodinaRedovni.Length; i++)
            {
                prvaGodinaRedovni[i] = new Student();
                prvaGodinaRedovni[i].Indeks = 200000 + i;
            }
            DLStudent[] prvaGodinaDL = new DLStudent[3];
            for (int i = 0; i < prvaGodinaRedovni.Length; i++)
            {
                prvaGodinaDL[i].Indeks = 200000 + i;
            }
        }
    }
}
