namespace Twenty_Crm_Infratstructure.Persistence.Configuration.InternationalCertificate;

public class InternationalCertificateConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.InternationalCertificate.InternationalCertificate>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.InternationalCertificate.InternationalCertificate> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);


        builder.Property(b => b.Name).HasMaxLength(150);
        builder.Property(b => b.Description).HasMaxLength(400);


        builder.HasOne(b => b.User)
            .WithMany(b => b.InternationalCertificates)
                .HasForeignKey(z => z.UserRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
