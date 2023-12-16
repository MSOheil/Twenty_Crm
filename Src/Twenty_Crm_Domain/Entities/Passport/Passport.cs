namespace Twenty_Crm_Domain.Entities.Passport;

public class Passport : BaseEntity
{
    #region Peroperties
    /// <summary>
    /// Expier date for passport
    /// </summary>
    public DateTime ExpierDate { get; set; }
    /// <summary>
    /// Date of start passport time
    /// </summary>
    public DateTime StartDate { get; set; }
    public Guid UserRef { get; set; }
    #endregion

    #region Realations
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
    #endregion
}
