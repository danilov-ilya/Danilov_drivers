using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ВодителиВАР3
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model13")
        {
        }

        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drivers>()
                .Property(e => e.ID)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.id)
                .IsFixedLength();
        }
    }
}
