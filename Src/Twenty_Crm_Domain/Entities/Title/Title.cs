namespace Twenty_Crm_Domain.Entities.Title;

public class Title : BaseEntity
{
    #region Propeties
    /// <summary>
    /// like msoheil engeneer
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// If it's false current user is real
    /// </summary>
    public bool IsLegal { get; set; }
    public Guid CompanyRef { get; set; }
    #endregion

    #region Relations
    public Twenty_Crm_Domain.Entities.Company.Company? Company { get; set; }
    #endregion
}
