namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Marriage;

public class MarriageRepository : GenericRepository<Twenty_Crm_Domain.Entities.Marriage.Marriage>, IMarriageRepository
{
    private readonly IApplicationDbContext db;

    public MarriageRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
