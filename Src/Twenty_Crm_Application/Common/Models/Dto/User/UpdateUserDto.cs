namespace Twenty_Crm_Application.Common.Models.Dto.User;

public class UpdateUserDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FatherName { get; set; }
    public GenderType Gender { get; set; }
    public IList<Guid>? GroupList { get; set; }
    public string? CompanyName { get; set; }
}
