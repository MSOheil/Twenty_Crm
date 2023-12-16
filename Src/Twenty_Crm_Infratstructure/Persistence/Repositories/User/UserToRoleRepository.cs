namespace Twenty_Crm_Infratstructure.Persistence.Repositories.User;

public class UserToRoleRepository : GenericRepository<Twenty_Crm_Domain.Entities.User.UserToRole>, IUserToRoleRepository
{
    private readonly IApplicationDbContext db;

    public UserToRoleRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
