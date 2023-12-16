namespace Twenty_Crm_Domain.Enums;

public enum BaseEntityStatus
{
    [Display(Name = "حذف شده")]
    Deleted = 1,
    [Display(Name = "در انتظار تایید")]
    Pending = 2,
    [Display(Name = "فعال")]
    Active = 3,
}
