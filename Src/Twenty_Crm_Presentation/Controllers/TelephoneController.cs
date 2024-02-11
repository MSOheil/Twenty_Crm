namespace Twenty_Crm_Presentation.Controllers;
public class TelephoneController : BaseController
{
    private readonly ITelephoneService telephoneService;

    public TelephoneController(ITelephoneService telephoneService)
    {
        this.telephoneService = telephoneService;
    }
    [HttpPost("{userRef}")]
    public async Task<ResponseDto<bool>> CreateMany(Guid userRef, [FromBody] IList<CreateTelephoneDto> dto)
    {
        return await
               this.telephoneService.CreateManayTelephoneAsync(userRef, dto);
    }
}
