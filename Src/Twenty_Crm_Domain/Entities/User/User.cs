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
    public Guid? CreatedCompany { get; set; }
    /// <summary>
    /// رمز یا کد پرسونلی که به شکل hash ذخیره میشود
    /// </summary>
    public string? HashedPassword { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpire { get; set; }
    public long? DateOfBirth { get; set; }
    public Guid? PayerId { get; set; }
    public string? ProfileImage { get; set; }
    public Guid? CompanyCreated { get; set; }
    //public Guid? GroupLeaderRef { get; set; }
    //public Guid? PassportRef { get; set; }
    public Guid? ReligionRef { get; set; }
    public string? CompanyName { get; set; }
    #endregion

    #region Realation 
    public IList<UserToRole>? UserToRole { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Skill.Skill>? Skills { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Post.Post>? Posts { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.WorkPlace.WorkPlace>? WorkPlaces { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Website.Website>? Websites { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Address.Address>? Addresses { get; private set; }
    public IList<BankAccount>? BankAccounts { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Group.Group>? GroupLeaders { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.InternationalCertificate.InternationalCertificate>? InternationalCertificates { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.License.License>? Licenses { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Marriage.Marriage>? Marriages { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Passport.Passport>? Passports { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.User.UserBodyInformation>? UserBodyInformations { get; private set; }
    public Twenty_Crm_Domain.Entities.Religion.Religion? Religions { get; private set; }
    public IList<Twenty_Crm_Domain.Entities.Group.UserToGroup>? UserToGroups { get; set; }
    public IList<Twenty_Crm_Domain.Entities.Telephone.Telephone>? Telephones { get; set; }
    public IList<Twenty_Crm_Domain.Entities.Telephone.Mobile>? Mobiles { get; set; }
    //public IList<CompanyToUser>? CompanyToUsers { get; set; }
    #endregion
}
