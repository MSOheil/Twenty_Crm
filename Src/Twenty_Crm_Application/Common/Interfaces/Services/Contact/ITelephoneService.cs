namespace Twenty_Crm_Application.Common.Interfaces.Services.Contact;
public interface ITelephoneService
{
    Task<ResponseDto<bool>> CreateManayTelephoneAsync(Guid userRef, IList<CreateTelephoneDto> dto);
}
