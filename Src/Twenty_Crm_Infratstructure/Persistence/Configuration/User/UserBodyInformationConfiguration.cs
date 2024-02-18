namespace Twenty_Crm_Infratstructure.Persistence.Configuration.User;

public class UserBodyInformationConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.User.UserBodyInformation>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.User.UserBodyInformation> builder)
    {
        
        


        builder.Property(b => b.Height).HasMaxLength(30);
        builder.Property(b => b.Weight).HasMaxLength(30);


        builder.HasOne(b => b.User)
            .WithMany(b => b.UserBodyInformations)
                .HasForeignKey(z => z.UserRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
