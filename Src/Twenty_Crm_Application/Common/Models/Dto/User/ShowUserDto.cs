namespace Twenty_Crm_Application.Common.Models.Dto.User;

public class ShowUserDto
{
    public Guid? Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FatherName { get; set; }
    public GenderType Gender { get; set; }
    public string? NationalCode { get; set; }
    public DateTime BirthDay { get; set; }
    public string? EmailAddress { get; set; }
    public bool Housing { get; set; }
    public string? Password { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpire { get; set; }
    public long? DateOfBirth { get; set; }
    public Guid? PayerId { get; set; }
    public string? ProfileImage { get; set; }
    public string? PersonalCode { get; set; }
    public Guid? ReligionRef { get; set; }
}
