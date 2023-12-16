namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Address;

public class AddressConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Address.Address>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Address.Address> builder)
    {

        builder.Property(b => b.Title)
            .HasMaxLength(150);


        builder.Property(b => b.Street)
            .HasMaxLength(150);

        builder.Property(b => b.Alley)
            .HasMaxLength(150);

        builder.Property(b => b.HouseNumber)
            .HasMaxLength(20);

        builder.Property(b => b.PostalCode)
            .HasMaxLength(30);

        builder.Property(b => b.RegionOrVilageName)
            .HasMaxLength(100);

        builder.HasOne(b => b.User)
            .WithMany(b => b.Addresses)
                .HasForeignKey(b => b.UserRef).IsRequired(true);


        builder.HasOne(b => b.City)
             .WithMany(z => z.Addresses)
             .HasForeignKey(z => z.CityRef).IsRequired(true);
    }
}
