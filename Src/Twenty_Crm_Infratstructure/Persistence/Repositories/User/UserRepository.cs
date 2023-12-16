namespace Twenty_Crm_Infratstructure.Persistence.Repositories.User;

public class UserRepository : GenericRepository<Twenty_Crm_Domain.Entities.User.User>, IUserRepository
{
    private readonly IApplicationDbContext db;

    public UserRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
