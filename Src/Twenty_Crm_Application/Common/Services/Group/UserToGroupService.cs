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
                    ModifyDate = DateTime.Now,
                });
            }

            await this.userToGroupRepo.AddManyAsync(userToGroupList);
            await this.userToGroupRepo.SaveChangeAsync();

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
}
