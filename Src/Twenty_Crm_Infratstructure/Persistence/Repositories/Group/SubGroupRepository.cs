namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Group;

public class SubGroupRepository : GenericRepository<Twenty_Crm_Domain.Entities.Group.SubGroup>, ISubGroupRepository
{
    private readonly IApplicationDbContext db;

    public SubGroupRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
