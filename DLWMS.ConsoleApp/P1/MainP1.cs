using DLWMS.DataAccess.P1;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLWMS.ConsoleApp.P1
{
    public class MainP1
    {
        public static void Run()
        {
            TipoviPodataka();
            Pokazivaci();
            Klase();
            VrijednostiReference();
            Object();
        }
        private static void Object()
        {
            int a = 10;
            Student student1 = new Student(150051, "Denis", "Music");

            object oA = a;
            object oStudent = student1;

            Console.WriteLine(student1);
        }

        private static void VrijednostiReference()
        {
            int a = 10;
            int b = a;
            int c = new int();

            Student student1 = new Student(150051, "Denis", "Music");
            Student student2 = student1;
            student2.Indeks = 666666;
        }

        private static void Klase()
        {
            Student student1 = new Student(150051, "Denis", "Music");
            Student student2 = new Student(ime: "Jasmin", prezime: "Azemovic", indeks: 160061);
            PrikaziStudentInfo(student1);
            PrikaziStudentInfo(student2);

            student1.Indeks = 170071;
            Console.WriteLine(student1.Indeks);
            Console.WriteLine(student1.Prezime);
        }

        private static void PrikaziStudentInfo(Student student1)
        {
            Console.WriteLine($"{student1.Indeks} {student1.Ime} {student1.Prezime}");
        }

        private static void Pokazivaci()
        {
            int indeks = 150051;
            Console.WriteLine("Indeks -> " + indeks);
            unsafe
            {
                int* pok = &indeks;
                *pok = 160061;
            }
            Console.WriteLine($"Indeks -> {indeks}");
        }

        private static void TipoviPodataka()
        {
            int indeks = 150051;
            double prosjek = 8.2;
            bool aktivan = false;
            string ime = "Denis";

            int[] ocjene = new int[] { 6, 6, 7, 10, 6, 8 };

            if (indeks > 150000 && aktivan == true)
                Console.WriteLine("....");

            for (int i = 0; i < ocjene.Length; i++)
                Console.WriteLine(ocjene[i]);
        }
    }
}
