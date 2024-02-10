namespace Twenty_Crm_Application.Common.Interfaces.Services.User;
public interface IUserService
{
    Task<ResponseDto<ShowUserDto>> CreateUserAsync(CreateUserDto dto);
    Task<PaginatedList<ShowUserDto>> GetUserByPaginationAsync(Guid companyRef, GetWithPagination dto);
    Task<ResponseDto<bool>> UpdateUserAsync(Guid userId, UpdateUserDto dto);
    Task<ResponseDto<bool>> DeleteUserAsync(Guid id, string userActionName);
    Task<ShowUserDto> GetByIdAsync(Guid id);
}
