namespace Twenty_Crm_Domain.Entities.Bank;

public class Bank : BaseEntity
{
    #region Properties
    public string? Name { get; set; }
    #endregion

    #region Relations
    public IList<BankBranch>? BankBranches { get; set; }
    #endregion
}
