using ImmigrantAdvisor.Shared.Models;
using ImmigrantAdvisor.Shared.Data;

namespace ImmigrantAdvisor.Shared.Services;

public class ImmigrationAdvisorService
{
    private readonly List<Country> _countries;

    public ImmigrationAdvisorService()
    {
        _countries = CountryData.GetCountries();
    }

    public List<MigrationPlan> GetRecommendations(UserFactors factors)
    {
        var plans = new List<MigrationPlan>();

        foreach (var country in _countries)
        {
            var score = CalculateCountryScore(country, factors);
            if (score > 30) // حداقل امتیاز برای نمایش
            {
                var bestVisa = FindBestVisa(country, factors);
                if (bestVisa != null)
                {
                    var plan = CreateMigrationPlan(country, bestVisa, score, factors);
                    plans.Add(plan);
                }
            }
        }

        return plans.OrderByDescending(p => p.MatchScore).Take(5).ToList();
    }

    private int CalculateCountryScore(Country country, UserFactors factors)
    {
        int score = 0;

        // ═══ اهداف مهاجرت (مهم‌ترین فاکتور) ═══
        if (factors.Goals.Contains(MigrationGoal.BetterEconomicOpportunities))
            score += country.EconomicOpportunityScore * 2 / 3;
        
        if (factors.Goals.Contains(MigrationGoal.HigherQualityOfLife))
            score += country.QualityOfLifeScore * 2 / 3;
        
        if (factors.Goals.Contains(MigrationGoal.Education))
            score += country.EducationScore * 2 / 3;
        
        if (factors.Goals.Contains(MigrationGoal.Healthcare))
            score += country.HealthcareScore * 2 / 3;
        
        if (factors.Goals.Contains(MigrationGoal.PoliticalStability))
            score += country.PoliticalStabilityScore * 2 / 3;
        
        if (factors.Goals.Contains(MigrationGoal.Safety))
            score += country.SafetyScore * 2 / 3;

        if (factors.Goals.Contains(MigrationGoal.Retirement))
        {
            // بازنشستگی: هزینه زندگی پایین + آب‌وهوای خوب + امنیت
            if (country.CostOfLivingIndex < 45) score += 20;
            if (country.ClimateScore > 70) score += 10;
            if (country.SafetyScore > 75) score += 10;
        }

        if (factors.Goals.Contains(MigrationGoal.FamilyReunification) && factors.HasRelativesAbroad)
        {
            if (country.HasIranianCommunity) score += 15;
        }

        // ═══ تطابق زبان ═══
        if (factors.EnglishLevel >= LanguageProficiency.Advanced && country.EnglishWidelySpoken)
            score += 20;
        else if (factors.EnglishLevel >= LanguageProficiency.Intermediate && country.EnglishWidelySpoken)
            score += 12;
        else if (factors.EnglishLevel < LanguageProficiency.Intermediate && !country.EnglishWidelySpoken)
            score -= 10; // زبان محلی ضعیف + کشور انگلیسی‌زبان نیست → سخت
        
        if (factors.FrenchLevel >= LanguageProficiency.Intermediate && country.OfficialLanguages.Contains("فرانسوی"))
            score += 12;
        
        if (factors.GermanLevel >= LanguageProficiency.Intermediate && country.OfficialLanguages.Contains("آلمانی"))
            score += 12;

        if (factors.SpanishLevel >= LanguageProficiency.Intermediate && country.OfficialLanguages.Contains("اسپانیایی"))
            score += 12;

        // ═══ تطابق تحصیلات ═══
        if (factors.Education >= EducationLevel.BachelorDegree)
            score += 12;
        if (factors.Education >= EducationLevel.MasterDegree)
            score += 6;
        if (factors.Education >= EducationLevel.PhD)
            score += 6;

        // ═══ سابقه کار ═══
        if (factors.YearsOfExperience >= 3)
            score += 12;
        if (factors.YearsOfExperience >= 5)
            score += 8;
        if (factors.YearsOfExperience >= 10)
            score += 5;

        // ═══ سلامت و تطابق روحی ═══
        if (factors.PhysicalHealth == PhysicalHealthStatus.Excellent || factors.PhysicalHealth == PhysicalHealthStatus.Good)
        {
            if (country.UniversalHealthcare)
                score += 10;
        }
        else if (factors.HasChronicDisease || factors.NeedsSpecializedHealthcare)
        {
            score += country.HealthcareScore / 4;
            if (!country.UniversalHealthcare) score -= 15; // بدون بیمه همگانی + بیماری = مشکل
        }

        if (factors.StressTolerance == StressToleranceLevel.High || factors.StressTolerance == StressToleranceLevel.VeryHigh)
            score += 5;
        else if (factors.StressTolerance == StressToleranceLevel.Low)
        {
            if (country.SafetyScore > 80) score += 8;
            if (country.PoliticalStabilityScore > 80) score += 5;
        }
        
        if (factors.Adaptability == AdaptabilityLevel.High || factors.Adaptability == AdaptabilityLevel.VeryHigh)
            score += 5;
        else if (factors.Adaptability == AdaptabilityLevel.Low)
            score -= 5; // سازگاری پایین = سخت‌تر

        // ═══ ترجیحات فرهنگی و اجتماعی ═══
        if (factors.HasRelativesAbroad && country.HasIranianCommunity)
            score += 15;
        
        if (factors.CommunityPreference == CommunityIntegrationPreference.LargeIranianCommunity)
        {
            if (country.IranianPopulation > 100000) score += 20;
            else if (country.IranianPopulation > 10000) score += 8;
            else score -= 15; // جامعه ایرانی بزرگ می‌خواد ولی اینجا نیست
        }
        else if (factors.CommunityPreference == CommunityIntegrationPreference.SmallIranianCommunity)
        {
            if (country.IranianPopulation > 0 && country.IranianPopulation < 20000) score += 10;
        }
        else if (factors.CommunityPreference == CommunityIntegrationPreference.PreferDiverseCommunity)
            score += 8;

        // ═══ تطابق آب‌وهوا (با جریمه) ═══
        if (factors.ClimatePreference != ClimatePreference.NoPreference)
        {
            bool climateMatch = false;
            if (factors.ClimatePreference == ClimatePreference.Mediterranean && country.Climate.Contains("مدیترانه"))
                climateMatch = true;
            else if (factors.ClimatePreference == ClimatePreference.Temperate && country.Climate.Contains("معتدل"))
                climateMatch = true;
            else if (factors.ClimatePreference == ClimatePreference.Cold && country.Climate.Contains("سرد"))
                climateMatch = true;
            else if (factors.ClimatePreference == ClimatePreference.Tropical && (country.Climate.Contains("گرم") || country.Climate.Contains("گرمسیری")))
                climateMatch = true;
            else if (factors.ClimatePreference == ClimatePreference.Continental && country.Climate.Contains("قاره‌ای"))
                climateMatch = true;

            if (climateMatch) score += 15;
            else score -= 15; // آب‌وهوای نامطلوب = جریمه
        }

        // ═══ فاصله از ایران (فاکتور کلیدی با جریمه سنگین) ═══
        if (factors.DistancePreference == DistanceFromIranPreference.VeryClose)
        {
            if (country.DistanceFromIranKm < 1000) score += 35;
            else if (country.DistanceFromIranKm < 2000) score += 25;
            else if (country.DistanceFromIranKm < 3500) score -= 15;
            else if (country.DistanceFromIranKm < 6000) score -= 30;
            else score -= 50; // خیلی دوره → جریمه سنگین
        }
        else if (factors.DistancePreference == DistanceFromIranPreference.Close)
        {
            if (country.DistanceFromIranKm < 3000) score += 25;
            else if (country.DistanceFromIranKm < 5000) score += 15;
            else if (country.DistanceFromIranKm < 8000) score -= 10;
            else score -= 30;
        }
        else if (factors.DistancePreference == DistanceFromIranPreference.Moderate)
        {
            if (country.DistanceFromIranKm >= 3000 && country.DistanceFromIranKm < 8000) score += 15;
            else if (country.DistanceFromIranKm < 3000) score += 5;
            else score -= 10;
        }
        else if (factors.DistancePreference == DistanceFromIranPreference.Far)
        {
            if (country.DistanceFromIranKm >= 8000) score += 20;
            else if (country.DistanceFromIranKm >= 5000) score += 10;
        }
        // NoPreference = بدون امتیاز یا جریمه

        // ═══ وضعیت تأهل و فرزندان ═══
        if (factors.MaritalStatus == MaritalStatus.Married && factors.NumberOfChildren > 0)
        {
            if (factors.ChildrenEducationImportant && country.FreeEducation)
                score += 15;
            
            if (country.QualityOfLifeScore > 85)
                score += 8;

            if (country.SafetyScore > 80)
                score += 8;

            if (country.CostOfLivingIndex > 75)
                score -= 10; // هزینه بالا با بچه = سخت
        }

        // ═══ توانایی مالی ═══
        if (factors.NetWorthUSD > 500000 && country.VisaOptions.Any(v => v.MinInvestmentUSD > 0))
            score += 12;
        
        if (factors.AnnualIncomeUSD > 50000)
            score += 8;

        if (factors.NetWorthUSD < 10000)
        {
            // سرمایه کم → کشورهای گران مناسب نیستن
            if (country.CostOfLivingIndex > 75) score -= 15;
            if (country.AverageRentUSD > 1500) score -= 10;
        }

        // ═══ ترجیح تابعیت ═══
        if (factors.SeekingCitizenship)
        {
            if (country.CitizenshipYears <= 3) score += 20;
            else if (country.CitizenshipYears <= 5) score += 15;
            else if (country.CitizenshipYears <= 7) score += 8;
            else if (country.CitizenshipYears <= 10) score += 3;
            else score -= 20; // تابعیت خیلی طول می‌کشه
        }

        // ═══ پایداری سیاسی ═══
        if (factors.ImportanceOfPoliticalStability == ImportanceOfPoliticalStability.VeryImportant)
        {
            if (country.PoliticalStabilityScore > 80) score += 15;
            else if (country.PoliticalStabilityScore > 60) score += 5;
            else score -= 25; // بی‌ثباتی سیاسی وقتی خیلی مهمه = جریمه سنگین
        }
        else if (factors.ImportanceOfPoliticalStability == ImportanceOfPoliticalStability.Important)
        {
            if (country.PoliticalStabilityScore < 50) score -= 15;
        }

        // ═══ هزینه زندگی نسبت به درآمد ═══
        if (factors.AnnualIncomeUSD > 0)
        {
            var monthlyCost = country.CostOfLivingIndex * 20;
            var monthlyIncome = country.AverageSalaryUSD;
            if (monthlyIncome > 0)
            {
                var ratio = monthlyCost / monthlyIncome;
                if (ratio < 0.4m) score += 10; // ارزان نسبت به درآمد
                else if (ratio > 0.7m) score -= 10; // گران
            }
        }

        return score;
    }

    private VisaOption? FindBestVisa(Country country, UserFactors factors)
    {
        var eligibleVisas = country.VisaOptions.Where(v => IsVisaEligible(v, factors)).ToList();
        
        if (!eligibleVisas.Any())
            return null;

        // انتخاب بهترین ویزا بر اساس شرایط کاربر
        return eligibleVisas.OrderByDescending(v => CalculateVisaScore(v, factors)).First();
    }

    private bool IsVisaEligible(VisaOption visa, UserFactors factors)
    {
        // بررسی تحصیلات
        if (visa.MinEducation > factors.Education)
            return false;

        // بررسی زبان (هر زبانی که کاربر بلده چک کن)
        if (visa.MinLanguageLevel > factors.EnglishLevel && 
            visa.MinLanguageLevel > factors.FrenchLevel &&
            visa.MinLanguageLevel > factors.GermanLevel &&
            visa.MinLanguageLevel > factors.SpanishLevel)
            return false;

        // بررسی سابقه کار
        if (visa.MinExperienceYears > factors.YearsOfExperience)
            return false;

        // بررسی سرمایه
        if (visa.MinInvestmentUSD > 0 && factors.NetWorthUSD < visa.MinInvestmentUSD)
            return false;

        // بررسی درآمد
        if (visa.MinIncomeUSD > 0 && factors.AnnualIncomeUSD / 12 < visa.MinIncomeUSD)
            return false;

        return true;
    }

    private int CalculateVisaScore(VisaOption visa, UserFactors factors)
    {
        int score = 0;

        // امتیاز بر اساس نوع ویزا
        if (visa.LeadsToPR)
            score += 20;
        
        if (visa.LeadsToCitizenship && factors.SeekingCitizenship)
            score += 15;

        // امتیاز بر اساس زمان پردازش
        if (factors.PreferredTimeline == MigrationTimeline.Immediate && visa.ProcessingTimeMonths <= 3)
            score += 15;
        else if (factors.PreferredTimeline == MigrationTimeline.Within3Months && visa.ProcessingTimeMonths <= 6)
            score += 10;
        else if (factors.PreferredTimeline == MigrationTimeline.Within6Months && visa.ProcessingTimeMonths <= 9)
            score += 8;

        // تطابق نوع ویزا با اهداف کاربر
        bool isStudentVisa = visa.Name.Contains("تحصیلی") || visa.Name.Contains("Student") || visa.Name.Contains("F-1");
        bool isWorkVisa = visa.Name.Contains("کار") || visa.Name.Contains("Work") || visa.Name.Contains("Skilled") || visa.Name.Contains("H-1B") || visa.Name.Contains("بلوکارت") || visa.Name.Contains("Blue Card");
        bool isInvestmentVisa = visa.MinInvestmentUSD > 0 || visa.Name.Contains("سرمایه‌گذاری") || visa.Name.Contains("Investment") || visa.Name.Contains("Golden") || visa.Name.Contains("طلایی");
        bool isNomadVisa = visa.Name.Contains("فریلنسر") || visa.Name.Contains("Digital Nomad") || visa.Name.Contains("خوداشتغال") || visa.Name.Contains("Nomad");

        if (isStudentVisa)
        {
            if (factors.Goals.Contains(MigrationGoal.Education))
                score += 30; // کاربر دنبال تحصیله
            else
                score -= 40; // کاربر دنبال تحصیل نیست → جریمه سنگین
        }

        if (isWorkVisa)
        {
            if (factors.Goals.Contains(MigrationGoal.BetterEconomicOpportunities) || factors.Goals.Contains(MigrationGoal.CareerGrowth))
                score += 25;
        }

        if (isInvestmentVisa)
        {
            if (factors.Goals.Contains(MigrationGoal.BusinessExpansion))
                score += 25;
        }

        if (isNomadVisa)
        {
            if (factors.CurrentEmployment == EmploymentType.SelfEmployed || factors.CurrentEmployment == EmploymentType.BusinessOwner)
                score += 15;
        }

        // امتیاز بر اساس مزایا
        score += visa.Benefits.Count * 2;

        return score;
    }

    private MigrationPlan CreateMigrationPlan(Country country, VisaOption visa, int score, UserFactors factors)
    {
        var plan = new MigrationPlan
        {
            Country = country,
            RecommendedVisa = visa,
            MatchScore = score,
            Strengths = new List<string>(),
            Challenges = new List<string>(),
            Recommendations = new List<string>(),
            EstimatedMonthlyCostUSD = country.CostOfLivingIndex * 20,
            EstimatedMonthlyIncomeUSD = country.AverageSalaryUSD,
            Timeline = $"زمان پردازش: {visa.ProcessingTimeMonths} ماه",
            Steps = new List<string>()
        };

        // نقاط قوت
        if (country.QualityOfLifeScore > 85)
            plan.Strengths.Add("کیفیت زندگی بسیار بالا");
        
        if (country.SafetyScore > 85)
            plan.Strengths.Add("امنیت بالا");
        
        if (country.HealthcareScore > 85)
            plan.Strengths.Add("سیستم بهداشتی عالی");
        
        if (country.EducationScore > 85)
            plan.Strengths.Add("سیستم آموزشی در سطح جهانی");
        
        if (country.EconomicOpportunityScore > 80)
            plan.Strengths.Add("فرصت‌های اقتصادی قوی");
        
        if (country.HasIranianCommunity)
            plan.Strengths.Add($"جامعه ایرانی بزرگ ({country.IranianPopulation:N0} نفر)");
        
        if (country.EnglishWidelySpoken && factors.EnglishLevel >= LanguageProficiency.Intermediate)
            plan.Strengths.Add("امکان ارتباط به زبان انگلیسی");
        
        if (visa.LeadsToPR)
            plan.Strengths.Add("مسیر به اقامت دائم");
        
        if (visa.LeadsToCitizenship)
            plan.Strengths.Add($"امکان دریافت تابعیت پس از {country.CitizenshipYears} سال");

        // چالش‌ها
        if (country.CostOfLivingIndex > 70)
            plan.Challenges.Add("هزینه زندگی بالا");
        
        if (!country.EnglishWidelySpoken && factors.EnglishLevel < LanguageProficiency.Advanced)
            plan.Challenges.Add($"نیاز به یادگیری زبان {country.OfficialLanguages.First()}");
        
        if (country.Climate.Contains("سرد") && factors.ClimatePreference == ClimatePreference.Tropical)
            plan.Challenges.Add("آب‌وهوای سرد");
        
        if (country.DistanceFromIranKm > 8000)
            plan.Challenges.Add("فاصله زیاد از ایران");
        
        if (visa.ProcessingTimeMonths > 12)
            plan.Challenges.Add("فرآیند ویزای طولانی");

        plan.Challenges.AddRange(country.Restrictions.Take(2));

        // توصیه‌ها
        if (factors.EnglishLevel < LanguageProficiency.Advanced && country.EnglishWidelySpoken)
            plan.Recommendations.Add("تقویت زبان انگلیسی برای افزایش شانس موفقیت");
        
        if (!string.IsNullOrEmpty(visa.Name) && visa.Name.Contains("تحصیلی"))
            plan.Recommendations.Add("آماده‌سازی مدارک تحصیلی و ترجمه رسمی");
        
        if (visa.MinLanguageLevel >= LanguageProficiency.Intermediate)
            plan.Recommendations.Add($"آماده‌سازی مدرک زبان (حداقل سطح {GetLanguageLevelName(visa.MinLanguageLevel)})");
        
        plan.Recommendations.Add("مشاوره با وکیل مهاجرت معتبر");
        plan.Recommendations.Add("بررسی دقیق مدارک مورد نیاز");

        // مراحل
        plan.Steps.Add("بررسی دقیق شرایط و مدارک مورد نیاز");
        plan.Steps.Add($"آماده‌سازی مدارک و ترجمه رسمی");
        
        if (visa.MinLanguageLevel >= LanguageProficiency.Intermediate)
            plan.Steps.Add($"آزمون زبان و دریافت مدرک");
        
        plan.Steps.Add($"ثبت درخواست ویزا (زمان پردازش: {visa.ProcessingTimeMonths} ماه)");
        plan.Steps.Add("پیگیری وضعیت درخواست");
        plan.Steps.Add("آماده‌سازی برای نقل مکان");
        plan.Steps.Add("ورود و استقرار در کشور مقصد");

        return plan;
    }

    private string GetLanguageLevelName(LanguageProficiency level) => level switch
    {
        LanguageProficiency.Basic => "مقدماتی (A2)",
        LanguageProficiency.Intermediate => "متوسط (B1-B2)",
        LanguageProficiency.Advanced => "پیشرفته (C1)",
        LanguageProficiency.Native => "زبان مادری (C2)",
        _ => "مقدماتی"
    };
}
