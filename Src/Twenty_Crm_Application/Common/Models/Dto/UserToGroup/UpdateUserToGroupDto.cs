namespace Twenty_Crm_Application.Common.Models.Dto.UserToGroup;

public class UpdateUserToGroupDto
{
    public Guid? Id { get; set; }
    public Guid? UserRef { get; set; }
    public Guid? GroupRef { get; set; }
}
