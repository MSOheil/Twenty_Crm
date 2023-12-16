namespace Twenty_Crm_Application;

public static class ConfigureServices
{
    public static IServiceCollection AddApplcationServices(this IServiceCollection services)
    {
        #region Services
        services.AddScoped<IAddressService, AddressService>();
        services.AddScoped<IBankService, BankService>();
        services.AddScoped<IBankAccountService, BankAccountService>();
        services.AddScoped<IBankBranchService, BankBranchService>();
        services.AddScoped<ICompanyService, CompanyService>();
        services.AddScoped<ICompanyToCustomerService, CompanyToCustomerService>();
        services.AddScoped<ICompanyToUserService, CompanyToUserService>();
        services.AddScoped<IMobileService, MobileService>();
        services.AddScoped<IOperatorService, OperatorService>();
        services.AddScoped<ITelephoneService, TelephoneService>();
        services.AddScoped<IGroupLeaderService, GroupLeaderService>();
        services.AddScoped<ISubGroupService, SubGroupService>();
        services.AddScoped<IInternationalCertificateService, InternationalCertificateService>();
        services.AddScoped<ILicenseService, LicenseService>();
        services.AddScoped<IMarriageService, MarriageService>();
        services.AddScoped<IPassportService, PassportService>();
        services.AddScoped<IPostService, PostService>();
        services.AddScoped<ICityService, CityService>();
        services.AddScoped<ICountryService, CountryService>();
        services.AddScoped<ICountyService, CountyService>();
        services.AddScoped<IStateService, StateService>();
        services.AddScoped<IReligionService, ReligionService>();
        services.AddScoped<ISkillService, SkillService>();
        services.AddScoped<ITitleService, TitleService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserBodyInformationService, UserBodyInformationService>();
        services.AddScoped<IUserToRoleService, UserToRoleService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IClaimService, ClaimService>();
        services.AddScoped<IRoleToClaimsService, RoleToClaimsService>();
        services.AddScoped<IWebsiteService, WebsiteService>();
        services.AddScoped<IWorkPlaceService, WorkPlaceService>();
        #endregion
        #region Repositories

        #endregion

        return services;
    }
}
