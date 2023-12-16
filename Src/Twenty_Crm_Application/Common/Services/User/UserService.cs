using Twenty_Crm_Application.Common.Interfaces.Repositories.User;
using Twenty_Crm_Application.Common.Mapping;
using Twenty_Crm_Application.Common.Models.Dto;
using Twenty_Crm_Application.Common.Models.Dto.User;

namespace Twenty_Crm_Application.Common.Services.User;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ResponseDto<bool>> CreateUserAsync(CreateUserDto dto)
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
                Password = dto.Password,
                Email = dto.Email,
                RefreshToken = dto.RefreshToken,
                RefreshTokenExpire = dto.RefreshTokenExpire,
                DateOfBirth = dto.DateOfBirth,
                PayerId = dto.PayerId,
                ProfileImage = dto.ProfileImage,
                PersonalCode = dto.PersonalCode,
                ReligionRef = dto.ReligionRef

            }, dto.UserName);
            return new ResponseDto<bool>("ثبت نام موفقیت امیز بود", 200, true);
        }
        catch (Exception)
        {
            return new ResponseDto<bool>("ثبت نام موفقیت امیز نبود", 400, false);
        }
    }

    public Task<PaginatedList<ShowUserDto>> GetUserByPaginationAsync(GetWithPagination dto)
    {
        return _userRepository.GetAll().Select(b => new ShowUserDto
        {
            FirstName = b.FirstName,
            LastName = b.LastName,
            FatherName = b.FatherName,
            Gender = b.Gender,
            NationalCode = b.NationalCode,
            BirthDay = b.BirthDay,
            EmailAddress = b.EmailAddress,
            Housing = b.Housing,
            Password = b.Password,
            Email = b.Email,
            RefreshToken = b.RefreshToken,
            RefreshTokenExpire = b.RefreshTokenExpire,
            DateOfBirth = b.DateOfBirth,
            PayerId = b.PayerId,
            ProfileImage = b.ProfileImage,
            PersonalCode = b.PersonalCode,
            ReligionRef = b.ReligionRef
        }).AsNoTracking().PaginatedListAsync(dto.PageNumber, dto.PageSize);
    }
}
