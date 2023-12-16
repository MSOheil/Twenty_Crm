namespace Twenty_Crm_Domain.Entities.Company;

public class CompanyToUser : BaseEntity
{
    public Guid UserRef { get; set; }
    public Guid CompanyRef { get; set; }


    public Company? Company { get; set; }
    public Twenty_Crm_Domain.Entities.User.User? User { get; set; }
}
