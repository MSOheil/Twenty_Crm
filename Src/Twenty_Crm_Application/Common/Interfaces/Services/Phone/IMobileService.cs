namespace Twenty_Crm_Application.Common.Interfaces.Services.Phone;

public interface IMobileService
{
    Task<ResponseDto<bool>> CreateManyPhoneNumberAsync(IList<CreateTelephoneDto> phoneNumbers);
}
