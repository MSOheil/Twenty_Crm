namespace Twenty_Crm_Application.Common.Services.Group;
public class GroupService : IGroupService
{
    private readonly IGroupRepository groupRepository;
    private readonly ILogger<GroupService> logger;
    public GroupService(IGroupRepository groupRepository, ILogger<GroupService> logger)
    {
        this.groupRepository = groupRepository;
        this.logger = logger; 
    }

    public async Task<ResponseDto<ShowGroupDto>> CreateGroupDto(CreateGroupDto dto)
    {
        try
        {
            var group = new Twenty_Crm_Domain.Entities.Group.Group
            {
                CreatedCompany = dto.CreatedCompany,
                Name = dto.Name,
                Description = dto.Description
            };

            var create = await this.groupRepository.CreateAsync(group, "");
            return new ResponseDto<ShowGroupDto>("ثبت اطلاعات با موفقیت انجام شد", 200, new ShowGroupDto
            {
                Id = create.Id,
            });


        }
        catch (Exception ex)
        {

            this.logger.LogError($"" +
                $"we have error in line 22 with error message : {ex.Message}" +
                $" in class [GroupService]");
            return default;
        }
    }

    public async Task<ResponseDto<bool>> DeleteGroupAsync(Guid groupId)
    {
        try
        {
            var group = await this.groupRepository.GetByIdAsync(groupId);

            if (group is not null)
            {
                await this.groupRepository.DeleteAsync(groupId, "");


                return new ResponseDto<bool>("حذف اطلاعات با موفقیت انجام شد"
                    , 200, true);
            }

            return new ResponseDto<bool>("چنین گروه وجود ندارد"
                , 404, false);
        }
        catch (Exception ex)
        {
            this.logger.LogError($"" +
                $" we have erro in line 60 class [GroupService]" +
                $" with error message : {ex.Message}");
            return default;
        }
    }

    public async Task<PaginatedList<ShowGroupDto>> GetCompanyGroupListAsync(Guid companyRef, GetWithPagination dto)
    {
        var data = await this.groupRepository.GetAll()
                 .Where(b => b.CreatedCompany.Equals(companyRef))
                     .Select(s => new ShowGroupDto
                     {
                         Id = s.Id,
                         Description = s.Description,
                         Name = s.Name,
                         UserCount = s.UserToGroups.Count,
                     }).PaginatedListAsync(dto.PageNumber, dto.PageSize);

        return data;
    }
}
