using Microsoft.Office.Interop.Excel;
using Twenty_Crm_Application.Common.Interfaces.Repositories.Website;
using Range = Microsoft.Office.Interop.Excel.Range;

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
    private readonly ILogger<FileReaderController> logger;
    private readonly IWebsiteRepository websiteRepository;
    public FileReaderController(IWebsiteRepository websiteRepository, ILogger<FileReaderController> logger, IGroupRepository groupRepository, IUserService userService, IGroupService groupService, ITelephoneService telephoneService, IMobileService mobileService, IUserToGroupService userToGroupService, IPhoneNumberService phoneNumberService, ITelephoneRepository telephoneRepository, IPhoneNumberRepo phoneNumberRepo, IUserToGroupRepo userToGroupRepo, IUserRepository userRepository)
    {
        this.websiteRepository = websiteRepository;
        this.logger = logger;
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
        this.logger.LogInformation(
            $" we have got file " +
            $"with file name : {formFile.FileName}" +
            $" in line 38 class [FileReaderController]" +
            $" and with file info : {formFile.Name}");
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
            var websiteName = 60;

            var phoneNumberList = new List<Twenty_Crm_Domain.Entities.Telephone.Mobile>();
            var telephoneList = new List<Twenty_Crm_Domain.Entities.Telephone.Telephone>();
            var groupList = new List<Twenty_Crm_Domain.Entities.Group.UserToGroup>();
            var userList = new List<Twenty_Crm_Domain.Entities.User.User>();
            var websites = new List<Twenty_Crm_Domain.Entities.Website.Website>();
            try
            {
                this.logger.LogInformation
                    ("in line 69 for starting file path");
                string filePath = AppDomain.CurrentDomain.BaseDirectory;
                this.logger.LogInformation(
                    $" after generate in line 72 file path is  : {filePath}");
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await formFile.CopyToAsync(stream);
                    this.logger
                        .LogInformation
                        ("We have created file in" +
                        "file path " +
                        $" : {filePath}");
                }
                this.logger.LogInformation("" +
                    "starting for import excel file and read ");
                Application excelApp = new Application();
                Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
                _Worksheet excelWorksheet = excelWorkbook.Sheets[1];
                Range excelRange = excelWorksheet.UsedRange;

                int rowCount = excelRange.Rows.Count;
                int colCount = excelRange.Columns.Count;

                for (int i = 1; i <= rowCount; i++)
                {
                    var firstNameValue = (excelRange.Cells[i, firstName] as Range)?.Value as string;
                    var lastNameValue = (excelRange.Cells[i, lastName] as Range)?.Value as string;
                    var companyNameValue = (excelRange.Cells[i, companyName] as Range)?.Value as string;
                    var jobDescriptionValue = (excelRange.Cells[i, jobDescription] as Range)?.Value as string;
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
                    var firstMobileNumberValue = (excelRange.Cells[i, firstMobileNumber] as Range)?.Value as string;
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
                    var towMobileNumberValue = (excelRange.Cells[i, towMobileNumber] as Range)?.Value as string;
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
                        var phoneNumber = homePhoneNumberValue.Substring(3);
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

                    var twoHomeNumberValue = (excelRange.Cells[i, twoHomeNumber] as Range)?.Value as string;
                    #region Create two telephone value
                    if (createUser != null && createUser.Id != Guid.Empty && twoHomeNumberValue != null)
                    {
                        var prePhoneNumber = twoHomeNumberValue.Substring(0, 3);
                        var phoneNumber = twoHomeNumberValue.Substring(3);
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
                    var threeHomeNumberValue = (excelRange.Cells[i, threeHomeNumber] as Range)?.Value as string;
                    #region Create two telephone value
                    if (createUser != null && createUser.Id != Guid.Empty && threeHomeNumberValue != null)
                    {
                        var prePhoneNumber = threeHomeNumberValue.Substring(0, 3);
                        var phoneNumber = threeHomeNumberValue.Substring(3);
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


                    var websiteValue = (excelRange.Cells[i, websiteName] as Range)?.Value as string;
                    #region insertwebiste
                    if (websiteValue is not null && createUser != null && createUser.Id != Guid.Empty
                      )
                    {

                        websites.Add(new Twenty_Crm_Domain.Entities.Website.Website
                        {
                            UserRef = createUser.Id,
                            Url = websiteValue,
                            Name = "",
                        });
                    }

                    #endregion
                }

                excelWorkbook.Close(false);
                excelApp.Quit();
                this.logger.LogInformation($"" +
                    $"we user count in line 226 " +
                    $": {userList.Count}");
                await this.userRepository.AddRangeAsync(userList);
                this.logger.LogInformation($"" +
                $"we groupt list count in line 230 " +
                $": {groupList.Count}");
                await this.userToGroupRepo.AddManyAsync(groupList);
                this.logger.LogInformation($"" +
                $"we telephone list count in line 234 " +
                $": {telephoneList.Count}");
                await this.telephoneRepository.AddManyAsync(telephoneList);
                this.logger.LogInformation($"" +
                $"we phoneNumberList count in line 238 " +
                $": {phoneNumberList.Count}");
                await this.phoneNumberRepo.AddManyAsync(phoneNumberList);
                this.logger.LogInformation($"" +
              $"we website count in line 265 " +
              $": {websites.Count}");
                await this.websiteRepository.AddRangeAsync(websites);

                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                    this.logger
                        .LogError
                        ($"" +
                        $"we deleted file with filepath " +
                        $"{filePath}");
                }
                return new ResponseDto<bool>("ثبت اطلاعات با موفقیت انجام شد"
                    , 200, true);
            }
            catch (Exception ex)
            {
                this.logger.LogError($" we have error in line 234 " +
                    $"with error message  : {ex.Message}" +
                    $" for read file and insert it in class [FileReaderController]" +
                    $"");
                return new ResponseDto<bool>("ثبت اطلاعات با خطا مواجه شد"
                    , 500, false);
            }
        }
        return new ResponseDto<bool>("ثبت اطلاات با خطا مواجه شد"
            , 500, false);
    }

}
