namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Bank;

public class BankBranchRepository : GenericRepository<Twenty_Crm_Domain.Entities.Bank.BankBranch>, IBankBranchRepository
{
    private readonly IApplicationDbContext db;

    public BankBranchRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
