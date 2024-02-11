namespace Twenty_Crm_Application.Common.Models.Dto.PhoneNumber;

public class ShowPhoneNumberDto
{
    public Guid Id { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Title { get; set; }
    public Guid? UserRef { get; set; }
}
