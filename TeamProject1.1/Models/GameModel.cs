namespace TeamProject1._1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GameModel : DbContext
    {
        public GameModel()
            : base("name=GameModelConnection")
        {
        }

        public virtual DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .Property(e => e.GAME)
                .IsFixedLength();

            modelBuilder.Entity<Game>()
                .Property(e => e.WEEK_NUMBER)
                .IsFixedLength();

            modelBuilder.Entity<Game>()
                .Property(e => e.TEAM_1_ID)
                .IsFixedLength();

            modelBuilder.Entity<Game>()
                .Property(e => e.TEAM_2_ID)
                .IsFixedLength();
        }
    }
}
