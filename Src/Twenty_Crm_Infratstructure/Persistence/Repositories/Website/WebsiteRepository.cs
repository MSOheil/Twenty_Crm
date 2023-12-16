namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Website;

public class WebsiteRepository : GenericRepository<Twenty_Crm_Domain.Entities.Website.Website>, IWebsiteRepository
{
    private readonly IApplicationDbContext db;

    public WebsiteRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
