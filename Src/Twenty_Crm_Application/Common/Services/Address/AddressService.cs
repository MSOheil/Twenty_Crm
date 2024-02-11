namespace Twenty_Crm_Application.Common.Services.Address;

public class AddressService : IAddressService
{
    private readonly IAddressRepository addressRepository;

    public AddressService(IAddressRepository addressRepository)
    {
        this.addressRepository = addressRepository;
    }

    public async Task<ResponseDto<bool>> CreateManyAddressAsyn(Guid userRef, IList<CreateAddressDto> dtos)
    {
        try
        {
            var addressList = new List<Twenty_Crm_Domain.Entities.Address.Address>();
            for (int i = 0; i < dtos.Count; i++)
            {
                addressList.Add(new Twenty_Crm_Domain.Entities.Address.Address
                {
                    UserRef = userRef,
                    SBCityRef = dtos[i].CityRef,
                    Alley = dtos[i].Alley,
                    HouseNumber = dtos[i].HouseNumber,
                    Street = dtos[i].Street,
                    RegionOrVilageName = dtos[i].RegionOrVilageName,
                    Title = dtos[i].Title,
                    PostalCode = dtos[i].PostalCode,
                    CityRef = null,
                });
            }
            await this.addressRepository.AddRangeAsync(addressList);

            return
                new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);
        }
        catch (Exception ex)
        {
            return new ResponseDto<bool>("ثبت اطلاعات با خطا مواجه شد"
    , 500, false);
        }
    }
}
