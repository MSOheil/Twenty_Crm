namespace Twenty_Crm_Application.Common.Services.Address;

public class AddressService : IAddressService
{
    private readonly IAddressRepository addressRepository;
    private readonly ILogger<AddressService> logger;
    public AddressService(ILogger<AddressService> logger, IAddressRepository addressRepository)
    {
        this.logger = logger;
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

    public async Task<ResponseDto<bool>> UpsertManyAddressAsync(IList<UpdateAddressDto> dtos, Guid userRef)
    {
        try
        {

            var ids = this.GetIds(dtos);
            // Delete addreses
            var deleteAddress = await this.addressRepository.GetAll()
                .Where(s => s.UserRef.Equals(userRef) && !ids.Contains(s.Id)).ToListAsync();
            await this.addressRepository.DeleteManyAsync(deleteAddress, "");
            // Update LastAddress
            var updateAddress = await this.addressRepository.GetAll()
                .Where(f => f.UserRef.Equals(userRef) && ids.Contains(f.Id)).AsTracking().ToListAsync();
            this.UpdateAddress(dtos, updateAddress);
            // CreateNewAddress
            var newAddress = dtos.Where(s => s.Id == null || s.Id.Equals(Guid.Empty)).ToList();
            var newAddressList = this.ConvertUpdateAddressToCreateAddressDtos(newAddress);
            await this.CreateManyAddressAsyn(userRef, newAddressList);
            await this.addressRepository.SaveChangeAsync();
            return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                , 200, true);



        }
        catch (Exception ex)
        {
            this.logger.LogError(
                $"we have error in line 55 " +
                $"class [AddressService]" +
                $" with error message : {ex.Message}");


            return new ResponseDto<bool>("ثبت اطلاعات با خطا مواجه شد"
                , 500, false);
        }
    }
    private IList<CreateAddressDto> ConvertUpdateAddressToCreateAddressDtos(IList<UpdateAddressDto> dtos)
    {
        var newCreateAddress = new List<CreateAddressDto>();
        for (int i = 0; i < dtos.Count; i++)
        {
            newCreateAddress.Add(new CreateAddressDto
            {
                Alley = dtos[i].Alley,
                CityRef = dtos[i].CityRef,
                HouseNumber = dtos[i].HouseNumber,
                PostalCode = dtos[i].PostalCode,
                RegionOrVilageName = dtos[i].RegionOrVilageName,
                Street = dtos[i].Street,
                Title = dtos[i].Title,
            });

        }
        return newCreateAddress;
    }
    private void UpdateAddress(IList<UpdateAddressDto> newaddress, IList<Twenty_Crm_Domain.Entities.Address.Address> lastAddressList)
    {
        for (int i = 0; i < lastAddressList.Count; i++)
        {
            var newAddress = newaddress.Where(d => d.Id.Equals(lastAddressList[i].Id)).FirstOrDefault();
            if (newaddress is not null)
            {
                lastAddressList[i].SBCityRef = newAddress.CityRef;
                lastAddressList[i].Alley = newAddress.Alley;
                lastAddressList[i].HouseNumber = newAddress.HouseNumber;
                lastAddressList[i].PostalCode = newAddress.PostalCode;
                lastAddressList[i].Street = newAddress.Street;
                lastAddressList[i].Title = newAddress.Title;
                lastAddressList[i].RegionOrVilageName = newAddress.RegionOrVilageName;
            }
        }
    }
    private IList<Guid> GetIds(dynamic dtos)
    {
        var ids = new List<Guid>();
        for (int i = 0; i < dtos.Count; i++)
        {
            ids.Add(dtos[i].Id);
        }
        return ids;

    }
}
