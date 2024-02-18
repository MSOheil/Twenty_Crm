public class UserController : BaseController
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService userService;
    private readonly IUserRepository userRepository;

    public UserController(ILogger<UserController> logger, IUserService userService, IUserRepository userRepository)
    {
        _logger = logger;
        this.userService = userService;
        this.userRepository = userRepository;
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
    [HttpDelete("{id}/{userPersonalCode}")]
    public async Task<ResponseDto<bool>> Delete(Guid id, string userPersonalCode)
    {
        return await this.userService.DeleteUserAsync(id, userPersonalCode);
    }

    [HttpGet("{id}")]
    public async Task<ShowUserDto> GetById(Guid id)
    {
        return await this.userService.GetByIdAsync(id);
    }
    [HttpDelete]
    public async Task DeleteAll()
    {
        var allEntities = await this.userRepository.GetAll().ToListAsync();
        await this.userRepository.DeleteManyAsync(allEntities, "");

    }

}
