using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.WinForms.P10
{
    [Table("Prisustva")]
    public class Prisustva
    {
        public int Id { get; set; }
        public string BrojIndeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
    }
}
