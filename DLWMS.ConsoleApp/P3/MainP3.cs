using System;
using System.Collections.Generic;
using System.Text;

namespace DLWMS.ConsoleApp.P3
{
    public class MainP3
    {

        static ILogger _logger;
        public static void Run(ILogger logger)
        {
            _logger = logger;
            Interfejs_1();
            Interfejs_2();
            RepositoryDemo();
            DisposeDemo();
        }

        private static void DisposeDemo()
        {
            using (APILogger obj = new APILogger())
            {

            }
        }

        private static void RepositoryDemo()
        {
            StudentRepository studentRepository = new StudentRepository();
            Student student = studentRepository.GetById(150051);

            Student denis = new Student() { DigitalniId = "asdopasdklčas13213" };
            studentRepository.Insert(denis);
            studentRepository.Delete(150051);


            PolaznikRepository polaznikRepository = new PolaznikRepository();
            Polaznik polaznik = new Polaznik();
            polaznikRepository.Insert(polaznik);
        }

        private static void Interfejs_2()
        {
            try
            {
                throw new Exception("Neka greska");
            }
            catch (Exception ex)
            {
                _logger.Log(ex);
            }
        }

        private static void Interfejs_1()
        {
            StudentInfo(new Student());
            StudentInfo(new Polaznik());

        }
        private static void StudentInfo(IStudent student)
        {
            Console.WriteLine(student.GetUspjeh());
        }
    }
    public interface IStudent
    {
        string GetUspjeh();//Član 1.
        void Problematicna() { }
    }
    public interface IFITStudent : IStudent
    {
        string DigitalniId { get; set; }//Član 2.
    }
    public class Student : IFITStudent
    {
        public string DigitalniId { get; set; }
        public string GetPotvrda(string svrha)
        {
            return $"Potvrda se izdaje u svhru {svrha}";
        }
        public string GetUspjeh()
        {
            return "6.7";
        }
        public void Problematicna()
        {
            ///
        }
    }
    public class Polaznik : IStudent
    {
        public string GetUspjeh()
        {
            return "odlican";
        }
    }

    public interface ILogger
    {
        void Log(object obj);
    }
    public class APILogger : ILogger, IDisposable
    {
        public string URI { get; set; } = "api.fit.ba";
        public string Token { get; set; } = "sda56d4a6s5465asd4as89d789as$";

        public void Dispose()
        {

        }

        public void Log(object obj)
        {
            Console.WriteLine($"Podatke\n {DataExtract.GetData(obj)}\n saljemo prema \n{URI}");
        }
    }
    public class DBLogger : ILogger
    {
        public string IPAdresa { get; set; } = "192.168.1.1";
        public string Autentifikacija { get; set; } = "username:sa,password:test1123";

        public void Log(object obj)
        {
            Console.WriteLine($"Podatke\n {DataExtract.GetData(obj)}\n saljemo prema bazi \n{IPAdresa}");
        }
    }
    public class DataExtract
    {
        public static string GetData(object obj)
        {
            if (obj is Exception)
            {
                Exception ex = obj as Exception;
                return $"{ex.Message} {ex.StackTrace} {ex.Source}";
            }
            return "NEMA PODATAKA";

        }

    }

    //CRUD
    public interface IRepository<T>
    {
        T GetById(int ID);
        bool Insert(T obj);
        bool Delete(int ID);
    }

    public class Repository<T> : IRepository<T>
    {
        public bool Delete(int ID)
        {
            return false;
        }

        public T GetById(int ID)
        {
            return default(T);
        }

        public bool Insert(T obj)
        {
            return true;
        }
    }

    public interface IDodatniAtributi
    {
        DateTime DatumKreiranja { get; set; }
        string KreiraoKorisnik { get; set; }
        DateTime DatumModifikace { get; set; }
        string ModifikovaoKorisnik { get; set; }
    }

    public class Predmet : IDodatniAtributi
    {
        public DateTime DatumKreiranja { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string KreiraoKorisnik { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DatumModifikace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ModifikovaoKorisnik { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }


    public class StudentRepository : Repository<Student> {}
    public class PolaznikRepository : Repository<Polaznik> { }

}
