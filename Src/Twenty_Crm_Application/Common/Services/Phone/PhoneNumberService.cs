namespace Twenty_Crm_Application.Common.Services.Phone;
public class PhoneNumberService : IPhoneNumberService
{
    private readonly IPhoneNumberRepo phoneNumberRepo;

    public PhoneNumberService(IPhoneNumberRepo phoneNumberRepo)
    {
        this.phoneNumberRepo = phoneNumberRepo;
    }

    public Task<ResponseDto<ShowPhoneNumberDto>> CreatePhoneNumberDtoAsync(CreatePhoneNumberDto dto)
    {
        return default;
        try
        {

        }
        catch (Exception ex)
        {

            throw;
        }
    }
}
