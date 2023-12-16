namespace Twenty_Crm_Infratstructure.Persistence.Configuration.User;

public class ClaimConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.User.Claim>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.User.Claim> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);
        builder.Property(z => z.Name).HasMaxLength(150);



        builder.HasMany(z => z.RoleToClaims)
            .WithOne(b => b.Claim)
                .HasForeignKey(b => b.ClaimRef);
    }
}
