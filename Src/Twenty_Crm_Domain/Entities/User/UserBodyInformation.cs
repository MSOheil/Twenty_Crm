namespace Twenty_Crm_Domain.Entities.User;

public class UserBodyInformation : BaseEntity
{
    #region Properties
    public Guid UserRef { get; set; }
    public string? Height { get; set; }
    public string? Weight { get; set; }
    #endregion

    #region Relations
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
    #endregion]
}
