using Twenty_Crm_Domain.Entities.Contact;

namespace Twenty_Crm_Domain.Entities.User;

public class User : BaseEntity
{
    #region Properties
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FatherName { get; set; }
    public GenderType Gender { get; set; }
    public string? NationalCode { get; set; }
    public DateTime BirthDay { get; set; }
    public string? EmailAddress { get; set; }
    public bool Housing { get; set; }
    public string? Password { get; set; }
    public string? Email { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpire { get; set; }
    public long? DateOfBirth { get; set; }
    public Guid? PayerId { get; set; }
    public string? ProfileImage { get; set; }
    public string? PersonalCode { get; set; }
    //public Guid? GroupLeaderRef { get; set; }
    //public Guid? PassportRef { get; set; }
    public Guid? ReligionRef { get; set; }
    #endregion

    #region Realation
    public Twenty_Crm_Domain.Entities.Company.Company? Company { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Company.CompanyToUser>? CompanyToUsers { get; set; }
    public IList<UserToRole>? UserToRole { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Skill.Skill>? Skills { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Post.Post>? Posts { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.WorkPlace.WorkPlace>? WorkPlaces { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Website.Website>? Websites { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Address.Address>? Addresses { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Bank.Bank>? Banks { get; private set; }
    public IList<BankAccount>? BankAccounts { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Group.GroupLeader>? GroupLeaders { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.InternationalCertificate.InternationalCertificate>? InternationalCertificates { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.License.License>? Licenses { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Marriage.Marriage>? Marriages { get; private set; }
    public IList<Mobile>? Mobiles { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Passport.Passport>? Passports { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.User.UserBodyInformation>? UserBodyInformations { get; private set; }
    public Twenty_Crm_Domain.Entities.Religion.Religion? Religions { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Group.SubGroup>? SubGroups { get; set; }
    public IList<Telephone>? Telephones { get; set; }
    //public IList<CompanyToUser>? CompanyToUsers { get; set; }

    #endregion
}
