namespace Twenty_Crm_Application.Common.Interfaces.Services.Website;
public interface IWebsiteService
{
    Task<ResponseDto<bool>> CreateManyWebsiteAsync(IList<CreateManyWebsiteDto> dto);
}
