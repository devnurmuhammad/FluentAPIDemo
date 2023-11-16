using FirstFluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstFluentAPI.Configuration
{
    public class BicyclesTypeConfiguration : IEntityTypeConfiguration<Bicycles>
    {
        public void Configure(EntityTypeBuilder<Bicycles> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.BicycleName)
                .HasDefaultValue("Aist")
                .HasMaxLength(30)
                .IsRequired();

            builder.HasOne(x => x.Person)
                .WithMany(x => x.Bicycles);
        }
    }
}
