using DLWMS.WinForms.P7;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspisIB150051
{
    [Table("StudentiPoruke")]
    public class StudentiPoruke
    {
        public int Id { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public Student Student { get; set; }
        public string Poruka { get; set; }
        public byte[] Slika { get; set; }
    }
}
