namespace Twenty_Crm_Infratstructure.Persistence.Configuration.User;

public class UserConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.User.User>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.User.User> builder)
    {
        
        



        builder.Property(z => z.FirstName).HasMaxLength(170);
        builder.Property(z => z.LastName).HasMaxLength(170);
        builder.Property(b => b.NationalCode).HasMaxLength(12);
        builder.Property(b => b.FatherName).HasMaxLength(300);
        builder.Property(b => b.EmailAddress).HasMaxLength(500);
        builder.Property(b => b.HashedPassword).HasMaxLength(150);
        builder.Property(b => b.RefreshToken).HasMaxLength(500);
        builder.Property(b => b.ProfileImage).HasMaxLength(600); 
        builder.Property(b => b.CompanyName).HasMaxLength(350);




        builder.HasOne(z => z.Religions)
            .WithMany(z => z.Users)
                .HasForeignKey(z => z.ReligionRef);

    }
}
