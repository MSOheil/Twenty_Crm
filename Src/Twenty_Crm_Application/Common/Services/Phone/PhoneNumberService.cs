namespace Twenty_Crm_Application.Common.Services.Phone;
public class PhoneNumberService : IPhoneNumberService
{
    private readonly IPhoneNumberRepo phoneNumberRepo;

    public PhoneNumberService(IPhoneNumberRepo phoneNumberRepo)
    {
        this.phoneNumberRepo = phoneNumberRepo;
    }

    public async Task<ResponseDto<bool>> CreateManyPhoneNumberDtoAsync(Guid userRef, IList<CreatePhoneNumberDto> dto)
    {
        try
        {
            var phoneNumbers = new List<Twenty_Crm_Domain.Entities.Telephone.Mobile>();
            for (int i = 0; i < dto.Count; i++)
            {
                phoneNumbers.Add(new Twenty_Crm_Domain.Entities.Telephone.Mobile
                {
                    Title = dto[i].Title,
                    PhoneNumber = dto[i].PhoneNumber,
                    UserRef = userRef,
                });
            }
            await this.phoneNumberRepo.AddRangeAsync(phoneNumbers);

            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);
        }
        catch (Exception ex)
        {
            return new ResponseDto<bool>("ثبت اطلاعات با خطا مواجه شد"
               , 500, false);
        }
    }

    public async Task<ResponseDto<bool>> CreatePhoneNumberDtoAsync(Guid userRef, CreatePhoneNumberDto dto)
    {
        try
        {
            var phoneNumber = new Twenty_Crm_Domain.Entities.Telephone.Mobile
            {
                UserRef = userRef,
                PhoneNumber = dto.PhoneNumber,
                Title = dto.Title,
            };
            await this.phoneNumberRepo.CreateAsync(phoneNumber, "");

            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);
        }
        catch (Exception ex)
        {


            return new ResponseDto<bool>("ثبت اطلاعات با خطا مواجه شد"
                , 500, false);
        }
    }
}
