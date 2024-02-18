namespace Twenty_Crm_Infratstructure.Persistence.Configuration.License;

public class LicenseConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.License.License>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.License.License> builder)
    {
        
        


        builder.Property(b => b.Description).HasMaxLength(400);


        builder.HasOne(b => b.User)
            .WithMany(b => b.Licenses)
                .HasForeignKey(z => z.UserRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
