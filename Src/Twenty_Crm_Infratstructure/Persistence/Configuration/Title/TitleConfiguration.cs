namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Title;

public class TitleConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Title.Title>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Title.Title> builder)
    {
        
        


        builder.Property(b => b.Name).HasMaxLength(150);


        builder.HasOne(b => b.Company)
            .WithOne(b => b.Title)
                .HasForeignKey<Twenty_Crm_Domain.Entities.Title.Title>(z => z.CompanyRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
