using CA_TheaterDB_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_TheaterDB_CodeFirst.Configuration
{
    internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasMany(movie => movie.Theater).WithOne(theater => theater.Movie).HasForeignKey(theater => theater.MovieID);
            //builder.Property(movie => movie.ID).UseIdentityColumn();

            //Seed Data
            builder.HasData(new Movie
            {
                ID = 1,
                MovieName = "The Matrix",
                Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                Duration = 136
            });
        }
    }
}
