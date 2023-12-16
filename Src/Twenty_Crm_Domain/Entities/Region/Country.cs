namespace Twenty_Crm_Domain.Entities.Region;

public class Country : BaseEntity
{
    #region Properties
    public string? TelCode { get; set; }
    public string? PersianName { get; set; }
    public string? EnglishName { get; set; }
    public string? PersianNationName { get; set; }
    public string? EnglishNationName { get; set; }
    public string? PersianAdjective { get; set; }
    public string? EnglishAdjective { get; set; }
    public string? Continent { get; set; }
    public string? LanguageName { get; set; }
    public string? DomainName { get; set; }
    #endregion

    #region Relations
    public IList<State>? States { get; set; }
    public IList<City>? Cities { get; private set; }
    #endregion
}
