namespace Twenty_Crm_Infratstructure.Persistence.Repositories.PhoneNumber;
public class PhoneNumberRepo : GenericRepository<Twenty_Crm_Domain.Entities.Contact.Telephone>, IPhoneNumberRepo
{
    private readonly IApplicationDbContext db;

    public PhoneNumberRepo(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
