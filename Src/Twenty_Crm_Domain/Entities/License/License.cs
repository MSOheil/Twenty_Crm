namespace Twenty_Crm_Domain.Entities.License;

public class License : BaseEntity
{
    #region Properties
    public Guid UserRef { get; set; }
    public string? Password { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    #endregion

    #region Realtion
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
    #endregion
}
