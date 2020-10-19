using System;
using System.Collections.Generic;
using System.Text;

namespace DLWMS.DataAccess.P2
{
    public class Poruke
    {
        public const string NepostojecaLokacija = "Zahtijevana lokacija ne postoji";
        public readonly string NevalidnaOcjena;
        public Poruke()
        {
            NevalidnaOcjena = "Ocjena nije validna";
        }
    }
}
