namespace Twenty_Crm_Application.Common.Interfaces.Services.Phone;
public interface IPhoneNumberService
{
    Task<ResponseDto<bool>> CreateManyPhoneNumberDtoAsync(Guid userRef, IList<CreatePhoneNumberDto> dto);
    Task<ResponseDto<bool>> CreatePhoneNumberDtoAsync(Guid userRef, CreatePhoneNumberDto dto);
    Task<ResponseDto<bool>> UpsertPhoneNumbersAsync(IList<UpdatePhoneNumberDto> phoneNumbers, Guid userRef);
}
