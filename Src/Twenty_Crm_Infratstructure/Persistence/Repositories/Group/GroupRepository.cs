namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Group;

public class GroupRepository : GenericRepository<Twenty_Crm_Domain.Entities.Group.Group>, IGroupRepository
{
    private readonly IApplicationDbContext db;

    public GroupRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
