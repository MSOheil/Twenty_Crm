namespace Twenty_Crm_Presentation.Controllers;
public class FileReaderController : BaseController
{
    private readonly IGroupRepository groupRepository;
    private readonly IUserService userService;
    private readonly IGroupService groupService;
    private readonly ITelephoneService telephoneService;
    private readonly IMobileService mobileService;
    private readonly IUserToGroupService userToGroupService;
    private readonly IPhoneNumberService phoneNumberService;
    private readonly ITelephoneRepository telephoneRepository;
    private readonly IPhoneNumberRepo phoneNumberRepo;
    private readonly IUserToGroupRepo userToGroupRepo;
    private readonly IUserRepository userRepository;

    public FileReaderController(IGroupRepository groupRepository, IUserService userService, IGroupService groupService, ITelephoneService telephoneService, IMobileService mobileService, IUserToGroupService userToGroupService, IPhoneNumberService phoneNumberService, ITelephoneRepository telephoneRepository, IPhoneNumberRepo phoneNumberRepo, IUserToGroupRepo userToGroupRepo, IUserRepository userRepository)
    {
        this.groupRepository = groupRepository;
        this.userService = userService;
        this.groupService = groupService;
        this.telephoneService = telephoneService;
        this.mobileService = mobileService;
        this.userToGroupService = userToGroupService;
        this.phoneNumberService = phoneNumberService;
        this.telephoneRepository = telephoneRepository;
        this.phoneNumberRepo = phoneNumberRepo;
        this.userToGroupRepo = userToGroupRepo;
        this.userRepository = userRepository;
    }

    [HttpPost("{companyRef}")]
    public async Task<ResponseDto<bool>> Read(Guid companyRef, [FromForm] IFormFile formFile)
    {
        if (formFile != null && formFile.Length > 0)
        {
            var firstName = 2;
            var lastName = 4;
            var jobDescription = 26;
            var groupMember = 29;
            var firstMobileNumber = 33;
            var towMobileNumber = 35;
            var homePhoneNumber = 37;
            var twoHomeNumber = 39;
            var threeHomeNumber = 41;
            var stateName = 45;
            var companyName = 52;


            var phoneNumberList = new List<Twenty_Crm_Domain.Entities.Telephone.Mobile>();
            var telephoneList = new List<Twenty_Crm_Domain.Entities.Telephone.Telephone>();
            var groupList = new List<Twenty_Crm_Domain.Entities.Group.UserToGroup>();
            var userList = new List<Twenty_Crm_Domain.Entities.User.User>();
            try
            {
                string filePath = Path.GetTempFileName(); // مسیر موقت برای ذخیره فایل 
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                }

                Application excelApp = new Application();
                Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
                _Worksheet excelWorksheet = excelWorkbook.Sheets[1];
                Range excelRange = excelWorksheet.UsedRange;

                int rowCount = excelRange.Rows.Count;
                int colCount = excelRange.Columns.Count;

                for (int i = 1; i <= rowCount; i++)
                {
                    var firstNameValue = (excelRange.Cells[i, firstName] as Range)?.Value;
                    var lastNameValue = (excelRange.Cells[i, lastName] as Range)?.Value;
                    var companyNameValue = (excelRange.Cells[i, companyName] as Range)?.Value;
                    var jobDescriptionValue = (excelRange.Cells[i, jobDescription] as Range)?.Value;
                    #region CreateUser
                    //var createUser = await this.userService.CreateUserAsync(new CreateUserDto
                    //{
                    //    FirstName = firstNameValue,
                    //    LastName = lastNameValue,
                    //    CompanyRef = companyRef,
                    //    CompanyName = companyNameValue,
                    //});
                    var createUser = new Twenty_Crm_Domain.Entities.User.User
                    {
                        FirstName = firstNameValue,
                        LastName = lastNameValue,
                        CompanyCreated = companyRef,
                        CompanyName = companyNameValue,
                    };
                    userList.Add(createUser);
                    #endregion




                    var groupMemberValue = (excelRange.Cells[i, groupMember] as Range)?.Value as string;
                    var newGroupt = groupMemberValue.Replace(" ::: * myContacts", "");
                    var group = await this.groupRepository.GetAll()
                        .Where(b => b.Name.Contains(newGroupt)).AsNoTracking().Select(s => s.Id).FirstOrDefaultAsync();
                    #region CreateGroup
                    if (group != Guid.Empty && createUser is not null && createUser.Id != Guid.Empty)
                    {
                        //await this.userToGroupService.CreateUserToGroupAsync(group.Id, createUser.Id ?? Guid.Empty);
                        groupList.Add(new Twenty_Crm_Domain.Entities.Group.UserToGroup
                        {
                            GropuRef = group,
                            UserRef = createUser.Id,
                        });
                    }
                    #endregion

                    var firstMobileNumberValue = (excelRange.Cells[i, firstMobileNumber] as Range)?.Value;
                    #region Create first mobile value
                    if (createUser != null && createUser.Id != Guid.Empty && firstMobileNumberValue != null)
                    {
                        //await this.phoneNumberService.CreatePhoneNumberDtoAsync(createUser.Id ?? Guid.Empty, new Twenty_Crm_Application.Common.Models.Dto.PhoneNumber.CreatePhoneNumberDto
                        //{
                        //    PhoneNumber = firstMobileNumberValue,
                        //    Title = "اولین شماره تلفن"
                        //});

                        phoneNumberList.Add(new Twenty_Crm_Domain.Entities.Telephone.Mobile
                        {
                            PhoneNumber = firstMobileNumberValue,
                            Title = "",
                            UserRef = createUser.Id,
                        });
                    }
                    #endregion
                    var towMobileNumberValue = (excelRange.Cells[i, towMobileNumber] as Range)?.Value;
                    #region Create two mobile value
                    if (createUser != null && createUser.Id != Guid.Empty && towMobileNumberValue != null)
                    {
                        //await this.phoneNumberService.CreatePhoneNumberDtoAsync(createUser.Id ?? Guid.Empty, new Twenty_Crm_Application.Common.Models.Dto.PhoneNumber.CreatePhoneNumberDto
                        //{
                        //    PhoneNumber = towMobileNumberValue,
                        //    Title = "دومین شماره تلفن"
                        //});

                        phoneNumberList.Add(new Twenty_Crm_Domain.Entities.Telephone.Mobile
                        {
                            UserRef = createUser.Id,
                            PhoneNumber = towMobileNumberValue,
                            Title = "",
                        });
                    }
                    #endregion

                    var homePhoneNumberValue = (excelRange.Cells[i, homePhoneNumber] as Range)?.Value as string;
                    #region Create first telephone value
                    if (createUser != null && createUser.Id != Guid.Empty && homePhoneNumberValue != null)
                    {
                        var prePhoneNumber = homePhoneNumberValue.Substring(0, 3);
                        var phoneNumber = homePhoneNumberValue.Substring(3, 8);
                        //await this.telephoneService.CreateTelephoneAsync(createUser.Id ?? Guid.Empty, new CreateTelephoneDto
                        //{
                        //    Title = "اولین تلفن ثابت",
                        //    PhoneNumber = phoneNumber,
                        //    PrePhoneNumber = prePhoneNumber,
                        //});

                        telephoneList.Add(new Twenty_Crm_Domain.Entities.Telephone.Telephone
                        {
                            UserRef = createUser.Id,
                            Title = "",
                            TelephoneNumber = phoneNumber,
                            PrePhoneNumber = prePhoneNumber,
                        });
                    }
                    #endregion

                    var twoHomeNumberValue = (excelRange.Cells[i, twoHomeNumber] as Range)?.Value;
                    #region Create two telephone value
                    if (createUser != null && createUser.Id != Guid.Empty && twoHomeNumberValue != null)
                    {
                        var prePhoneNumber = twoHomeNumberValue.Substring(0, 3);
                        var phoneNumber = twoHomeNumberValue.Substring(3,8);
                        //await this.telephoneService.CreateTelephoneAsync(createUser.Id ?? Guid.Empty, new CreateTelephoneDto
                        //{
                        //    Title = "اولین تلفن ثابت",
                        //    PhoneNumber = phoneNumber,
                        //    PrePhoneNumber = prePhoneNumber,
                        //});
                        telephoneList.Add(new Twenty_Crm_Domain.Entities.Telephone.Telephone
                        {
                            UserRef = createUser.Id,
                            Title = "",
                            TelephoneNumber = phoneNumber,
                            PrePhoneNumber = prePhoneNumber,
                        });
                    }
                    #endregion
                    var threeHomeNumberValue = (excelRange.Cells[i, threeHomeNumber] as Range)?.Value;
                    #region Create two telephone value
                    if (createUser != null && createUser.Id != Guid.Empty && threeHomeNumberValue != null)
                    {
                        var prePhoneNumber = threeHomeNumberValue.Substring(0, 3);
                        var phoneNumber = threeHomeNumberValue.Substring(3, 8);
                        //await this.telephoneService.CreateTelephoneAsync(createUser.Id ?? Guid.Empty, new CreateTelephoneDto
                        //{
                        //    Title = "اولین تلفن ثابت",
                        //    PhoneNumber = phoneNumber,
                        //    PrePhoneNumber = prePhoneNumber,
                        //});
                        telephoneList.Add(new Twenty_Crm_Domain.Entities.Telephone.Telephone
                        {
                            UserRef = createUser.Id,
                            Title = "",
                            TelephoneNumber = phoneNumber,
                            PrePhoneNumber = prePhoneNumber,
                        });
                    }
                    #endregion
                    var stateNameValue = (excelRange.Cells[i, stateName] as Range)?.Value;
                }

                excelWorkbook.Close(false);
                excelApp.Quit();
                await this.userRepository.AddRangeAsync(userList);
                await this.userToGroupRepo.AddManyAsync(groupList);
                await this.telephoneRepository.AddManyAsync(telephoneList);
                await this.phoneNumberRepo.AddRangeAsync(phoneNumberList);
                return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                    , 200, true);
            }
            catch (Exception ex)
            {
                return new ResponseDto<bool>("ثبت اطلاعات با خطا مواجه شد"
                    , 500, true);
            }
        }
        return new ResponseDto<bool>("ثبت اطلاات با خطا مواجه شد"
            , 500, false);
    }

}
