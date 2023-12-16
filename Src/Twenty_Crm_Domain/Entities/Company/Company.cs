namespace Twenty_Crm_Domain.Entities.Company;

public class Company : BaseEntity
{
    #region Properties
    /// <summary>
    /// آی دی مدیر عامل
    /// </summary>
    public Guid? AdminId { get; set; }
    public string? Name { get; set; }
    public string? EconomicalNumber { get; set; }
    public string? NationalCode { get; set; }
    public string? InsertNumber { get; set; }
    public string? CompanyEmail { get; set; }
    public DateTime InsertDate { get; set; }
    public string? BrandName { get; set; }
    public string? CompanyImage { get; set; }
    public string? Description { get; set; }
    public Guid TitleRef { get; set; }
    #endregion

    #region Relations
    public Twenty_Crm_Domain.Entities.Title.Title? Title { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Address.Address>? Addresses { get; private set; }
    public IList<Telephone>? Telephones { get; private set; }
    public IList<Mobile>? Mobiles { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.User.User>? Users { get; private set; }
    public IList<CompanyToCustomer>? CompanyToCustomer { get; set; }
    public IList<CompanyToCustomer>? CustomerToCompany { get; set; }
    public IList<CompanyToUser>? CompanyToUser { get; set; }
    public IList<Twenty_Crm_Domain.Entities.WorkPlace.WorkPlace>? WorkPlaces { get; set; }
    public IList<Twenty_Crm_Domain.Entities.Website.Website>? Websites { get; private set; }
    #endregion
}
