namespace Twenty_Crm_Domain.Entities.Marriage;

public class Marriage : BaseEntity
{
    #region Properties
    public Guid UserRef { get; set; }
    public DateTime DateOfMarriage { get; set; }
    public DateTime DateOfDivorce { get; set; }
    public byte NumberOfChildren { get; set; }
    public string? SpouseName { get; set; }
    #endregion

    #region Realations
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
    #endregion
}
