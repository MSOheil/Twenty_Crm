namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Region;

public class StateRepository : GenericRepository<Twenty_Crm_Domain.Entities.Region.State>, IStateRepository
{
    private readonly IApplicationDbContext db;

    public StateRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
