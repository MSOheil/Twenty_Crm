namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Company;

public class CompanyToUserRepository : GenericRepository<Twenty_Crm_Domain.Entities.Company.CompanyToUser>, ICompanyToUserRepository
{
    private readonly IApplicationDbContext db;

    public CompanyToUserRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
