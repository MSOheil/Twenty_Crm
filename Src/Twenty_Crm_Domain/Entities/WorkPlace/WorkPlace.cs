namespace Twenty_Crm_Domain.Entities.WorkPlace;

public class WorkPlace : BaseEntity
{
    #region Properties

    public string? Name { get; set; }
    /// <summary>
    /// The company that user works on it
    /// </summary>
    public Guid CompanyRef { get; set; }
    #endregion

    #region Realtions
    public IList<Twenty_Crm_Domain.Entities.User.User>? User { get; set; }
    public Twenty_Crm_Domain.Entities.Company.Company? Company { get; set; }
    #endregion
}
