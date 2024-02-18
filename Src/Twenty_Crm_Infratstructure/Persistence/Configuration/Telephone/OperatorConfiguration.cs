namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Contact;

public class OperatorConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Telephone.Operator>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Telephone.Operator> builder)
    {
        
        


        builder.Property(b => b.Name).HasMaxLength(150);
        builder.Property(b => b.CompanyName).HasMaxLength(150);
        builder.Property(b => b.Description).HasMaxLength(400);

    }
}
