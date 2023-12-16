namespace Twenty_Crm_Infratstructure.Persistence.Repositories.User;

public class RoleRepository : GenericRepository<Twenty_Crm_Domain.Entities.User.Role>, IRoleRepository
{
    private readonly IApplicationDbContext db;

    public RoleRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
