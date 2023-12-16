namespace Twenty_Crm_Infratstructure.Persistence.Repositories.InternationalCertificate;

public class InternationalCertificateRepository : GenericRepository<Twenty_Crm_Domain.Entities.InternationalCertificate.InternationalCertificate>, IInternationalCertificateRepository
{
    private readonly IApplicationDbContext db;

    public InternationalCertificateRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
