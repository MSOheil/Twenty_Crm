namespace Twenty_Crm_Application.Common.Services.Contact;

public class MobileService : IMobileService
{
    private readonly IMobileRepository mobileRepository;

    public MobileService(IMobileRepository mobileRepository)
    {
        this.mobileRepository = mobileRepository;
    }

    public async Task<ResponseDto<bool>> CreateManyPhoneNumberAsync(IList<CreateTelephoneDto> phoneNumbers)
    {
        try
        {
            var newPhoneNumbers = new List<Twenty_Crm_Domain.Entities.Telephone.Mobile>();
            for (int i = 0; i < phoneNumbers.Count; i++)
            {
                newPhoneNumbers.Add(new Twenty_Crm_Domain.Entities.Telephone.Mobile
                {
                    Title = phoneNumbers[i].Title,
                    PhoneNumber = phoneNumbers[i].PhoneNumber,
                });
            }
            await this.mobileRepository.AddManyAsync(newPhoneNumbers);
            await this.mobileRepository.SaveChangeAsync();

            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);


        }
        catch (Exception ex)
        {
            return default;
        }
    }
}
