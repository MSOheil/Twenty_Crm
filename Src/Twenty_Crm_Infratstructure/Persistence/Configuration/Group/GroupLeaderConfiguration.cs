namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Group;

public class GroupLeaderConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Group.Group>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Group.Group> builder)
    {
        
        


        builder.Property(b => b.Name).HasMaxLength(150);
        builder.Property(b => b.Description).HasMaxLength(400);

 
    }
}
