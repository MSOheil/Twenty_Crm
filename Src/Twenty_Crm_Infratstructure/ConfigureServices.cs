namespace Twenty_Crm_Infratstructure;
public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services
        , IConfiguration configuration)
    {
        services.AddScoped<IAddressRepository, AddressRepository>();
        services.AddScoped<IBankRepository, BankRepository>();
        services.AddScoped<IBankAccountRepository, BankAccountRepository>();
        services.AddScoped<IBankBranchRepository, BankBranchRepository>();
        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<ICompanyToCustomerRepository, CompanyToCustomerRepository>();
        services.AddScoped<ICompanyToUserRepository, CompanyToUserRepository>();
        services.AddScoped<IMobileRepository, MobileRepository>();
        services.AddScoped<IOperatorRepository, OperatorRepository>();
        services.AddScoped<ITelephoneRepository, TelephoneRepository>();
        services.AddScoped<IGroupRepository, GroupRepository>();
        services.AddScoped<ISubGroupRepository, SubGroupRepository>();
        services.AddScoped<IInternationalCertificateRepository, InternationalCertificateRepository>();
        services.AddScoped<ILicenseRepository, LicenseRepository>();
        services.AddScoped<IMarriageRepository, MarriageRepository>();
        services.AddScoped<IPassportRepository, PassportRepository>();
        services.AddScoped<IPostRepository, PostRepository>();
        services.AddScoped<ICityRepository, CityRepository>();
        services.AddScoped<ICountryRepository, CountryRepository>();
        services.AddScoped<ICountyRepository, CountyRepository>();
        services.AddScoped<IStateRepository, StateRepository>();
        services.AddScoped<IReligionRepository, ReligionRepository>();
        services.AddScoped<ISkillRepository, SkillRepository>();
        services.AddScoped<ITitleRepository, TitleRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserBodyInformationRepository, UserBodyInformationRepository>();
        services.AddScoped<IUserToRoleRepository, UserToRoleRepository>();
        services.AddScoped<IRoleRepository, RoleRepository>();
        services.AddScoped<IClaimRepository, ClaimRepository>();
        services.AddScoped<IRoleToClaimsRepository, RoleToClaimsRepository>();
        services.AddScoped<IWebsiteRepository, WebsiteRepository>();
        services.AddScoped<IWorkPlaceRepository, WorkPlaceRepository>();
        services.AddScoped<IPhoneNumberRepo, PhoneNumberRepo>();
        services.AddScoped<IUserToGroupRepo, UserToGroupRepo>();
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        #region  dbContext
        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
        services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(configuration.GetConnectionString("SqlServer")));


        #endregion
        return services;
    }
}
