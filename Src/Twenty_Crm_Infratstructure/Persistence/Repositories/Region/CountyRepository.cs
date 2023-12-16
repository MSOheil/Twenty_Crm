namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Region;

public class CountyRepository : GenericRepository<Twenty_Crm_Domain.Entities.Region.County>, ICountyRepository
{
    private readonly IApplicationDbContext db;

    public CountyRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
