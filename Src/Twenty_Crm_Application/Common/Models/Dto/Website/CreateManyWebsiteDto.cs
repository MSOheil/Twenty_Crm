namespace Twenty_Crm_Application.Common.Models.Dto.Website;

public class CreateManyWebsiteDto
{
    public Guid UserRef { get; set; }
    public string? Name { get; set; }
    public string? Url { get; set; }
}
