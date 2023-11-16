using FirstFluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstFluentAPI.Configuration
{
    public class CarsTypeConfiguration : IEntityTypeConfiguration<Cars>
    {
        public void Configure(EntityTypeBuilder<Cars> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CarName)
                .HasDefaultValue("GM'dan boshqasi hullas")
                .HasMaxLength(50)
                .IsRequired();

            builder.HasOne(x => x.Person)
                .WithMany(x => x.Cars);
        }
    }
}
