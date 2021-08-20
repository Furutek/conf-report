using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace conf_report.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Conferences")
        {
        }

        public virtual DbSet<Conference> Conferences { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conference>()
                .Property(e => e.device)
                .IsFixedLength();

            modelBuilder.Entity<Conference>()
                .Property(e => e.participants)
                .IsUnicode(false);
        }
    }
}
