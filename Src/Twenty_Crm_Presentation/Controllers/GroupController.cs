namespace Twenty_Crm_Presentation.Controllers;
public class GroupController : BaseController
{
    private readonly IGroupService groupService;

    public GroupController(IGroupService groupService)
    {
        this.groupService = groupService;
    }


    [HttpGet("{companyRef}")]
    public async Task<PaginatedList<ShowGroupDto>> GetList(Guid companyRef, [FromQuery] GetWithPagination dto)
    {
        return await this.groupService.GetCompanyGroupListAsync(companyRef, dto);
    }

    [HttpPost]
    public async Task<ResponseDto<ShowGroupDto>> Create(CreateGroupDto dto)
    {
        return await this.groupService.CreateGroupDto(dto);
    }
    [HttpDelete("{groupId}")]
    public async Task<ResponseDto<bool>> Delete(Guid groupId)
    {
        return await this.groupService.DeleteGroupAsync(groupId);
    }
}
