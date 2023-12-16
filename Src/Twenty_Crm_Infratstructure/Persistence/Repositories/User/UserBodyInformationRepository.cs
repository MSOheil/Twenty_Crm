namespace Twenty_Crm_Infratstructure.Persistence.Repositories.User;

public class UserBodyInformationRepository : GenericRepository<Twenty_Crm_Domain.Entities.User.UserBodyInformation>, IUserBodyInformationRepository
{
    private readonly IApplicationDbContext db;

    public UserBodyInformationRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
