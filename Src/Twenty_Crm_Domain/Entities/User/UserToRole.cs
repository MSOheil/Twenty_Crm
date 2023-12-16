namespace Twenty_Crm_Domain.Entities.User;

public class UserToRole : BaseEntity
{
    public Guid? UserRef { get; set; }
    public Guid? RoleRef { get; set; }


    // Relations
    public User? User { get; set; }
    public Role? Role { get; set; }
}
