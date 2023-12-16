namespace Twenty_Crm_Infratstructure.Persistence.Configuration.User;

public class UserConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.User.User>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.User.User> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);



        builder.Property(z => z.FirstName).HasMaxLength(150);
        builder.Property(z => z.LastName).HasMaxLength(150);
        builder.Property(b => b.NationalCode).HasMaxLength(12);







        builder.HasOne(z => z.Religions)
            .WithMany(z => z.Users)
                .HasForeignKey(z => z.ReligionRef);

    }
}
