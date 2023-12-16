using Twenty_Crm_Application.Common.Models.Dto;
using Twenty_Crm_Application.Common.Models.Dto.User;

namespace Twenty_Crm_Application.Common.Interfaces.Services.User;

public interface IUserService
{
    Task<ResponseDto<bool>> CreateUserAsync(CreateUserDto dto);
    Task<PaginatedList<ShowUserDto>> GetUserByPaginationAsync(GetWithPagination dto);
}
