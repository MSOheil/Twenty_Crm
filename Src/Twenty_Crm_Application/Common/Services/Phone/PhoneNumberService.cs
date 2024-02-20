using Twenty_Crm_Domain.Entities.Telephone;

namespace Twenty_Crm_Application.Common.Services.Phone;
public class PhoneNumberService : IPhoneNumberService
{
    private readonly IPhoneNumberRepo phoneNumberRepo;
    private readonly ILogger<PhoneNumberService> logger;
    public PhoneNumberService(IPhoneNumberRepo phoneNumberRepo, ILogger<PhoneNumberService> logger)
    {
        this.logger = logger;
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

    public async Task<ResponseDto<bool>> UpsertPhoneNumbersAsync(IList<UpdatePhoneNumberDto> phoneNumbers, Guid userRef)
    {
        try
        {
            var ids = this.GetIds(phoneNumbers);
            // DeletedPhoneNumbers
            var deletedPhoneNumbers = await this.phoneNumberRepo.GetAll()
                .Where(d => d.UserRef.Equals(userRef) && !ids.Contains(d.Id)).ToListAsync();
            await this.phoneNumberRepo.DeleteManyAsync(deletedPhoneNumbers, "");
            // UpdatePhoneNumbers
            var updateNewPhoneNumbers = await this.phoneNumberRepo.GetAll()
                .Where(s => s.UserRef.Equals(userRef) && ids.Contains(s.Id)).ToListAsync();
            this.UpdatePhoneNumbers(updateNewPhoneNumbers, phoneNumbers);
            // CreateNewPhoneNumbers
            var newMobiles = phoneNumbers.Where(s => s.Id == null || s.Id.Equals(Guid.Empty)).ToList();
            var newPhoneNumbers = this.ConvertUpdatePhoneNumbertoCreatePhoneNumber(newMobiles);
            var responseResult = this.CreateManyPhoneNumberDtoAsync(userRef, newPhoneNumbers);

            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);
        }
        catch (Exception ex)
        {
            this.logger.LogError($"" +
                $"we have error in line 71 with error message : {ex.Message}");
            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);
        }
    }
    private IList<CreatePhoneNumberDto> ConvertUpdatePhoneNumbertoCreatePhoneNumber(IList<UpdatePhoneNumberDto> dtos)
    {
        var createPhoneNumber = new List<CreatePhoneNumberDto>();
        for (int i = 0; i < dtos.Count; i++)
        {
            createPhoneNumber.Add(new CreatePhoneNumberDto
            {
                PhoneNumber = dtos[i].PhoneNumber,
                Title = dtos[i].Title,
            });
        }
        return createPhoneNumber;
    }
    private void UpdatePhoneNumbers(IList<Mobile> lastMobiles, IList<UpdatePhoneNumberDto> updateNewMobiles)
    {
        for (int i = 0; i < lastMobiles.Count; i++)
        {
            var newMobile = updateNewMobiles.Where(d => d.Id.Equals(lastMobiles[i].Id)).FirstOrDefault();
            if (newMobile is not null)
            {
                lastMobiles[i].PhoneNumber = newMobile.PhoneNumber;
                lastMobiles[i].Title = newMobile.Title;
            }
        }
    }
    private IList<Guid> GetIds(IList<UpdatePhoneNumberDto> dtos)
    {
        var newIds = new List<Guid>();
        for (int i = 0; i < dtos.Count; i++)
        {
            if (dtos[i].Id != null && dtos[i].Id != Guid.Empty)
            {
                newIds.Add(dtos[i].Id ?? Guid.Empty);
            }
        }
        return newIds;
    }
}
