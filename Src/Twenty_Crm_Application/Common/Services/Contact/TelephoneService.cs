namespace Twenty_Crm_Application.Common.Services.Contact;

public class TelephoneService : ITelephoneService
{
    private readonly ITelephoneRepository telephoneRepository;
    private readonly ILogger<TelephoneService> logger;
    public TelephoneService(ILogger<TelephoneService> logger, ITelephoneRepository telephoneRepository)
    {
        this.telephoneRepository = telephoneRepository;
        this.logger = logger;
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

    public async Task<ResponseDto<bool>> CreateTelephoneAsync(Guid userRef, CreateTelephoneDto dto)
    {
        try
        {
            var telephone = new Twenty_Crm_Domain.Entities.Telephone.Telephone
            {
                UserRef = userRef,
                PrePhoneNumber = dto.PrePhoneNumber,
                Title = dto.Title,
                TelephoneNumber = dto.PhoneNumber,
            };

            await this.telephoneRepository.CreateAsync(telephone, "");

            return new ResponseDto<bool>("ثبت اطلاعات موفقیت انجام شد"
                , 200, true);
        }
        catch (Exception ex)
        {
            return new ResponseDto<bool>("ثبت اطلاعات با خطا انجام شد"
                , 500, false);
        }
    }

    public async Task<ResponseDto<bool>> UpsertManyTelephonesAsync(IList<UpdateTelephoneDto> dto, Guid userRef)
    {
        try
        {
            var ids = this.TakeIds(dto);
            //Delete Telephones
            var deletedTelephones = await this.telephoneRepository.GetAll()
                 .Where(s => s.UserRef.Equals(userRef) && !ids.Contains(s.Id)).ToListAsync();
            await this.telephoneRepository.DeleteManyAsync(deletedTelephones, "");
            // UpdateTelephones
            var updateTelephones = await this.telephoneRepository.GetAll()
                .Where(s => s.UserRef.Equals(userRef) && ids.Contains(s.Id)).AsTracking().ToListAsync();
            this.UpdateTelephones(dto, updateTelephones);
            await this.telephoneRepository.SaveChangeAsync();
            // CreateNewTelephons
            var newTelephones = this.ConvertUpdateTelephonesToCreate(dto);
            var telephons = await this.CreateManayTelephoneAsync(userRef, newTelephones);
            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);
        }

        catch (Exception ex)
        {
            this.logger.LogError($"" +
                $"we have error " +
                $" in line 75 with error message : {ex.Message}");
            return new ResponseDto<bool>("ثبت اطلاعات با خطا مواجه شد"
                , 500, false);
        }
    }
    private IList<CreateTelephoneDto> ConvertUpdateTelephonesToCreate(IList<UpdateTelephoneDto> dto)
    {
        var newList = new List<CreateTelephoneDto>();
        for (int i = 0; i < dto.Count; i++)
        {
            if (dto[i].Id == null || dto[i].Id == Guid.Empty)
            {
                newList.Add(new CreateTelephoneDto
                {
                    PrePhoneNumber = dto[i].PrePhoneNumber,
                    PhoneNumber = dto[i].PhoneNumber,
                    StateRef = dto[i].StateRef,
                    Title = dto[i].Title,
                });
            }
        }
        return newList;
    }
    private void UpdateTelephones(IList<UpdateTelephoneDto> newTelephones, IList<Twenty_Crm_Domain.Entities.Telephone.Telephone> lastTelephones)
    {
        for (int i = 0; i < lastTelephones.Count; i++)
        {
            var newTelephons = newTelephones.Where(s => s.Id.Equals(lastTelephones[i].Id)).FirstOrDefault();
            if (newTelephones is not null)
            {
                lastTelephones[i].Title = newTelephons.Title;
                lastTelephones[i].PrePhoneNumber = newTelephons.PrePhoneNumber;
                lastTelephones[i].TelephoneNumber = newTelephons.PhoneNumber;
                lastTelephones[i].SBStateRef = newTelephons.StateRef;
            }
        }
    }
    private List<Guid> TakeIds(dynamic dtos)
    {
        var ids = new List<Guid>();
        for (int i = 0; i < dtos.Count; i++)
        {
            if (dtos[i].Id != null &&
                dtos[i].Id != Guid.Empty)
            {
                ids.Add(dtos[i].Id);
            }
        }
        return ids;
    }
}
