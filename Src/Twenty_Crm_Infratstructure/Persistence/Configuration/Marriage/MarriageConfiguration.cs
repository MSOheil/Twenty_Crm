namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Marriage;

public class MarriageConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Marriage.Marriage>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Marriage.Marriage> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);


        builder.Property(b => b.SpouseName).HasMaxLength(150);


        builder.HasOne(b => b.User)
            .WithMany(b => b.Marriages)
                .HasForeignKey(z => z.UserRef).IsRequired(false).OnDelete(DeleteBehavior.NoAction);
    }
}
