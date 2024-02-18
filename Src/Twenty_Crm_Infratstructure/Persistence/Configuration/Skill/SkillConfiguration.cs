namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Skill;

public class SkillConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Skill.Skill>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Skill.Skill> builder)
    {
        
        


        builder.Property(b => b.Name).HasMaxLength(150);
        builder.Property(b => b.Description).HasMaxLength(400);


        builder.HasOne(b => b.User)
            .WithMany(b => b.Skills)
                .HasForeignKey(z => z.UserRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
