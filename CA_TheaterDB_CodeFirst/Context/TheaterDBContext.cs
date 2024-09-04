using CA_TheaterDB_CodeFirst.Configuration;
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
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            //Category
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //MovieCategory
            modelBuilder.ApplyConfiguration(new MovieCategoryConfiguration());
            //Saloon
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //Session
            modelBuilder.ApplyConfiguration(new SessionConfiguration());
            //Week
            modelBuilder.ApplyConfiguration(new WeekConfiguration());
            //Theater
            modelBuilder.ApplyConfiguration(new TheaterConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
