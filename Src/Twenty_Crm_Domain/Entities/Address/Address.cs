namespace Twenty_Crm_Domain.Entities.Address;

public class Address : BaseEntity
{
    #region Properties
    public Guid UserRef { get; set; }
    public string? Title { get; set; }
    //public Guid CountryRef { get; private set; }
    //public Guid CountyRef { get; private set; }
    public Guid CityRef { get; set; }
    public string? RegionOrVilageName { get; set; }
    public string? Street { get; set; }
    public string? Alley { get; set; }
    public string? HouseNumber { get; set; }
    public string? PostalCode { get; set; }
    #endregion

    #region Relations
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
    public Country? Country { get; set; }
    public County? County { get; set; }
    public City? City { get; set; }
    public IList<Address>? Addresses { get; set; }
    #endregion
}
