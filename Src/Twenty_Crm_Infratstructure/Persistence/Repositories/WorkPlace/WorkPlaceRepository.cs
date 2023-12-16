namespace Twenty_Crm_Infratstructure.Persistence.Repositories.WorkPlace;

public class WorkPlaceRepository : GenericRepository<Twenty_Crm_Domain.Entities.WorkPlace.WorkPlace>, IWorkPlaceRepository
{
    private readonly IApplicationDbContext db;

    public WorkPlaceRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
