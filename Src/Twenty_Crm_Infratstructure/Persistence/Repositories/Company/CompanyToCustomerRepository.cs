namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Company;

public class CompanyToCustomerRepository : GenericRepository<Twenty_Crm_Domain.Entities.Company.CompanyToCustomer>, ICompanyToCustomerRepository
{
    private readonly IApplicationDbContext db;

    public CompanyToCustomerRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
