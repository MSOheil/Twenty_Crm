namespace Twenty_Crm_Infratstructure.Persistence.Repositories.User;

public class RoleToClaimsRepository : GenericRepository<Twenty_Crm_Domain.Entities.User.RoleToClaims>, IRoleToClaimsRepository
{
    private readonly IApplicationDbContext db;

    public RoleToClaimsRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
