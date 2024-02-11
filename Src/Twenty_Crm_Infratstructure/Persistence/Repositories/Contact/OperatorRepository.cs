namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Contact;

public class OperatorRepository : GenericRepository<Twenty_Crm_Domain.Entities.Telephone.Operator>, IOperatorRepository
{
    private readonly IApplicationDbContext db;

    public OperatorRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
