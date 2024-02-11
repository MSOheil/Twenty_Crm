namespace Twenty_Crm_Application.Common.Interfaces.Services.Group;
public interface IGroupService
{
    Task<ResponseDto<ShowGroupDto>> CreateGroupDto(CreateGroupDto dto);
    Task<PaginatedList<ShowGroupDto>> GetCompanyGroupListAsync(Guid companyRef, GetWithPagination dto);
    Task<ResponseDto<bool>> DeleteGroupAsync(Guid groupId);
}
