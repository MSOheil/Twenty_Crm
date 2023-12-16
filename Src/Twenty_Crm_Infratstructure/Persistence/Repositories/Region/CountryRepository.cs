namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Region;

public class CountryRepository : GenericRepository<Twenty_Crm_Domain.Entities.Region.Country>, ICountryRepository
{
    private readonly IApplicationDbContext db;

    public CountryRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
