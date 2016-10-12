namespace TeamProject1._1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CounterStrikeContext : DbContext
    {
        public CounterStrikeContext()
            : base("name=CounterStrikeConnection")
        {
        }

        public virtual DbSet<Counter_Strike> Counter_Strikes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Counter_Strike>()
                .Property(e => e.Counter_Strike1)
                .IsFixedLength();

            modelBuilder.Entity<Counter_Strike>()
                .Property(e => e.Week_20_)
                .IsFixedLength();

            modelBuilder.Entity<Counter_Strike>()
                .Property(e => e.Team_1)
                .IsFixedLength();

            modelBuilder.Entity<Counter_Strike>()
                .Property(e => e.Team_2)
                .IsFixedLength();
        }
    }
}
