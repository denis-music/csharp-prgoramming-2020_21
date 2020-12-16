using DLWMS.WinForms.P11;
using DLWMS.WinForms.P7;
using DLWMS.WinForms.P9;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.P10
{
    public class KonekcijaNaBazu : DbContext
    {
        public KonekcijaNaBazu() : base("PutanjaDoBaze")
        {
        }

        public virtual DbSet<Prisustva> Prisustva { get; set; }     
        public virtual DbSet<Student> Studenti { get; set; }
        public virtual DbSet<Spol> Spolovi { get; set; }
        public virtual DbSet<Predmet> Predmet { get; set; }
        public virtual DbSet<StudentiPredmeti> StudentiPredmeti { get; set; }
        //public virtual DbSet<StudentiUloge> StudentiUloge { get; set; }
        public virtual DbSet<Uloga> Uloge { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
                .HasMany(x => x.Uloge)
                .WithMany(u => u.Studenti)
                .Map(su => 
                {
                    su.MapLeftKey("Student_Id");
                    su.MapRightKey("Uloga_Id");
                    su.ToTable("StudentiUloge");
                });
        }

    }
}
