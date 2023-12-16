namespace Twenty_Crm_Domain.Entities.InternationalCertificate;

public class InternationalCertificate : BaseEntity
{
    #region Properties
    public Guid UserRef { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? FilePath { get; set; }
    #endregion

    #region Relations
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }

    #endregion
}
