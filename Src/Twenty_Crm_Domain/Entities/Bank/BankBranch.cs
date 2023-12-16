namespace Twenty_Crm_Domain.Entities.Bank;

public class BankBranch : BaseEntity
{
    #region Properties
    public Guid BankRef { get; set; }
    public string? Title { get; set; }
    public int BranchCode { get; set; }
    public string? Address { get; set; }
    public string? Description { get; set; }
    public string? Fax { get; set; }
    public string? PostalCode { get; set; }
    public Guid? CityRef { get; set; }
    #endregion

    #region Realations
    public City? City { get; set; }
    public IList<Telephone>? Telephones { get; set; }
    public Bank? Bank { get; set; }
    public IList<BankAccount>? BankAccounts { get; set; }
    #endregion

}
