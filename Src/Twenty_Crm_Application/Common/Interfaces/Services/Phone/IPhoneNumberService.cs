namespace Twenty_Crm_Application.Common.Interfaces.Services.Phone;
public interface IPhoneNumberService
{
    Task<ResponseDto<ShowPhoneNumberDto>> CreatePhoneNumberDtoAsync(CreatePhoneNumberDto dto);
}
