namespace Twenty_Crm_Application.Common.Models.Dto.Address;

public class CreateAddressDto
{
    public string? Title { get; set; }
    //public Guid CountryRef { get; private set; }
    //public Guid CountyRef { get; private set; }
    public Guid CityRef { get; set; }
    public string? RegionOrVilageName { get; set; }
    public string? Street { get; set; }
    public string? Alley { get; set; }
    public string? HouseNumber { get; set; }
    public string? PostalCode { get; set; }
}
