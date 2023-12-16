namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Bank;

public class BankConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Bank.Bank>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Bank.Bank> builder)
    {
        builder.Property(b => b.Name)
            .HasMaxLength(100);
    }
}
