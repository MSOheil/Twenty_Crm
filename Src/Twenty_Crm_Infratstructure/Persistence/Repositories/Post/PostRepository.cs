namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Post;

public class PostRepository : GenericRepository<Twenty_Crm_Domain.Entities.Post.Post>, IPostRepository
{
    private readonly IApplicationDbContext db;

    public PostRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
