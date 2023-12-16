namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Region;

public class StateConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Region.State>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Region.State> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);


        builder.Property(b => b.Name).HasMaxLength(150);


        builder.HasMany(z => z.Counties)
            .WithOne(z => z.State)
                .HasForeignKey(b => b.StateRef).OnDelete(DeleteBehavior.NoAction);
    }


}
