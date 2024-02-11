using Twenty_Crm_Domain.Entities.Telephone;

namespace Twenty_Crm_Application.Common.Interfaces.AppDbContext;

public interface IApplicationDbContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    public DbSet<Address> Address { get; }
    public DbSet<Bank> Banks { get; }
    public DbSet<BankBranch> BankBranches { get; }
    public DbSet<BankAccount> BankAccounts { get; }
    public DbSet<Company> Companies { get; }
    public DbSet<CompanyToCustomer> CompanyToCustomers { get; }
    public DbSet<CompanyToUser> CompanyToUsers { get; }
    public DbSet<Mobile> Mobiles { get; }
    public DbSet<Operator> Operators { get; }
    public DbSet<Telephone> Telephones { get; }
    public DbSet<Group> GroupLeaders { get; }
    public DbSet<SubGroup> SubGroups { get; }
    public DbSet<InternationalCertificate> InternationalCertificates { get; }
    public DbSet<License> Licenses { get; }
    public DbSet<Marriage> Marriages { get; }
    public DbSet<Passport> Passports { get; }
    public DbSet<Post> Posts { get; }
    public DbSet<City> Cities { get; }
    public DbSet<State> States { get; }
    public DbSet<County> Counties { get; }
    public DbSet<Country> Country { get; }
    public DbSet<Religion> Religions { get; }
    public DbSet<Skill> Skills { get; }
    public DbSet<Title> Titles { get; }
    public DbSet<User> Users { get; }
    public DbSet<Role> Roles { get; }
    public DbSet<Claim> Claims { get; }
    public DbSet<UserToRole> UserToRoles { get; }
    public DbSet<RoleToClaims> RoleToClaims { get; }
    public DbSet<Website> Websites { get; }
    public DbSet<WorkPlace> WorkPlaces { get; }
    DbSet<T> SetDb<T>() where T : BaseEntity;
}
