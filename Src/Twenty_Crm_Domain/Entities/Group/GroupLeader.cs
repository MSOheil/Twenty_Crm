namespace Twenty_Crm_Domain.Entities.Group;

public class GroupLeader : BaseEntity
{
    #region Properties
    public Guid UserRef { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    #endregion

    #region Realations
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
    public IList<SubGroup>? SubGroups { get; set; }
    #endregion
}
