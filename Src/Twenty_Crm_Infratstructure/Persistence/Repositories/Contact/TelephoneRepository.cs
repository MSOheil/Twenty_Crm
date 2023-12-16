namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Contact;

public class TelephoneRepository : GenericRepository<Twenty_Crm_Domain.Entities.Contact.Telephone>, ITelephoneRepository
{
    private readonly IApplicationDbContext db;

    public TelephoneRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
