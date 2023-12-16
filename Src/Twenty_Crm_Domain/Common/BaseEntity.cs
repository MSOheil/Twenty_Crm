namespace Twenty_Crm_Domain.Common;

public class BaseEntity : IBaseEntity, IEquatable<BaseEntity>
{
    #region Properties
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
    public DateTime CreateDate { get; set; } = DateTime.Now;
    /// <summary>
    /// Date of modified entity
    /// </summary>
    public DateTime ModifyDate { get; set; } = DateTime.Now;
    /// <summary>
    /// Person that modified entity
    /// </summary>
    public string? ModifiedBy { get; set; }
    /// <summary>
    /// The Status of entity
    /// </summary>
    public BaseEntityStatus BaseStatus { get; set; } = BaseEntityStatus.Active;
    #endregion
    #region Constructure
    public BaseEntity()
    {
        if (Id == Guid.Empty)
            Id = Guid.NewGuid();
    }
    #endregion
    #region Methods
    public static bool operator ==(BaseEntity firstEntity, BaseEntity secondEntity)
    {
        return firstEntity is not null && secondEntity is not null && firstEntity.Equals(secondEntity);
    }
    public static bool operator !=(BaseEntity firstEntity, BaseEntity secondEntity)
    {
        return !(firstEntity == secondEntity);
    }
    public override bool Equals(object? obj)
    {
        if (obj is null)
        {
            return false;
        }
        if (obj.GetType() != GetType())
        {
            return false;
        }
        if (obj is not BaseEntity entity)
        {
            return false;
        }

        return entity.Id == Id;
    }
    public bool Equals(BaseEntity? other)
    {
        if (other is null)
        {
            return false;
        }
        if (other.GetType() != GetType())
        {
            return false;
        }
        return other.Id == Id;
    }
    #endregion
}
