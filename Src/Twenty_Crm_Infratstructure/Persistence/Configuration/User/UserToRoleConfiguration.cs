namespace Twenty_Crm_Infratstructure.Persistence.Configuration.User;

public class UserToRoleConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.User.UserToRole>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.User.UserToRole> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);



        builder.HasOne(z => z.User)
            .WithMany(b => b.UserToRole)
                .HasForeignKey(z => z.UserRef).IsRequired(true);

        builder.HasOne(z => z.Role)
    .WithMany(b => b.UserToRole)
        .HasForeignKey(z => z.RoleRef).IsRequired(true);
    }
}
