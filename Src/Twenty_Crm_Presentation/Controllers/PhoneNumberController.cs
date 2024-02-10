using Twenty_Crm_Application.Common.Models.Dto.PhoneNumber;

namespace Twenty_Crm_Presentation.Controllers;
public class PhoneNumberController : BaseController
{
    private readonly IPhoneNumberService phoneNumberService;

    public PhoneNumberController(IPhoneNumberService phoneNumberService)
    {
        this.phoneNumberService = phoneNumberService;
    }


    [HttpPost]
    public async Task<ResponseDto<ShowPhoneNumberDto>> Create([FromBody] dynamic dto)
    {
        return default;
        //return await this.phoneNumberService.cre

    }
}

