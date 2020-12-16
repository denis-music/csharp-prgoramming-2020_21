using DLWMS.WinForms.P7;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.P11
{
    [Table("Uloge")]
    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public ICollection<Student> Studenti { get; set; }

        public Uloga()
        {
            Studenti = new HashSet<Student>();
        }
    }
}
