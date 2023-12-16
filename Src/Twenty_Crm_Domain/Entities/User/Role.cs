namespace Twenty_Crm_Domain.Entities.User;

public class Role : BaseEntity
{
    public string? Name { get; set; }



    public List<UserToRole>? UserToRole { get; set; }
    public IList<RoleToClaims>? RoleToClaims { get; set; }
}
