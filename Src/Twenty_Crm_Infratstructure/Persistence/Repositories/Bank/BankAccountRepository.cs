namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Bank;

public class BankAccountRepository : GenericRepository<Twenty_Crm_Domain.Entities.Bank.BankAccount>, IBankAccountRepository
{
    private readonly IApplicationDbContext db;

    public BankAccountRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
