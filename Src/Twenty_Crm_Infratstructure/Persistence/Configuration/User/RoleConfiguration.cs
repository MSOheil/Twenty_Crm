namespace Twenty_Crm_Infratstructure.Persistence.Configuration.User;

public class RoleConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.User.Role>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.User.Role> builder)
    {
        
        
        builder.Property(z => z.Name).HasMaxLength(150);


        //Relations

        builder.HasMany(b => b.RoleToClaims)
            .WithOne(b => b.Role).HasForeignKey(z => z.RoleRef);
    }
}
