namespace Twenty_Crm_Application.Common.Services.Website;
public class WebsiteService : IWebsiteService
{
    private readonly IWebsiteRepository websiteRepository;
    private readonly ILogger<WebsiteService> logger;
    public WebsiteService(IWebsiteRepository websiteRepository, ILogger<WebsiteService> logger)
    {
        this.websiteRepository = websiteRepository;
        this.logger = logger;
    }

    public async Task<ResponseDto<bool>> CreateManyWebsiteAsync(IList<CreateManyWebsiteDto> dto)
    {
        try
        {
            var websites = new List<Twenty_Crm_Domain.Entities.Website.Website>();

            for (int i = 0; i < websites.Count; i++)
            {
                websites.Add(new Twenty_Crm_Domain.Entities.Website.Website
                {
                    UserRef = websites[i].UserRef,
                    Name = websites[i].Name,
                    Url = websites[i].Url,
                });
            }
            await this.websiteRepository.AddRangeAsync(websites);
            
            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);
        }
        catch (Exception ex)
        {



            this.logger.LogError($"we have error in line 40 " +
                $"with error message : {ex.Message}");
            return new ResponseDto<bool>("ثبت اطلاعات با خطا مواجه شد"
                , 500, false);
        }
    }
}
