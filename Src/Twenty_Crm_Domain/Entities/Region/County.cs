namespace Twenty_Crm_Domain.Entities.Region;

public class County : BaseEntity
{
    public string? Name { get; set; }
    public Guid StateRef { get; set; }
    public State? State { get; set; }

    #region Relations 
    public IList<City>? Cities { get; set; }
    public IList<Twenty_Crm_Domain.Entities.Company.Company>? Companies { get; set; }
    #endregion
}
