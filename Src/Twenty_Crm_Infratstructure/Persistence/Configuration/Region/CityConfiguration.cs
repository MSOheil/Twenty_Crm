namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Region;

public class CityConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Region.City>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Region.City> builder)
    {
        
        


        builder.Property(b => b.Name).HasMaxLength(150);


        builder.HasOne(b => b.County)
            .WithMany(b => b.Cities)
                .HasForeignKey(z => z.CountyRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
