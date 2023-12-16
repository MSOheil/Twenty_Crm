namespace Twenty_Crm_Domain.Entities.Post;

public class Post : BaseEntity
{
    #region Properties
    public string? Name { get; set; }
    public string? Description { get; set; }

    #endregion

    #region Relations
    public IList<Twenty_Crm_Domain.Entities.User.User>? Users { get; set; }
    #endregion
}
