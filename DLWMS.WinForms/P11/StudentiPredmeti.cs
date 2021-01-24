using DLWMS.WinForms.P7;
using DLWMS.WinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.P11
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmeti
    {
        public int Id { get; set; }
        public virtual Predmet Predmet { get; set; }
        public virtual Student Student { get; set; }
        public int Ocjena { get; set; }
        public DateTime Datum { get; set; }
    }
}
