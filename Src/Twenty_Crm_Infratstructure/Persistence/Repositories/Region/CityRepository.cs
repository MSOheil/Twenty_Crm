namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Region;

public class CityRepository : GenericRepository<Twenty_Crm_Domain.Entities.Region.City>, ICityRepository
{
    private readonly IApplicationDbContext db;

    public CityRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
