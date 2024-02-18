namespace Twenty_Crm_Application.Common.Models.Dto.Telephon;

public class ShowTelephonesDto
{
    public Guid Id { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Title { get; set; }
    public string? PrePhoneNumber { get; set; }
    public Guid? StateRef { get; set; }
    public Guid? UserRef { get; set; }
}
