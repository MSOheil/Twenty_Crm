namespace Twenty_Crm_Domain.Entities.Group;

public class UserToGroup : BaseEntity
{
    public Guid? UserRef { get; set; }
    public Guid? GropuRef { get; set; }



    public Twenty_Crm_Domain.Entities.Group.Group? Group { get; set; }
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
}
