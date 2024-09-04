
using CA_TheaterDB_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_TheaterDB_CodeFirst.Configuration
{
    internal class MovieCategoryConfiguration : IEntityTypeConfiguration<MovieCategory>
    {
        public void Configure(EntityTypeBuilder<MovieCategory> builder)
        {
            builder.HasKey(moviecategory => new { moviecategory.MovieID, moviecategory.CategoryID });
            builder.HasOne(moviecategory => moviecategory.Movie).WithMany(movie => movie.MovieCategories).HasForeignKey(moviecategory => moviecategory.MovieID);
            builder.HasOne(moviecategory => moviecategory.Category).WithMany(category => category.MovieCategories).HasForeignKey(moviecategory => moviecategory.CategoryID);

            //Seed Data
            builder.HasData(new MovieCategory
            {
                MovieID = 1,
                CategoryID = 1
            });
        }
    }
}
