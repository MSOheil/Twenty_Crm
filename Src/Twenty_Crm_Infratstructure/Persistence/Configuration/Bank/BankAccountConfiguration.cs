namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Bank;

public class BankAccountConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Bank.BankAccount>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Bank.BankAccount> builder)
    {
        builder.Property(b => b.AccountName)
            .HasMaxLength(150);


        builder.Property(b => b.AccountNumber)
       .HasMaxLength(150);

        //builder.HasOne(b => b.Company)
        //    .WithMany(b => b.BankAccount)
        //        .HasForeignKey(b => b.CompanyRef);



        builder.HasOne(b => b.Branch)
             .WithMany(z => z.BankAccounts)
             .HasForeignKey(z => z.BranchRef).IsRequired(true);
    }
}
