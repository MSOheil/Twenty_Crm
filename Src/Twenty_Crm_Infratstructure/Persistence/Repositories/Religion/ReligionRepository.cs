namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Religion;

public class ReligionRepository : GenericRepository<Twenty_Crm_Domain.Entities.Religion.Religion>, IReligionRepository
{
    private readonly IApplicationDbContext db;

    public ReligionRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
