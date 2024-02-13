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
                CompanyName = dto.CompanyName,
                CompanyCreated = dto.CompanyRef,
            }, dto.FirstName);
            if (dto.GroupList != null && dto.GroupList.Count > 0)
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

    public async Task<PaginatedList<ShowUserDto>> GetUserByPaginationAsync(Guid companyRef, GetWithPagination dto)
    {
        var data = await userRepository.GetAll()
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
                ReligionRef = b.ReligionRef,
                CompanyName = b.CompanyName,
                Addreses = b.Addresses.Count > 0 ? b.Addresses.
                Where(b => !b.BaseStatus.Equals(BaseEntityStatus.Deleted)).Select
                (s => new ShowAddressDto
                {
                    Id = s.Id,
                    Alley = s.Alley,
                    CityRef = s.SBCityRef ?? Guid.Empty,
                    HouseNumber = s.HouseNumber,
                    PostalCode = s.PostalCode,
                    RegionOrVilageName = s.RegionOrVilageName,
                    Street = s.Street,
                    Title = s.Title,
                }).ToList() : new List<ShowAddressDto>(),
                PhoneNumbers =
                b.Mobiles.Count > 0 ? b.Mobiles.Where(b => !b.BaseStatus.Equals(BaseEntityStatus.Deleted))
                    .Select(t => new ShowPhoneNumberDto
                    {
                        Id = t.Id,
                        PhoneNumber = t.PhoneNumber,
                        Title = t.Title,
                        UserRef = t.UserRef,
                    }).ToList() : new List<ShowPhoneNumberDto>(),
                Telephones =
                b.Telephones.Count > 0 ? b.Telephones.Where(b => !b.BaseStatus.Equals(BaseEntityStatus.Deleted))
                    .Select(t => new ShowTelephonesDto
                    {
                        Id = t.Id,
                        Title = t.Title,
                        PhoneNumber = t.TelephoneNumber,
                        PrePhoneNumber = t.PrePhoneNumber,
                        CityRef = t.CityRef,
                        UserRef = t.UserRef,
                    }).ToList() : new List<ShowTelephonesDto>(),
                Groups = b.UserToGroups.Count > 0 ?
                b.UserToGroups.Where(s => !s.BaseStatus.Equals(BaseEntityStatus.Deleted))
                    .Select(z => new ShowGroupDto
                    {
                        Id = z.Id,
                        Name = z.Group.Name,
                    }).ToList() : new List<ShowGroupDto>(),
                Websites = b.Websites.Count > 0 ? b.Websites.Select(e => new ShowWebsiteDto
                {
                    Id = e.Id,
                    Name = e.Name,
                    Url = e.Url,
                }).ToList() : new List<ShowWebsiteDto>(),
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
