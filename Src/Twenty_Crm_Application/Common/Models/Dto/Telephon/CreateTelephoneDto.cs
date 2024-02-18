namespace Twenty_Crm_Application.Common.Models.Dto.Telephon;

public class CreateTelephoneDto
{
    public string? PhoneNumber { get; set; }
    public string? PrePhoneNumber { get; set; }
    public string? Title { get; set; }
    public Guid? StateRef { get; set; }
}
