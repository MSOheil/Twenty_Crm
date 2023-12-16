namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Passport;

public class PassportConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Passport.Passport>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Passport.Passport> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);


        builder.HasOne(b => b.User)
            .WithMany(b => b.Passports)
                .HasForeignKey(z => z.UserRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
