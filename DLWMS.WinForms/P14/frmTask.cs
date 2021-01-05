using DLWMS.WinForms.P10;
using DLWMS.WinForms.P11;
using DLWMS.WinForms.P7;
using DLWMS.WinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.P14
{
    public partial class frmTask : Form
    {
        public string StatusInfo { get; set; }
        KonekcijaNaBazu _db = DLWMSdb.Baza;
        List<Thread> threads = new List<Thread>();
        public frmTask()
        {
            InitializeComponent();
        }

        private async void ProvjeriKonekcijuiLicencu()
        {
            await Task.Run(() => ProvjeriKonkeciju());
            await Task.Run(()=> ProvjeriLicencu());
        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            txtInfo.Text = StatusInfo = "";

            //var task = Task.Run(() => ProvjeriKonkeciju());
            //var cekanje = task.GetAwaiter();
            //cekanje.OnCompleted(() => ProvjeriLicencu());

            ProvjeriKonekcijuiLicencu();

            //PrikaziStatusInfo("PRIJE POZIVA TASK-A");
            //Task.Run(() => ProvjeriKonkeciju());
            //PrikaziStatusInfo("NAKON POZIVA TASK-A");

            threads.Add(new Thread(ProvjeriKonkeciju));
            threads.Add(new Thread(ProvjeriLicencu));
            threads.Add(new Thread(ProvjeriServise));
            threads.Add(new Thread(DodajStudente));

            //threads[0].Start();
            //threads[1].Start();
            threads[2].Start(new PingDetalji() { BrojZahtjeva = 5, DuzinaPauze = 300 });
            threads[3].Start(5);



            //Thread konekcija = new Thread(ProvjeriKonkeciju);
            //Thread licenca = new Thread(ProvjeriLicencu);
            //Thread servisi = new Thread(ProvjeriServise);
            //Thread studenti = new Thread(DodajStudente);

            //konekcija.Start();
            //licenca.Start();
            //servisi.Start(new PingDetalji() { BrojZahtjeva = 10, DuzinaPauze = 300 });
            //studenti.Start(100);

            //konekcija.Join();

            // txtInfo.Text = StatusInfo;
            //ProvjeriKonkeciju();
            //ProvjeriLicencu();
            //ProvjeriServise();
        }

        private void DodajStudente(object obj)
        {
            var brojStudenata = int.Parse(obj.ToString());
            Spol spol = _db.Spolovi.Find(1);
            for (int i = 0; i < brojStudenata; i++)
            {
                Thread.Sleep(100);
                var indeks = $"IB{200000 + i }";
                _db.Studenti.Add(new Student() { 
                    Aktivan = true,
                    DatumRodjenja = DateTime.Now,
                    Email = $"student{10000 + i}@edu.fit.ba",
                    GodinaStudija = 1,
                    Ime = $"Student_{i + 1}",
                    Prezime = $"Student_{i + 1}",
                    Indeks = indeks,
                    Slika = null,
                    Spol = spol                    
                });
                var info = $"Dodat student -> {indeks}";
                Action pok = () => PrikaziStatusInfo($"{info}");
                BeginInvoke(pok);
            }
            _db.SaveChanges();
        }

        private void ProvjeriServise(object obj)
        {
            //Thread.Sleep(1000);
            //PrikaziStatusInfo($"Servisi dostupni");
            Ping ping = new Ping();
            var pingDetalji = obj as PingDetalji;
            for (int i = 0; i < pingDetalji.BrojZahtjeva; i++)
            {
                Thread.Sleep(pingDetalji.DuzinaPauze);
                var pingReply = ping.Send("www.google.ba");
                var info = $"Ping {pingReply.Address} {pingReply.Status} ({pingReply.RoundtripTime}ms)";
                Action pok = () => PrikaziStatusInfo($"{info}");
                BeginInvoke(pok);
            }
        }

        private void PrikaziStatusInfo(string poruka)
        {
            txtInfo.Text += poruka + Environment.NewLine;
            PomjeriNaKrajSadrzaja();
        }

        private void PomjeriNaKrajSadrzaja()
        {
            txtInfo.SelectionStart = txtInfo.TextLength;
            txtInfo.ScrollToCaret();
        }

        private void ProvjeriLicencu()
        {
            Thread.Sleep(3000);
            //PrikaziStatusInfo($"Licenca validna");
            Action pok = () => PrikaziStatusInfo($"Licenca validna");
            BeginInvoke(pok);
        }

        private void ProvjeriKonkeciju()
        {
            Thread.Sleep(2000);
            //PrikaziStatusInfo($"Konekcija dostupna");
            Action pok = () => PrikaziStatusInfo($"Konekcija dostupna");
            BeginInvoke(pok);
        }

        private void frmTask_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var thread in threads)
            {
                if (thread.IsAlive)
                    e.Cancel = true;
            }
        }

        private void frmTask_Load(object sender, EventArgs e)
        {

        }
    }
}
