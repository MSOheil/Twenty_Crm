namespace Twenty_Crm_Domain.Entities.Contact;

public class Telephone : BaseEntity
{
    #region Properties
    public Guid UserRef { get; set; }
    public string? Title { get; set; }
    public string? TelephoneNumber { get; set; }
    public Guid OperatorRef { get; set; }
    public Guid CityRef { get; set; }

    #endregion

    #region Relation
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
    public City? City { get; set; }
    public Operator? Operator { get; set; }
    #endregion
}
