namespace Twenty_Crm_Application.Common.Models.Dto.Group;

public class ShowGroupDto
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int UserCount { get; set; }
}
