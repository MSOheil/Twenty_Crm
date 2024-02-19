using Twenty_Crm_Application.Common.Models.Dto.PhoneNumber;

namespace Twenty_Crm_Presentation.Controllers;
public class PhoneNumberController : BaseController
{
    private readonly IPhoneNumberService phoneNumberService;

    public PhoneNumberController(IPhoneNumberService phoneNumberService)
    {
        this.phoneNumberService = phoneNumberService;
    }


    [HttpPost("{userRef}")]
    public async Task<ResponseDto<bool>> CreateMany(Guid userRef, [FromBody] IList<Twenty_Crm_Application.Common.Models.Dto.PhoneNumber.CreatePhoneNumberDto> dto)
    {
        return await
               this.phoneNumberService.CreateManyPhoneNumberDtoAsync(userRef, dto);
    }
    [HttpPut("{userRef}")]
    public async Task<ResponseDto<bool>> UpdateMany(Guid userRef, [FromBody] IList<UpdatePhoneNumberDto> dtos)
    {
        return await this.phoneNumberService.UpsertPhoneNumbersAsync(dtos, userRef);
    }
}

