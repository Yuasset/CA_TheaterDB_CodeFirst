using CA_TheaterDB_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_TheaterDB_CodeFirst.Configuration
{
    internal class SaloonConfiguration : IEntityTypeConfiguration<Saloon>
    {
        public void Configure(EntityTypeBuilder<Saloon> builder)
        {
            builder.HasMany(saloon => saloon.Theater).WithOne(theater => theater.Saloon).HasForeignKey(theater => theater.SaloonID);
            //builder.Property(saloon => saloon.ID).UseIdentityColumn();

            //Seed Data
            builder.HasData(new Saloon
            {
                ID = 1,
                SaloonName = "Saloon 1",
                Capacity = 100
            });
        }
    }
}
