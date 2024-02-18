namespace Twenty_Crm_Domain.Common;

public interface IBaseEntity
{
    /// <summary>
    /// Entity id,every entity has this id
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// The person that created this entity
    /// </summary>
    public string? CreatedBy { get; set; }
    /// <summary>
    /// Date of create entity
    /// </summary>
    public DateTime CreateDate { get; set; }
    ///// <summary>
    ///// Date of modified entity
    ///// </summary>
    //public DateTime ModifyDate { get; set; }
    ///// <summary>
    ///// Person that modified entity
    ///// </summary>
    //public string ModifiedBy { get; set; }
    public BaseEntityStatus BaseStatus { get; set; }
}
