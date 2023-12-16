namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Address;

public class AddressRepository : GenericRepository<Twenty_Crm_Domain.Entities.Address.Address>, IAddressRepository
{
    private readonly IApplicationDbContext db;

    public AddressRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
