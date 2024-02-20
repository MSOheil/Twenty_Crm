namespace Twenty_Crm_Application.Common.Services.Group;

public class UserToGroupService : IUserToGroupService
{
    private readonly ILogger<UserToGroupService> logger;
    private readonly IUserToGroupRepo userToGroupRepo;

    public UserToGroupService(IUserToGroupRepo userToGroupRepo, ILogger<UserToGroupService> logger)
    {
        this.userToGroupRepo = userToGroupRepo;
        this.logger = logger;
    }

    public async Task<ResponseDto<bool>> CreateManyUserToGroupAsync(IList<Guid> groupList, Guid userRef)
    {
        try
        {
            var userToGroupList = new List<Twenty_Crm_Domain.Entities.Group.UserToGroup>();
            for (int i = 0; i < groupList.Count; i++)
            {
                userToGroupList.Add(new UserToGroup
                {
                    UserRef = userRef,
                    GropuRef = groupList[i],
                    CreateDate = DateTime.Now,
                    //ModifyDate = DateTime.Now,
                });
            }

            await this.userToGroupRepo.AddRangeAsync(userToGroupList);

            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);
        }
        catch (Exception ex)
        {
            this.logger.LogError($"we have error in line 38 with error message : {ex.Message}" +
                $" in class [UserToGroupService]" +
                $"");

            return default;
        }


    }

    public async Task<ResponseDto<bool>> CreateUserToGroupAsync(Guid groupId, Guid userRef)
    {
        try
        {
            var userToGroupList = new Twenty_Crm_Domain.Entities.Group.UserToGroup()
            {
                GropuRef = groupId,
                UserRef = userRef,
            };

            await this.userToGroupRepo.CreateAsync(userToGroupList, "");

            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);
        }
        catch (Exception ex)
        {
            this.logger.LogError($"we have error in line 38 with error message : {ex.Message}" +
                $" in class [UserToGroupService]" +
                $"");

            return default;
        }
    }

    public async Task<ResponseDto<bool>> UpsertUserToGroupAsync(IList<Guid> dtos, Guid userRef)
    {
        try
        {
            var allIds = await this.userToGroupRepo.GetAll()
                .Where(d => d.UserRef.Equals(userRef)).Select(d => d.GropuRef).ToListAsync();
            var deletedGroups = await this.userToGroupRepo.GetAll()
                .Where(s => s.UserRef.Equals(userRef) && !dtos.Contains(s.GropuRef ?? Guid.Empty)).ToListAsync();
            // GetDeletedUserGroups

            await this.userToGroupRepo.DeleteManyAsync(deletedGroups, "");
            // GetUpdateUserGroups
            var newUserGroups = dtos.Where(s => !allIds.Contains(s)).ToList();
        await    this.CreateManyUserToGroupAsync(newUserGroups, userRef);
            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);
        }
        catch (Exception ex)
        {
            return new ResponseDto<bool>("ثبت اطلاعات با خطا مواجه شده"
                , 500, false);
        }
    }
    private IList<Guid> GetDtoIds(dynamic dtos)
    {
        var ids = new List<Guid>();
        for (int i = 0; i < dtos.Count; i++)
        {
            ids.Add(dtos[i].Id ?? Guid.Empty);
        }
        return ids;
    }
    private IList<Guid> GetGroupsId(dynamic dtos)
    {
        var ids = new List<Guid>();
        for (int i = 0; i < dtos.Count; i++)
        {
            ids.Add(dtos[i].GroupRef ?? Guid.Empty);
        }
        return ids;
    }
}
