using FirstFluentAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstFluentAPI.Configuration
{
    public class PersonTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasDefaultValue("Nurmuhammad")
                .IsRequired();

            builder.Property(x => x.Age)
                .HasDefaultValue(18)
                .IsRequired();

            builder.HasMany(x => x.Cars)
                .WithOne(x => x.Person);

            builder.HasMany(x => x.Bicycles)
                .WithOne(x => x.Person);
        }
    }
}
