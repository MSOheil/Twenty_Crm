namespace Twenty_Crm_Domain.Entities.Telephone;

public class Mobile : BaseEntity
{
    #region Properties
    public Guid UserRef { get; set; }
    public string? Title { get; set; }
    public string? PhoneNumber { get; set; }
    public Guid OperatorRef { get; set; }
    #endregion

    #region Relations
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
    public Operator? Operator { get; set; }
    #endregion
}
