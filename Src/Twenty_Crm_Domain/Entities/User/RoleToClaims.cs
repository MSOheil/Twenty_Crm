namespace Twenty_Crm_Domain.Entities.User;

public class RoleToClaims : BaseEntity
{
    public Guid ClaimRef { get; set; }
    public Guid RoleRef { get; set; }


    // Relations
    public Claim? Claim { get; set; }
    public Role? Role { get; set; }
}
