namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Region;

public class CountryConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Region.Country>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Region.Country> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);
        builder.Property(b => b.PersianName).HasMaxLength(150);
        builder.Property(b => b.EnglishName).HasMaxLength(150);
        builder.Property(b => b.PersianNationName).HasMaxLength(150);
        builder.Property(b => b.EnglishNationName).HasMaxLength(150);
        builder.Property(b => b.PersianAdjective).HasMaxLength(150);
        builder.Property(b => b.EnglishAdjective).HasMaxLength(150);
        builder.Property(b => b.Continent).HasMaxLength(150);
        builder.Property(b => b.LanguageName).HasMaxLength(150);
        builder.Property(b => b.DomainName).HasMaxLength(150);


        builder.HasMany(z => z.States)
                 .WithOne(b => b.Country)
                     .HasForeignKey(z => z.CountryRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
