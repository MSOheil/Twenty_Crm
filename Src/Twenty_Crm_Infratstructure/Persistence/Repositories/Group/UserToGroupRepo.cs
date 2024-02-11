namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Group;

public class UserToGroupRepo : GenericRepository<Twenty_Crm_Domain.Entities.Group.UserToGroup>, IUserToGroupRepo
{
    private readonly IApplicationDbContext db;

    public UserToGroupRepo(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
