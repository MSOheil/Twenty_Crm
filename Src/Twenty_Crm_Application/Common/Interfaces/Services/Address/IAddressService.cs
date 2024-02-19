

namespace Twenty_Crm_Application.Common.Interfaces.Services.Address;

public interface IAddressService
{
    Task<ResponseDto<bool>> CreateManyAddressAsyn(Guid userRef, IList<CreateAddressDto> dtos);
    Task<ResponseDto<bool>> UpsertManyAddressAsync(IList<UpdateAddressDto> dtos, Guid userRef);
}
