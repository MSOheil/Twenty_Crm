namespace Twenty_Crm_Infratstructure.Persistence.Configuration.Post;

public class PostConfiguration : IEntityTypeConfiguration<Twenty_Crm_Domain.Entities.Post.Post>
{
    public void Configure(EntityTypeBuilder<Twenty_Crm_Domain.Entities.Post.Post> builder)
    {
        builder.Property(z => z.CreatedBy).HasMaxLength(140);
        builder.Property(z => z.ModifiedBy).HasMaxLength(140);


        builder.Property(b => b.Name).HasMaxLength(150);
        builder.Property(b => b.Description).HasMaxLength(400);
    }
}
