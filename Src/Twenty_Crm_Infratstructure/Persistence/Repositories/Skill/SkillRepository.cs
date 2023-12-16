namespace Twenty_Crm_Infratstructure.Persistence.Repositories.Skill;

public class SkillRepository : GenericRepository<Twenty_Crm_Domain.Entities.Skill.Skill>, ISkillRepository
{
    private readonly IApplicationDbContext db;

    public SkillRepository(IApplicationDbContext db) : base(db)
    {
        this.db = db;
    }
}
