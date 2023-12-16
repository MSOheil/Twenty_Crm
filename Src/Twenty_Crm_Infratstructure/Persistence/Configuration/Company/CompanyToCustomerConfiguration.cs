namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Company;

public class CompanyToCustomerConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Company.CompanyToCustomer>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Company.CompanyToCustomer> builder)
    {

        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);

        builder.HasOne(b => b.Company)
                .WithMany(b => b.CompanyToCustomer)
                    .HasForeignKey(b => b.CompanyRef).OnDelete(DeleteBehavior.NoAction);



        builder.HasOne(b => b.Customer)
                .WithMany(b => b.CustomerToCompany)
                    .HasForeignKey(b => b.CustomerRef).OnDelete(DeleteBehavior.NoAction);

    }
}
