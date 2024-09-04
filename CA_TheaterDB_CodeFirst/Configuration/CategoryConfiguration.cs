using CA_TheaterDB_CodeFirst.Data;
using CA_TheaterDB_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_TheaterDB_CodeFirst.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(category => category.ID).UseIdentityColumn();

            //Seed Data
            builder.HasData(CategoryData.GetCategoryData());
        }
    }
}
