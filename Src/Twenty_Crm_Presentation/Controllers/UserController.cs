using Microsoft.AspNetCore.Mvc;
using Twenty_Crm_Application.Common.Interfaces.Services.User;
using Twenty_Crm_Application.Common.Models.Dto;
using Twenty_Crm_Application.Common.Models.Dto.User;

namespace Twenty_Crm_Presentation.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService _userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpGet]
    public async Task<ActionResult<PaginatedList<ShowUserDto>>> GetUserListAsync([FromQuery] GetWithPagination dto)
    {
        return Ok(await _userService.GetUserByPaginationAsync(dto));
    }

    [HttpPost]
    public async Task<ActionResult> CreateEmployee(Guid id, [FromBody] CreateUserDto dto)
    {
        return Ok(await _userService.CreateUserAsync(dto));
    }
}
