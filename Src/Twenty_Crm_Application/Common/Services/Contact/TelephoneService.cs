namespace Twenty_Crm_Application.Common.Services.Contact;

public class TelephoneService : ITelephoneService
{
    private readonly ITelephoneRepository telephoneRepository;

    public TelephoneService(ITelephoneRepository telephoneRepository)
    {
        this.telephoneRepository = telephoneRepository;
    }

    public async Task<ResponseDto<bool>> CreateManayTelephoneAsync(Guid userRef, IList<CreateTelephoneDto> dto)
    {
        try
        {
            var telephons = new List<Twenty_Crm_Domain.Entities.Telephone.Telephone>();
            for (int i = 0; i < dto.Count; i++)
            {
                telephons.Add(new Twenty_Crm_Domain.Entities.Telephone.Telephone
                {
                    PrePhoneNumber = dto[i].PrePhoneNumber,
                    TelephoneNumber = dto[i].PhoneNumber,
                    Title = dto[i].Title,
                    UserRef = userRef,
                });
            }
            await this.telephoneRepository.AddRangeAsync(telephons);

            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد",
                200, true);
        }
        catch (Exception ex)
        {

            return new ResponseDto<bool>("ثبت اطلاعات با خطا مواجه شد"
                , 500, false);
        }
    }
}
