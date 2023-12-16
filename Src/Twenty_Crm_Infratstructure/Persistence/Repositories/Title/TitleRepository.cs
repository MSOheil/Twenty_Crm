namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Title;

public class TitleRepository : GenericRepository<Twenty_Crm_Domain.Entities.Title.Title>, ITitleRepository
{
    private readonly IApplicationDbContext db;

    public TitleRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
