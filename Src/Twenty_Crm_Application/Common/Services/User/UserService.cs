namespace Twenty_Crm_Application.Common.Services.User;
public class UserService : IUserService
{
    private readonly IUserRepository userRepository;
    private readonly IUserToGroupService userToGroupService;
    private readonly ILogger<UserService> logger;
    public UserService(IUserRepository userRepository, ILogger<UserService> logger, IUserToGroupService userToGroupService)
    {
        this.logger = logger;
        this.userRepository = userRepository;
        this.userToGroupService = userToGroupService;
    }

    public async Task<ResponseDto<ShowUserDto>> CreateUserAsync(CreateUserDto dto)
    {
        try
        {
            var user = await userRepository.CreateAsync(new Twenty_Crm_Domain.Entities.User.User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                FatherName = dto.FatherName,
                Gender = dto.Gender,
                NationalCode = dto.NationalCode,
                BirthDay = dto.BirthDay ?? DateTime.Now,
                EmailAddress = dto.EmailAddress,
                Housing = dto.Housing,
                RefreshToken = dto.RefreshToken,
                RefreshTokenExpire = dto.RefreshTokenExpire ?? DateTime.Now,
                DateOfBirth = dto.DateOfBirth,
                ProfileImage = dto.ProfileImage,
                ReligionRef = dto.ReligionRef
                ,
                CompanyCreated = dto.CompanyRef,
            }, dto.FirstName);
            if(dto.GroupList!=null&& dto.GroupList.Count > 0)
            {

            var createUserToGroup = await this.userToGroupService.CreateManyUserToGroupAsync(dto.GroupList, user.Id);
            }
            return new ResponseDto<ShowUserDto>("ثبت نام موفقیت امیز بود", 200, new ShowUserDto
            {
                Id = user.Id,
            });
        }
        catch (Exception ex)
        {
            this.logger.LogError($"" +
                $" we have error in line 47 with  error message : {ex.Message}");
            return new ResponseDto<ShowUserDto>("ثبت نام موفقیت امیز نبود", 400, new ShowUserDto
            {
                Id = Guid.Empty,
            });
        }
    }

    public async Task<ResponseDto<bool>> DeleteUserAsync(Guid id, string userActionName)
    {
        try
        {
            var user = await this.userRepository.GetByIdAsync(id);

            if (user is not null)
            {
                await this.userRepository.DeleteAsync(id, userActionName);

                return new ResponseDto<bool>("حذف کاربر با موفقیت انجام شد"
                    , 200, true);
            }

            return new ResponseDto<bool>("چنین کاربری وجود ندارد"
                , 404, false);


        }
        catch (Exception ex)
        {
            this.logger.LogError("We have error in line 90" +
                $" with error message : {ex.Message}");


            return new ResponseDto<bool>("حذف اطلاعات با خطا مواجه شد"
                , 500, false);
        }
    }

    public async Task<ShowUserDto> GetByIdAsync(Guid id)
    {
        var data = await this.userRepository.GetAll()
            .Where(b => b.Id.Equals(id))
                .Select(b => new ShowUserDto
                {
                    Id = b.Id,
                    EmailAddress = b.EmailAddress,
                }).FirstOrDefaultAsync();




        return data;
    }

    public Task<PaginatedList<ShowUserDto>> GetUserByPaginationAsync(Guid companyRef, GetWithPagination dto)
    {
        var data = userRepository.GetAll()
            .Where(b => b.CompanyCreated.Equals(companyRef)).Select(b => new ShowUserDto
            {
                FirstName = b.FirstName,
                LastName = b.LastName,
                FatherName = b.FatherName,
                Gender = b.Gender,
                NationalCode = b.NationalCode,
                BirthDay = b.BirthDay,
                EmailAddress = b.EmailAddress,
                Housing = b.Housing,
                RefreshToken = b.RefreshToken,
                Id = b.Id,
                RefreshTokenExpire = b.RefreshTokenExpire,
                DateOfBirth = b.DateOfBirth,
                PayerId = b.PayerId,
                ProfileImage = b.ProfileImage,
                ReligionRef = b.ReligionRef
            }).PaginatedListAsync(dto.PageNumber, dto.PageSize);
        return data;
    }

    public async Task<ResponseDto<bool>> UpdateUserAsync(Guid userId, UpdateUserDto dto)
    {
        try
        {

            var user = await this.userRepository.GetByIdAsync(userId);


            if (user is not null)
            {
                user.FirstName = dto.FirstName;
                user.LastName = dto.LastName;




                await this.userRepository.UpdateAsync(user, dto.UserActionName ?? string.Empty);


                return new ResponseDto<bool>("ویرایش اطلاعات با موفقیت انجام شد"
                    , 200, true);
            }



            return new ResponseDto<bool>("چنین کاربری وجود ندارد"
                , 404, false);
        }
        catch (Exception ex)
        {

            this.logger.LogError(
                $"we have error in line 91 with error message : {ex.Message}");


            return new ResponseDto<bool>("ویرایش اطلاعات با خطا مواجه شد"
                , 500, false);
        }
    }
}
