namespace Twenty_Crm_Application.Common.Interfaces.Services.Contact;
public interface ITelephoneService
{
    Task<ResponseDto<bool>> CreateManayTelephoneAsync(Guid userRef, IList<CreateTelephoneDto> dto);
    Task<ResponseDto<bool>> CreateTelephoneAsync(Guid userRef, CreateTelephoneDto dto);
    Task<ResponseDto<bool>> UpsertManyTelephonesAsync(IList<UpdateTelephoneDto> dto, Guid userRef);
}
