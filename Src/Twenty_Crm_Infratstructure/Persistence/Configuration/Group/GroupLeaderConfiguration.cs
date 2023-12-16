namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Group;

public class GroupLeaderConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Group.GroupLeader>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Group.GroupLeader> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);


        builder.Property(b => b.Name).HasMaxLength(150);
        builder.Property(b => b.Description).HasMaxLength(400);


        builder.HasOne(b => b.User)
            .WithMany(b => b.GroupLeaders)
                .HasForeignKey(z => z.UserRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
