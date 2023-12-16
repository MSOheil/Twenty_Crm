namespace Twenty_Crm_Domain.Entities.Region;

public class State : BaseEntity
{
    public string? Name { get; set; }
    public Guid? CountryRef { get; set; }



    public Country? Country { get; set; }
    public IList<County>? Counties { get; set; }
}
