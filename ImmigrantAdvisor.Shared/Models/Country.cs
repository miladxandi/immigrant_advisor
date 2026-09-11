namespace ImmigrantAdvisor.Shared.Models;

public class Country
{
    public string Name { get; set; } = "";
    public string NamePersian { get; set; } = "";
    public string FlagEmoji { get; set; } = "";
    public string Continent { get; set; } = "";
    
    // امتیازات کلی
    public int QualityOfLifeScore { get; set; }
    public int SafetyScore { get; set; }
    public int HealthcareScore { get; set; }
    public int EducationScore { get; set; }
    public int EconomicOpportunityScore { get; set; }
    public int PoliticalStabilityScore { get; set; }
    public int ClimateScore { get; set; }
    
    // هزینه‌ها
    public decimal CostOfLivingIndex { get; set; }
    public decimal AverageRentUSD { get; set; }
    public decimal AverageSalaryUSD { get; set; }
    
    // زبان
    public List<string> OfficialLanguages { get; set; } = new();
    public bool EnglishWidelySpoken { get; set; }
    
    // ویزا و مهاجرت
    public List<VisaOption> VisaOptions { get; set; } = new();
    public int CitizenshipYears { get; set; }
    public bool AllowsDualCitizenship { get; set; }
    
    // جمعیت ایرانی
    public int IranianPopulation { get; set; }
    public bool HasIranianCommunity { get; set; }
    
    // سیستم سلامت
    public string HealthcareSystem { get; set; } = "";
    public bool UniversalHealthcare { get; set; }
    
    // آموزش
    public string EducationSystemQuality { get; set; } = "";
    public bool FreeEducation { get; set; }
    
    // آب و هوا
    public string Climate { get; set; } = "";
    
    // فاصله از ایران
    public int DistanceFromIranKm { get; set; }
    
    // محدودیت‌ها
    public List<string> Restrictions { get; set; } = new();
}

public class VisaOption
{
    public string Name { get; set; } = "";
    public string Type { get; set; } = "";
    public string Duration { get; set; } = "";
    public decimal MinInvestmentUSD { get; set; }
    public decimal MinIncomeUSD { get; set; }
    public EducationLevel MinEducation { get; set; }
    public LanguageProficiency MinLanguageLevel { get; set; }
    public int MinExperienceYears { get; set; }
    public List<string> Requirements { get; set; } = new();
    public List<string> Benefits { get; set; } = new();
    public int ProcessingTimeMonths { get; set; }
    public bool LeadsToPR { get; set; }
    public bool LeadsToCitizenship { get; set; }
}

public class MigrationPlan
{
    public Country Country { get; set; } = new();
    public VisaOption RecommendedVisa { get; set; } = new();
    public int MatchScore { get; set; }
    public List<string> Strengths { get; set; } = new();
    public List<string> Challenges { get; set; } = new();
    public List<string> Recommendations { get; set; } = new();
    public decimal EstimatedMonthlyCostUSD { get; set; }
    public decimal EstimatedMonthlyIncomeUSD { get; set; }
    public string Timeline { get; set; } = "";
    public List<string> Steps { get; set; } = new();
}
