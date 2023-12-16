using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Twenty_Crm_Application.Common.Interfaces.AppDbContext;
namespace Twenty_Crm_Infratstructure.Persistence.Db;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Address> Address => Set<Address>();
    public DbSet<Bank> Banks => Set<Bank>();
    public DbSet<BankBranch> BankBranches => Set<BankBranch>();
    public DbSet<BankAccount> BankAccounts => Set<BankAccount>();
    public DbSet<Company> Companies => Set<Company>();
    public DbSet<CompanyToCustomer> CompanyToCustomers => Set<CompanyToCustomer>();
    public DbSet<CompanyToUser> CompanyToUsers => Set<CompanyToUser>();
    public DbSet<Mobile> Mobiles => Set<Mobile>();
    public DbSet<Operator> Operators => Set<Operator>();
    public DbSet<Telephone> Telephones => Set<Telephone>();
    public DbSet<GroupLeader> GroupLeaders => Set<GroupLeader>();
    public DbSet<SubGroup> SubGroups => Set<SubGroup>();
    public DbSet<InternationalCertificate> InternationalCertificates => Set<InternationalCertificate>();
    public DbSet<License> Licenses => Set<License>();
    public DbSet<Marriage> Marriages => Set<Marriage>();
    public DbSet<Passport> Passports => Set<Passport>();
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<City> Cities => Set<City>();
    public DbSet<State> States => Set<State>();
    public DbSet<County> Counties => Set<County>();
    public DbSet<Country> Country => Set<Country>();
    public DbSet<Religion> Religions => Set<Religion>();
    public DbSet<Skill> Skills => Set<Skill>();
    public DbSet<Title> Titles => Set<Title>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<Claim> Claims => Set<Claim>();
    public DbSet<UserToRole> UserToRoles => Set<UserToRole>();
    public DbSet<RoleToClaims> RoleToClaims => Set<RoleToClaims>();
    public DbSet<Website> Websites => Set<Website>();
    public DbSet<WorkPlace> WorkPlaces => Set<WorkPlace>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
    }
    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {

        return await base.SaveChangesAsync(cancellationToken);
    }

    public DbSet<T> SetDb<T>() where T : BaseEntity
    {
        return this.Set<T>();
    }
}
