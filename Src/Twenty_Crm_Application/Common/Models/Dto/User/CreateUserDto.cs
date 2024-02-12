namespace Twenty_Crm_Application.Common.Models.Dto.User;

public class CreateUserDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FatherName { get; set; }
    public GenderType Gender { get; set; }
    public string? NationalCode { get; set; }
    public DateTime? BirthDay { get; set; }
    public string? EmailAddress { get; set; }
    public bool Housing { get; set; }
    public string? Email { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpire { get; set; }
    public long? DateOfBirth { get; set; }
    public string? ProfileImage { get; set; }
    public Guid? ReligionRef { get; set; }
    public Guid? CompanyRef { get; set; }
    public IList<Guid>? GroupList { get; set; }
    public string? CompanyName { get; set; }
}
