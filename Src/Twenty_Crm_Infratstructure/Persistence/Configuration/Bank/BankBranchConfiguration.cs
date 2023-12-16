namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Bank;

public class BankBranchConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Bank.BankBranch>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Bank.BankBranch> builder)
    {
        builder.HasOne(b => b.Bank)
             .WithMany(z => z.BankBranches)
                 .HasForeignKey(b => b.BankRef).IsRequired(true);



        //builder.HasOne(b => b.City)
        //    .WithMany(b => b.Branches).
        //    HasForeignKey(b => b.CityRef);

        builder.Property(b => b.PostalCode)
            .HasMaxLength(15);

        builder.Property(b => b.Title)
       .HasMaxLength(100);

        builder.Property(b => b.Address)
         .HasMaxLength(600);

        builder.Property(b => b.Description)
         .HasMaxLength(300);

        builder.Property(b => b.Fax)
         .HasMaxLength(15);
    }
}
