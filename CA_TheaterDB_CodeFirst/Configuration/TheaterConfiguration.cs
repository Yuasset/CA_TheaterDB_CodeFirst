using CA_TheaterDB_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CA_TheaterDB_CodeFirst.Configuration
{
    internal class TheaterConfiguration : IEntityTypeConfiguration<Theater>
    {
        public void Configure(EntityTypeBuilder<Theater> builder)
        {
            //builder.Property(theater => theater.ID).UseIdentityColumn();

            //Seed Data
            builder.HasData(new Theater
            {
                ID = 1,
                MovieID = 1,
                SaloonID = 1,
                SessionID = 1,
                WeekID = 1
            });
        }
    }
}
