namespace Twenty_Crm_Infratstructure.Persistence.Configuration.User;

public class RoleToClaimsConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.User.RoleToClaims>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.User.RoleToClaims> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);

    }
}
