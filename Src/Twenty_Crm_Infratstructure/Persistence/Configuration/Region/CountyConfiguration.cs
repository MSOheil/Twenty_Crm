namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Region;

public class CountyConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Region.County>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Region.County> builder)
    {

        builder.Property(z => z.Name).HasMaxLength(256);


        builder.HasOne(z => z.State)
            .WithMany(z => z.Counties)
                .HasForeignKey(z => z.StateRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
