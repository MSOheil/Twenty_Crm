namespace Twenty_Crm_Infratstructure.Persistence.Configuration.WorkPlace;

public class WorkPlaceConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.WorkPlace.WorkPlace>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.WorkPlace.WorkPlace> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);


        builder.Property(b => b.Name).HasMaxLength(150);


        builder.HasOne(b => b.Company)
            .WithMany(b => b.WorkPlaces)
                .HasForeignKey(z => z.CompanyRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
