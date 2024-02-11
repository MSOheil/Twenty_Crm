namespace Twenty_Crm_Application.Common.Models.Dto.Group;

public class CreateGroupDto
{
    public string? Name { get; set; }
    public Guid? CreatedCompany { get; set; }
    public string? Description { get; set; }
}
