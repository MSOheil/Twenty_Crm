

namespace Twenty_Crm_Presentation.Controllers;
public class AddressController : BaseController
{
    private readonly IAddressService addressService;

    public AddressController(IAddressService addressService)
    {
        this.addressService = addressService;
    }
    [HttpPost("{userRef}")]
    public async Task<ResponseDto<bool>> CreateMany(Guid userRef, [FromBody] IList<CreateAddressDto> dtos)
    {
        return await this.addressService.CreateManyAddressAsyn(userRef, dtos);
    }
    [HttpPut("{userRef}")]
    public async Task<ResponseDto<bool>> UpdateMany(Guid userRef, [FromBody] IList<UpdateAddressDto> dtos)
    { 
        return await this.addressService.UpsertManyAddressAsync(dtos, userRef);
    }
}
