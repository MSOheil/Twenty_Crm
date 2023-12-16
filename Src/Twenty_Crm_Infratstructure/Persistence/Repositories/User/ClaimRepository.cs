namespace Twenty_Crm_Infratstructure.Persistence.Repositories.User;

public class ClaimRepository : GenericRepository<Twenty_Crm_Domain.Entities.User.Claim>, IClaimRepository
{
    private readonly IApplicationDbContext db;

    public ClaimRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
