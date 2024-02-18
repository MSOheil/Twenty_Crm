namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Company;

public class CompanyConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Company.Company>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Company.Company> builder)
    {
        
        
        builder.Property(z => z.Name).HasMaxLength(300);
        builder.Property(z => z.InsertNumber).HasMaxLength(150);
        builder.Property(b => b.BrandName).HasMaxLength(150);
        builder.Property(b => b.EconomicalNumber).HasMaxLength(15);
        builder.Property(b => b.NationalCode).HasMaxLength(20);

        builder.HasOne(b => b.Title)
            .WithOne(b => b.Company)
                .HasForeignKey<Twenty_Crm_Domain.Entities.Company.Company>(z => z.TitleRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);

    }
}
