namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Contact;

public class MobileConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Contact.Mobile>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Contact.Mobile> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);


        builder.Property(b => b.PhoneNumber).HasMaxLength(30);


        builder.HasOne(b => b.User)
            .WithMany(b => b.Mobiles)
                .HasForeignKey(z => z.UserRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(b => b.Operator)
            .WithMany(b => b.Mobiles)
                .HasForeignKey(z => z.OperatorRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
