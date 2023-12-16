namespace Twenty_Crm_Domain.Enums;

public enum IranianBankAccountType
{
    [Display(Name = "حساب جاری")]
    CurrentAccount,

    [Display(Name = "حساب قرض‌الحسنه")]
    QarzOlHasaneh,

    [Display(Name = "حساب سپرده")]
    DepositAccount,

    [Display(Name = "حساب مشترک")]
    JointAccount
}
