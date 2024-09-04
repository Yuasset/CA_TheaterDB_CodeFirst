using CA_TheaterDB_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_TheaterDB_CodeFirst.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //builder.Property(category => category.ID).UseIdentityColumn();

            //Seed Data
            builder.HasData(new Category
            {
                ID = 1,
                CategoryName = "Action"
            });
        }
    }
}
