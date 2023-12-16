namespace Twenty_Crm_Domain.Entities.Group;

public class SubGroup : BaseEntity
{
    #region Properties
    //public Guid UserRef { get; private set; }
    public Guid GroupLeaderRef { get; set; }
    #endregion

    #region Relations
    public IList<Twenty_Crm_Domain.Entities.User.User>? User { get; set; }
    public GroupLeader? GroupLeader { get; set; }
    #endregion
}
