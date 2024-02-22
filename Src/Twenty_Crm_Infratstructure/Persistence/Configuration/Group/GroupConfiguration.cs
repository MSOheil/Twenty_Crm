namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Group;

public class GroupConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Group.Group>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Group.Group> builder)
    {
        builder.HasMany(s => s.UserToGroups)
              .WithOne(s => s.Group)
              .HasForeignKey(d => d.GropuRef).IsRequired(true);
    }
}
