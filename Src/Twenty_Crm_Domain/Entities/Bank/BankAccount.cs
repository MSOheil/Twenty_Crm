namespace Twenty_Crm_Domain.Entities.Bank;

public class BankAccount : BaseEntity
{
    #region Properties
    public string? AccountName { get; set; }
    public int AccountNumber { get; set; }
    public BankAccountMoneyType MoneyType { get; set; }
    public IranianBankAccountType AccountyType { get; set; }
    public Guid BranchRef { get; set; }
    public Guid CompanyRef { get; set; }
    #endregion

    #region Realations
    public Twenty_Crm_Domain.Entities.Company.Company? Company { get; private set; }
    public BankBranch? Branch { get; set; }
    #endregion

}
