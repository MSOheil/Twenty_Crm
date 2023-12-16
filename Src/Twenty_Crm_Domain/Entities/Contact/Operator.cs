namespace Twenty_Crm_Domain.Entities.Contact;

public class Operator : BaseEntity
{
    #region Properties
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? CompanyName { get; set; }
    #endregion

    #region Relation
    public IList<Mobile>? Mobiles { get; set; }
    public IList<Telephone>? Telephones { get; set; }
    #endregion
}
