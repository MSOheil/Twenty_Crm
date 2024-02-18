namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Contact;

public class TelephoneConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Telephone.Telephone>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Telephone.Telephone> builder)
    {
        
        


        builder.Property(b => b.TelephoneNumber).HasMaxLength(30);
        builder.Property(b => b.PrePhoneNumber).HasMaxLength(5);


        builder.HasOne(b => b.User)
            .WithMany(b => b.Telephones)
                .HasForeignKey(z => z.UserRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(b => b.Operator)
            .WithMany(b => b.Telephones)
                .HasForeignKey(z => z.OperatorRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(b => b.City)
            .WithMany(b => b.Telephones)
                .HasForeignKey(z => z.StateRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
