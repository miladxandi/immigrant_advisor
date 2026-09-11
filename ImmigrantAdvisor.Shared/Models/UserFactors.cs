namespace ImmigrantAdvisor.Shared.Models;

public class UserFactors
{
    // اطلاعات شخصی
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public int NumberOfChildren { get; set; }
    
    // تحصیلات و زبان
    public EducationLevel Education { get; set; }
    public string FieldOfStudy { get; set; } = "";
    public LanguageProficiency EnglishLevel { get; set; }
    public LanguageProficiency FrenchLevel { get; set; }
    public LanguageProficiency GermanLevel { get; set; }
    public LanguageProficiency SpanishLevel { get; set; }
    public List<string> OtherLanguages { get; set; } = new();
    
    // شغل و تخصص
    public string Occupation { get; set; } = "";
    public int YearsOfExperience { get; set; }
    public EmploymentType CurrentEmployment { get; set; }
    public decimal AnnualIncomeUSD { get; set; }
    public List<string> Skills { get; set; } = new();
    
    // مالی
    public decimal NetWorthUSD { get; set; }
    public decimal AnnualSavingsUSD { get; set; }
    public bool HasInvestmentProperty { get; set; }
    public bool HasBusinessOwnership { get; set; }
    
    // سلامت و روان
    public PhysicalHealthStatus PhysicalHealth { get; set; }
    public MentalHealthStatus MentalHealth { get; set; }
    public bool HasChronicDisease { get; set; }
    public bool NeedsSpecializedHealthcare { get; set; }
    public StressToleranceLevel StressTolerance { get; set; }
    public AdaptabilityLevel Adaptability { get; set; }
    
    // اجتماعی و فرهنگی
    public bool HasRelativesAbroad { get; set; }
    public string RelativesCountries { get; set; } = "";
    public CulturalPreference CulturalPreference { get; set; }
    public ReligionPreference ReligionPreference { get; set; }
    public ImportanceOfPoliticalStability ImportanceOfPoliticalStability { get; set; }
    public CommunityIntegrationPreference CommunityPreference { get; set; }
    
    // اهداف و انگیزه‌ها
    public List<MigrationGoal> Goals { get; set; } = new();
    public MigrationTimeline PreferredTimeline { get; set; }
    public bool WillingToReturn { get; set; }
    public bool SeekingCitizenship { get; set; }
    
    // ترجیحات جغرافیایی
    public ClimatePreference ClimatePreference { get; set; }
    public UrbanRuralPreference UrbanRuralPreference { get; set; }
    public DistanceFromIranPreference DistancePreference { get; set; }
    
    // خانواده و آموزش
    public bool ChildrenEducationImportant { get; set; }
    public AgeGroup EldestChildAge { get; set; }
    public bool SpouseWorking { get; set; }
    public string SpouseOccupation { get; set; } = "";
}

public enum Gender
{
    Male,
    Female,
    PreferNotToSay
}

public enum MaritalStatus
{
    Single,
    Married,
    Divorced,
    Widowed
}

public enum EducationLevel
{
    NoFormalEducation,
    HighSchool,
    Diploma,
    AssociateDegree,
    BachelorDegree,
    MasterDegree,
    PhD,
    PostDoctoral
}

public enum LanguageProficiency
{
    None,
    Basic,
    Intermediate,
    Advanced,
    Native
}

public enum EmploymentType
{
    Unemployed,
    PartTime,
    FullTime,
    SelfEmployed,
    BusinessOwner,
    Retired,
    Student
}

public enum PhysicalHealthStatus
{
    Excellent,
    Good,
    Fair,
    Poor
}

public enum MentalHealthStatus
{
    Excellent,
    Good,
    Fair,
    NeedsSupport
}

public enum StressToleranceLevel
{
    Low,
    Medium,
    High,
    VeryHigh
}

public enum AdaptabilityLevel
{
    Low,
    Medium,
    High,
    VeryHigh
}

public enum CulturalPreference
{
    Western,
    Eastern,
    MiddleEastern,
    Multicultural,
    NoPreference
}

public enum ReligionPreference
{
    Muslim,
    Christian,
    Jewish,
    Other,
    NoPreference,
    Secular
}

public enum ImportanceOfPoliticalStability
{
    NotImportant,
    SomewhatImportant,
    Important,
    VeryImportant
}

public enum CommunityIntegrationPreference
{
    LargeIranianCommunity,
    SmallIranianCommunity,
    NoPreference,
    PreferDiverseCommunity
}

public enum MigrationGoal
{
    BetterEconomicOpportunities,
    HigherQualityOfLife,
    Education,
    CareerGrowth,
    FamilyReunification,
    PoliticalStability,
    Safety,
    Healthcare,
    Retirement,
    BusinessExpansion,
    CulturalExperience
}

public enum MigrationTimeline
{
    Immediate,
    Within3Months,
    Within6Months,
    Within1Year,
    Within2Years,
    Flexible
}

public enum ClimatePreference
{
    Tropical,
    Temperate,
    Mediterranean,
    Continental,
    Cold,
    NoPreference
}

public enum UrbanRuralPreference
{
    BigCity,
    MediumCity,
    SmallTown,
    Rural,
    NoPreference
}

public enum DistanceFromIranPreference
{
    VeryClose,
    Close,
    Moderate,
    Far,
    NoPreference
}

public enum AgeGroup
{
    Infant,
    Child,
    Teenager,
    YoungAdult,
    Adult
}
