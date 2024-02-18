namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Group;

public class SubGroupConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Group.SubGroup>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Group.SubGroup> builder)
    {
        
        


        builder.HasOne(b => b.GroupLeader)
            .WithMany(b => b.SubGroups)
                .HasForeignKey(z => z.GroupLeaderRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
