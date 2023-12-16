namespace Twenty_Crm_Domain.Entities.Skill;

public class Skill : BaseEntity
{
    #region Properties
    public Guid UserRef { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    /// <summary>
    /// Certificate file stors base64
    /// </summary>
    public string? Base64CertificateFile { get; set; }
    #endregion

    #region Relations
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
    #endregion
}
