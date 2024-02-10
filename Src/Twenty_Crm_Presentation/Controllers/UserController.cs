[ApiController]
[Route("[controller]/[action]")]
public class UserController : BaseController
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService userService;
    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;
        this.userService = userService;
    }
    [HttpGet("{companyRef}")]
    public async Task<PaginatedList<ShowUserDto>> GetList(Guid companyRef, [FromQuery] GetWithPagination dto)
    {
        return await this.userService.GetUserByPaginationAsync(companyRef, dto);
    }

    [HttpPost]
    public async Task<ResponseDto<ShowUserDto>> Create([FromBody] CreateUserDto dto)
    {
        return await this.userService.CreateUserAsync(dto);
    }
    [HttpPut("{id}")]
    public async Task<ResponseDto<bool>> Update(Guid id, [FromBody] UpdateUserDto dto)
    {
        return await this.userService.UpdateUserAsync(id, dto);
    }
    [HttpDelete("{id}")]
    public async Task<ResponseDto<bool>> Delete(Guid id, string userPhone)
    {
        return await this.userService.DeleteUserAsync(id, userPhone);
    }

    [HttpGet("{id}")]
    public async Task<ShowUserDto> GetById(Guid id)
    {
        return await this.userService.GetByIdAsync(id);
    }


}
