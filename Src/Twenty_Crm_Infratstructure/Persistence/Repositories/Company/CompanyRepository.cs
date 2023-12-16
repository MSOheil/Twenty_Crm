namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Company;

public class CompanyRepository : GenericRepository<Twenty_Crm_Domain.Entities.Company.Company>, ICompanyRepository
{
    private readonly IApplicationDbContext db;

    public CompanyRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
