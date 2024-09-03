using CA_TheaterDB_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace CA_TheaterDB_CodeFirst.Context
{
    internal class TheaterDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Theater> Theaters { get; set; }

        //Connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=TheaterDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        //Configuring
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Movie
            modelBuilder.Entity<Movie>().HasMany(movie => movie.Theater).WithOne(theater => theater.Movie).HasForeignKey(theater => theater.MovieID);
            modelBuilder.Entity<Movie>().Property(movie => movie.ID).UseIdentityColumn();
            //Category
            modelBuilder.Entity<Category>().Property(category => category.ID).UseIdentityColumn();
            //MovieCategory
            modelBuilder.Entity<MovieCategory>().HasKey(moviecategory => new { moviecategory.MovieID, moviecategory.CategoryID });
            //Saloon
            modelBuilder.Entity<Saloon>().HasMany(saloon => saloon.Theater).WithOne(theater => theater.Saloon).HasForeignKey(theater => theater.SaloonID);
            modelBuilder.Entity<Saloon>().Property(saloon => saloon.ID).UseIdentityColumn();
            //Session
            modelBuilder.Entity<Session>().HasMany(session => session.Theater).WithOne(theater => theater.Session).HasForeignKey(theater => theater.SessionID);
            modelBuilder.Entity<Session>().Property(session => session.ID).UseIdentityColumn();
            //Week
            modelBuilder.Entity<Week>().HasMany(week => week.Theater).WithOne(theater => theater.Week).HasForeignKey(theater => theater.WeekID);
            modelBuilder.Entity<Week>().Property(week => week.ID).UseIdentityColumn();
            //Theater
            modelBuilder.Entity<Theater>().Property(theater => theater.ID).UseIdentityColumn();

            base.OnModelCreating(modelBuilder);
        }

    }
}
