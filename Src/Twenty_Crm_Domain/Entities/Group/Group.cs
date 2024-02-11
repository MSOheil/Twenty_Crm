namespace Twenty_Crm_Domain.Entities.Group;

public class Group : BaseEntity
{
    #region Properties
    public string? Name { get; set; }
    public string? Description { get; set; }
    public Guid? CreatedCompany { get; set; }
    #endregion

    #region Realations
    public IList<Twenty_Crm_Domain.Entities.Group.UserToGroup>? UserToGroups { get; set; }
    public IList<SubGroup>? SubGroups { get; set; }
    #endregion
}
