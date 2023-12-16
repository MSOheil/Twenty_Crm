namespace Twenty_Crm_Domain.Entities.User;

public class Claim : BaseEntity
{
    public string? Name { get; set; }

    public IList<RoleToClaims>? RoleToClaims { get; set; }
}
