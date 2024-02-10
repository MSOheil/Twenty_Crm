using Twenty_Crm_Domain.Entities.User;

namespace Twenty_Crm_Application.Common.Services.User;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly ILogger<UserService> logger;
    public UserService(IUserRepository userRepository, ILogger<UserService> logger)
    {
        this.logger = logger;
        _userRepository = userRepository;
    }

    public async Task<ResponseDto<ShowUserDto>> CreateUserAsync(CreateUserDto dto)
    {
        try
        {
            var user = await _userRepository.CreateAsync(new Twenty_Crm_Domain.Entities.User.User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                FatherName = dto.FatherName,
                Gender = dto.Gender,
                NationalCode = dto.NationalCode,
                BirthDay = dto.BirthDay,
                EmailAddress = dto.EmailAddress,
                Housing = dto.Housing,
                HashedPassword = dto.Password,
                RefreshToken = dto.RefreshToken,
                RefreshTokenExpire = dto.RefreshTokenExpire,
                DateOfBirth = dto.DateOfBirth,
                PayerId = dto.PayerId,
                ProfileImage = dto.ProfileImage,
                PersonalCode = dto.PersonalCode,
                ReligionRef = dto.ReligionRef

            }, dto.UserName);
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
            var user = await this._userRepository.GetByIdAsync(id);

            if (user is not null)
            {
                await this._userRepository.DeleteAsync(id, userActionName);

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
        var data = await this._userRepository.GetAll()
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
        return _userRepository.GetAll()
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
                PersonalCode = b.PersonalCode,
                ReligionRef = b.ReligionRef
            }).PaginatedListAsync(dto.PageNumber, dto.PageSize);
    }

    public async Task<ResponseDto<bool>> UpdateUserAsync(Guid userId, UpdateUserDto dto)
    {
        try
        {

            var user = await this._userRepository.GetByIdAsync(userId);


            if (user is not null)
            {
                user.FirstName = dto.FirstName;
                user.LastName = dto.LastName;




                await this._userRepository.UpdateAsync(user, dto.UserActionName ?? string.Empty);


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
