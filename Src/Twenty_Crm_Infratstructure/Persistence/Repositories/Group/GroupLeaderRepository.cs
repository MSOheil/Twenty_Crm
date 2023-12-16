namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Group;

public class GroupLeaderRepository : GenericRepository<Twenty_Crm_Domain.Entities.Group.GroupLeader>, IGroupLeaderRepository
{
    private readonly IApplicationDbContext db;

    public GroupLeaderRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
