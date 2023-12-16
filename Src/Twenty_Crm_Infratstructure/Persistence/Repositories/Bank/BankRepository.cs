namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Bank;

public class BankRepository : GenericRepository<Twenty_Crm_Domain.Entities.Bank.Bank>, IBankRepository
{
    private readonly IApplicationDbContext db;

    public BankRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
