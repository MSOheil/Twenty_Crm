namespace Twenty_Crm_Infratstructure.Persistence.Repositories.License;

public class LicenseRepository : GenericRepository<Twenty_Crm_Domain.Entities.License.License>, ILicenseRepository
{
    private readonly IApplicationDbContext db;

    public LicenseRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
