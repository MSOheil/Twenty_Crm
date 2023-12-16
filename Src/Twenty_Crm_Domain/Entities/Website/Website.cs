namespace Twenty_Crm_Domain.Entities.Website;

public class Website : BaseEntity
{
    #region Properties
    public Guid UserRef { get; set; }
    public Guid CompanyRef { get; set; }
    public string? Name { get; set; }
    public string? Url { get; set; }
    #endregion

    #region Realations
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
    public Twenty_Crm_Domain.Entities.Company.Company? Company { get; set; }
    #endregion
}
