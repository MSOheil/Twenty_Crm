namespace Twenty_Crm_Domain.Enums.File;

public enum FileType  
{
    [Display(Name = "تصویر")]
    Image = 1,
    [Display(Name = "صدا")]
    Voice = 2,
    [Display(Name = "فایل های دیگر")]
    Other = 3,
    [Display(Name = "ظبط صدا")]
    Microphone = 4,
    [Display(Name = "فایل pdf")]
    Pdf = 5,
    [Display(Name = "فایل Execl")]
    Excel = 6,
}
