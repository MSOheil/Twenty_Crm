namespace Twenty_Crm_Application.Common.Models.Dto.Website;

public class ShowWebsiteDto
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? Url { get; set; }
    public Guid? UserRef { get; set; }
    public Guid? CompanyRef { get; set; }
}
