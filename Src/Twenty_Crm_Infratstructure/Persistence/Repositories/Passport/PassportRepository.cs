namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Passport;

public class PassportRepository : GenericRepository<Twenty_Crm_Domain.Entities.Passport.Passport>, IPassportRepository
{
    private readonly IApplicationDbContext db;

    public PassportRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
