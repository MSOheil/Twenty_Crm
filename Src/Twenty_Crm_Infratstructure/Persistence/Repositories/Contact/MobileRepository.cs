namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Contact;

public class MobileRepository : GenericRepository<Twenty_Crm_Domain.Entities.Telephone.Mobile>, IMobileRepository
{
    private readonly IApplicationDbContext db;

    public MobileRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
