namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Website;

public class WebsiteConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Website.Website>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Website.Website> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);


        builder.Property(b => b.Name).HasMaxLength(150);


        builder.HasOne(b => b.User)
            .WithMany(b => b.Websites)
                .HasForeignKey(z => z.UserRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(b => b.Company)
            .WithMany(b => b.Websites)
                .HasForeignKey(z => z.CompanyRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
