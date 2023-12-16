namespace Twenty_Crm_Domain.Entities.Company;

public class CompanyToCustomer : BaseEntity
{
    public Guid CompanyRef { get; set; }
    public Guid CustomerRef { get; set; }



    public Company? Company { get; set; }
    public Company? Customer { get; set; }
}
