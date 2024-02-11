namespace Twenty_Crm_Domain.Entities.Region;

public class City : BaseEntity
{
    #region Properties
    public string? Name { get; set; }
    public string? TelCode { get; set; }
    public Guid CountyRef { get; set; }
    #endregion

    #region Relations
    public County? County { get; set; }
    public IList<Twenty_Crm_Domain.Entities.Address.Address>? Addresses { get; set; }
    public IList<Twenty_Crm_Domain.Entities.Telephone.Telephone>? Telephones { get; set; }
    #endregion
}
