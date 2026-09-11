using ImmigrantAdvisor.Shared.Models;

namespace ImmigrantAdvisor.Shared.Data;

// داده‌های منطقه MENA (خاورمیانه و شمال آفریقا) - بروزرسانی August/September 2026
// ۱۷ کشور (ترکیه و امارات در فایل‌های دیگر)
public static class MenacountryData
{
    public static List<Country> GetCountries() => new()
    {
        // ═══════════ عربستان سعودی ═══════════
        new Country
        {
            Name = "Saudi Arabia", NamePersian = "عربستان سعودی", FlagEmoji = "🇸🇦", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 72, SafetyScore = 80, HealthcareScore = 75, EducationScore = 68,
            EconomicOpportunityScore = 72, PoliticalStabilityScore = 65, ClimateScore = 40,
            CostOfLivingIndex = 55, AverageRentUSD = 800, AverageSalaryUSD = 3000,
            OfficialLanguages = new() { "عربی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = false,
            IranianPopulation = 10000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه خصوصی اجباری", UniversalHealthcare = false,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "صحرایی گرم و خشک", DistanceFromIranKm = 1500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار (نظام کفیل) - بروزرسانی 2026", Type = "اقامت موقت", Duration = "۲ سال",
                    Requirements = new() { "پیشنهاد شغلی از کارفرمای سعودی", "مجوز کار از وزارت منابع انسانی", "آزمایشات پزشکی", "بیمه درمانی" },
                    Benefits = new() { "حقوق معاف از مالیات", "نزدیکی به ایران", "طرح Vision 2030", "فرصت‌های شغلی متنوع" },
                    ProcessingTimeMonths = 2, LeadsToPR = false, LeadsToCitizenship = false
                },
                new VisaOption
                {
                    Name = "ویزای اقامت ویژه (Premium Residency) - 2026", Type = "اقامت بلندمدت", Duration = "دائمی / ۱ سال",
                    MinInvestmentUSD = 200000,
                    Requirements = new() { "سرمایه‌گذاری ۸۰۰,۰۰۰ ریال سعودی", "یا حقوق ماهانه ۲۷,۰۰۰ ریال", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت بدون نیاز به کفیل", "حق مالکیت ملک", "الحاق خانواده", "مالیات صفر" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "نظام کفیل محدودکننده", "عدم امکان تابعیت", "آب‌وهوای بسیار گرم", "قوانین سخت‌گیرانه اجتماعی" }
        },

        // ═══════════ قطر ═══════════
        new Country
        {
            Name = "Qatar", NamePersian = "قطر", FlagEmoji = "🇶🇦", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 78, SafetyScore = 90, HealthcareScore = 80, EducationScore = 72,
            EconomicOpportunityScore = 78, PoliticalStabilityScore = 75, ClimateScore = 35,
            CostOfLivingIndex = 65, AverageRentUSD = 1500, AverageSalaryUSD = 4000,
            OfficialLanguages = new() { "عربی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 20, AllowsDualCitizenship = false,
            IranianPopulation = 15000, HasIranianCommunity = true,
            HealthcareSystem = "بیمه همگانی", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "صحرایی بسیار گرم", DistanceFromIranKm = 300,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۲ سال",
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "آزمایشات پزشکی", "بیمه درمانی" },
                    Benefits = new() { "حقوق معاف از مالیات", "نزدیکی به ایران", "امنیت بالا", "زبان انگلیسی رایج" },
                    ProcessingTimeMonths = 1, LeadsToPR = false, LeadsToCitizenship = false
                },
                new VisaOption
                {
                    Name = "اقامت دائم (PR Card)", Type = "اقامت دائم", Duration = "دائمی",
                    MinInvestmentUSD = 200000,
                    Requirements = new() { "سرمایه‌گذاری یا ملک", "حداقل درآمد ماهانه", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت دائم بدون کفیل", "حق مالکیت", "دسترسی به خدمات دولتی", "الحاق خانواده" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "تابعیت بسیار دشوار (۲۰ سال)", "آب‌وهوای بسیار گرم", "نظام کفیل", "هزینه زندگی بالا" }
        },

        // ═══════════ کویت ═══════════
        new Country
        {
            Name = "Kuwait", NamePersian = "کویت", FlagEmoji = "🇰🇼", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 72, SafetyScore = 82, HealthcareScore = 72, EducationScore = 65,
            EconomicOpportunityScore = 65, PoliticalStabilityScore = 68, ClimateScore = 35,
            CostOfLivingIndex = 55, AverageRentUSD = 1000, AverageSalaryUSD = 3000,
            OfficialLanguages = new() { "عربی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 20, AllowsDualCitizenship = false,
            IranianPopulation = 50000, HasIranianCommunity = true,
            HealthcareSystem = "همگانی برای شهروندان", UniversalHealthcare = false,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "صحرایی بسیار گرم", DistanceFromIranKm = 500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۲ سال",
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "آزمایشات پزشکی", "بیمه درمانی" },
                    Benefits = new() { "حقوق معاف از مالیات", "نزدیکی به ایران", "جامعه ایرانی", "نفت و گاز" },
                    ProcessingTimeMonths = 2, LeadsToPR = false, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "تابعیت تقریباً غیرممکن", "نظام کفیل", "آب‌وهوای بسیار گرم", "محدودیت‌های اجتماعی" }
        },

        // ═══════════ بحرین ═══════════
        new Country
        {
            Name = "Bahrain", NamePersian = "بحرین", FlagEmoji = "🇧🇭", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 70, SafetyScore = 82, HealthcareScore = 72, EducationScore = 65,
            EconomicOpportunityScore = 62, PoliticalStabilityScore = 60, ClimateScore = 40,
            CostOfLivingIndex = 50, AverageRentUSD = 800, AverageSalaryUSD = 2500,
            OfficialLanguages = new() { "عربی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 15, AllowsDualCitizenship = false,
            IranianPopulation = 30000, HasIranianCommunity = true,
            HealthcareSystem = "بیمه همگانی", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "صحرایی گرم", DistanceFromIranKm = 200,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۲ سال",
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "حقوق معاف از مالیات", "نزدیکی بسیار به ایران", "جامعه ایرانی بزرگ", "هزینه زندگی مناسب" },
                    ProcessingTimeMonths = 1, LeadsToPR = false, LeadsToCitizenship = false
                },
                new VisaOption
                {
                    Name = "ویزای طلایی (Golden Visa)", Type = "اقامت بلندمدت", Duration = "۱۰ سال",
                    MinInvestmentUSD = 200000,
                    Requirements = new() { "سرمایه‌گذاری یا خرید ملک", "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت ۱۰ ساله", "بدون نیاز به اسپانسر", "الحاق خانواده", "مالیات صفر" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "تابعیت دشوار", "جزیره کوچک", "آب‌وهوای گرم", "محدودیت‌های سیاسی" }
        },

        // ═══════════ عمان ═══════════
        new Country
        {
            Name = "Oman", NamePersian = "عمان", FlagEmoji = "🇴🇲", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 70, SafetyScore = 85, HealthcareScore = 68, EducationScore = 62,
            EconomicOpportunityScore = 58, PoliticalStabilityScore = 72, ClimateScore = 50,
            CostOfLivingIndex = 48, AverageRentUSD = 600, AverageSalaryUSD = 2200,
            OfficialLanguages = new() { "عربی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 20, AllowsDualCitizenship = false,
            IranianPopulation = 20000, HasIranianCommunity = true,
            HealthcareSystem = "بیمه همگانی", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "صحرایی/نیمه‌گرمسیری", DistanceFromIranKm = 600,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۲ سال",
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "حقوق معاف از مالیات", "آرامش و امنیت", "نزدیکی به ایران", "طبیعت زیبا" },
                    ProcessingTimeMonths = 2, LeadsToPR = false, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "تابعیت بسیار دشوار", "بازار کار کوچک", "آب‌وهوای گرم", "اقتصاد نفتی" }
        },

        // ═══════════ عراق ═══════════
        new Country
        {
            Name = "Iraq", NamePersian = "عراق", FlagEmoji = "🇮🇶", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 42, SafetyScore = 30, HealthcareScore = 35, EducationScore = 42,
            EconomicOpportunityScore = 40, PoliticalStabilityScore = 28, ClimateScore = 55,
            CostOfLivingIndex = 30, AverageRentUSD = 300, AverageSalaryUSD = 700,
            OfficialLanguages = new() { "عربی", "کردی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 15, AllowsDualCitizenship = true,
            IranianPopulation = 5000, HasIranianCommunity = false,
            HealthcareSystem = "دولتی (ضعیف)", UniversalHealthcare = true,
            EducationSystemQuality = "ضعیف", FreeEducation = true,
            Climate = "صحرایی گرم", DistanceFromIranKm = 500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار / تجاری", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "پیشنهاد شغلی یا ثبت شرکت", "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "نزدیکی به ایران", "فرصت‌های بازسازی", "صنعت نفت", "هزینه زندگی پایین" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "ناامنی شدید", "بی‌ثباتی سیاسی", "زیرساخت ضعیف", "تحریم‌ها" }
        },

        // ═══════════ اردن ═══════════
        new Country
        {
            Name = "Jordan", NamePersian = "اردن", FlagEmoji = "🇯🇴", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 58, SafetyScore = 70, HealthcareScore = 62, EducationScore = 60,
            EconomicOpportunityScore = 48, PoliticalStabilityScore = 62, ClimateScore = 65,
            CostOfLivingIndex = 35, AverageRentUSD = 350, AverageSalaryUSD = 900,
            OfficialLanguages = new() { "عربی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 15, AllowsDualCitizenship = true,
            IranianPopulation = 2000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = false,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "نیمه‌خشک", DistanceFromIranKm = 1500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار / اقامت", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "پیشنهاد شغلی یا سرمایه‌گذاری", "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "امنیت نسبتاً خوب", "نزدیکی به ایران", "هزینه زندگی پایین", "فرهنگ عربی نزدیک" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "بازار کار محدود", "اقتصاد ضعیف", "منابع آب محدود", "تابعیت پس از ۱۵ سال" }
        },

        // ═══════════ لبنان ═══════════
        new Country
        {
            Name = "Lebanon", NamePersian = "لبنان", FlagEmoji = "🇱🇧", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 48, SafetyScore = 40, HealthcareScore = 55, EducationScore = 58,
            EconomicOpportunityScore = 35, PoliticalStabilityScore = 25, ClimateScore = 75,
            CostOfLivingIndex = 40, AverageRentUSD = 400, AverageSalaryUSD = 700,
            OfficialLanguages = new() { "عربی", "فرانسوی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = true,
            IranianPopulation = 3000, HasIranianCommunity = false,
            HealthcareSystem = "خصوصی/بیمه", UniversalHealthcare = false,
            EducationSystemQuality = "خوب (دانشگاه‌های خصوصی)", FreeEducation = false,
            Climate = "مدیترانه‌ای", DistanceFromIranKm = 1500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "تمکن مالی یا سرمایه‌گذاری", "بیمه درمانی", "عدم سوءپیشینه", "محل اقامت" },
                    Benefits = new() { "فرهنگ آزاد", "آب‌وهوای مدیترانه‌ای", "غذا و فرهنگ غنی", "زبان فرانسوی" },
                    ProcessingTimeMonths = 2, LeadsToPR = false, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "بحران اقتصادی شدید", "بی‌ثباتی سیاسی", "تورم بسیار بالا", "ناامنی" }
        },

        // ═══════════ سوریه ═══════════
        new Country
        {
            Name = "Syria", NamePersian = "سوریه", FlagEmoji = "🇸🇾", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 25, SafetyScore = 15, HealthcareScore = 20, EducationScore = 30,
            EconomicOpportunityScore = 15, PoliticalStabilityScore = 10, ClimateScore = 65,
            CostOfLivingIndex = 18, AverageRentUSD = 100, AverageSalaryUSD = 200,
            OfficialLanguages = new() { "عربی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = true,
            IranianPopulation = 1000, HasIranianCommunity = false,
            HealthcareSystem = "آسیب‌دیده", UniversalHealthcare = false,
            EducationSystemQuality = "ضعیف", FreeEducation = true,
            Climate = "مدیترانه‌ای/نیمه‌خشک", DistanceFromIranKm = 1200,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new(),
            Restrictions = new() { "جنگ داخلی", "تحریم‌های بین‌المللی", "ناامنی شدید", "عدم توصیه برای مهاجرت" }
        },

        // ═══════════ مصر ═══════════
        new Country
        {
            Name = "Egypt", NamePersian = "مصر", FlagEmoji = "🇪🇬", Continent = "شمال آفریقا (MENA)",
            QualityOfLifeScore = 52, SafetyScore = 58, HealthcareScore = 50, EducationScore = 55,
            EconomicOpportunityScore = 48, PoliticalStabilityScore = 48, ClimateScore = 70,
            CostOfLivingIndex = 25, AverageRentUSD = 200, AverageSalaryUSD = 500,
            OfficialLanguages = new() { "عربی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = true,
            IranianPopulation = 3000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "صحرایی گرم", DistanceFromIranKm = 2500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "هزینه زندگی بسیار پایین", "تاریخ و فرهنگ غنی", "بازار بزرگ", "نزدیکی به آفریقا" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی (الأزهر و...)", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی (~۱۵۰ دلار/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "دانشگاه الأزهر (علوم اسلامی)", "شهریه بسیار پایین", "هزینه زندگی پایین", "فرصت‌های آموزشی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "اقتصاد ضعیف", "تورم بالا", "بوروکراسی", "محدودیت‌های اجتماعی" }
        },

        // ═══════════ مراکش ═══════════
        new Country
        {
            Name = "Morocco", NamePersian = "مراکش", FlagEmoji = "🇲🇦", Continent = "شمال آفریقا (MENA)",
            QualityOfLifeScore = 58, SafetyScore = 68, HealthcareScore = 52, EducationScore = 52,
            EconomicOpportunityScore = 50, PoliticalStabilityScore = 62, ClimateScore = 78,
            CostOfLivingIndex = 28, AverageRentUSD = 250, AverageSalaryUSD = 600,
            OfficialLanguages = new() { "عربی", "بربری", "فرانسوی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 500, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = false,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "مدیترانه‌ای/صحرایی", DistanceFromIranKm = 5500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار / اقامت", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    Requirements = new() { "پیشنهاد شغلی یا ثبت شرکت", "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "هزینه زندگی پایین", "آب‌وهوای عالی", "نزدیکی به اروپا", "فرهنگ غنی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "بازار کار محدود", "زبان فرانسوی/عربی", "فاصله از ایران", "تفاوت فرهنگی" }
        },

        // ═══════════ الجزایر ═══════════
        new Country
        {
            Name = "Algeria", NamePersian = "الجزایر", FlagEmoji = "🇩🇿", Continent = "شمال آفریقا (MENA)",
            QualityOfLifeScore = 52, SafetyScore = 65, HealthcareScore = 48, EducationScore = 50,
            EconomicOpportunityScore = 42, PoliticalStabilityScore = 52, ClimateScore = 68,
            CostOfLivingIndex = 25, AverageRentUSD = 200, AverageSalaryUSD = 500,
            OfficialLanguages = new() { "عربی", "بربری", "فرانسوی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 7, AllowsDualCitizenship = true,
            IranianPopulation = 200, HasIranianCommunity = false,
            HealthcareSystem = "همگانی", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "مدیترانه‌ای/صحرایی", DistanceFromIranKm = 5500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "صنعت نفت و گاز", "هزینه زندگی پایین", "آب‌وهوای مدیترانه‌ای", "تابعیت دوگانه" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "بوروکراسی پیچیده", "بازار کار محدود", "زبان فرانسوی/عربی", "اقتصاد نفتی" }
        },

        // ═══════════ تونس ═══════════
        new Country
        {
            Name = "Tunisia", NamePersian = "تونس", FlagEmoji = "🇹🇳", Continent = "شمال آفریقا (MENA)",
            QualityOfLifeScore = 55, SafetyScore = 65, HealthcareScore = 52, EducationScore = 55,
            EconomicOpportunityScore = 45, PoliticalStabilityScore = 52, ClimateScore = 78,
            CostOfLivingIndex = 25, AverageRentUSD = 200, AverageSalaryUSD = 450,
            OfficialLanguages = new() { "عربی", "فرانسوی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 100, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "مدیترانه‌ای", DistanceFromIranKm = 5000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار / اقامت", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "پیشنهاد شغلی یا ثبت شرکت", "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "هزینه زندگی پایین", "آب‌وهوای مدیترانه‌ای", "نزدیکی به اروپا", "فرهنگ غنی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "اقتصاد ضعیف", "بازار کار محدود", "فاصله از ایران", "زبان فرانسوی" }
        },

        // ═══════════ لیبی ═══════════
        new Country
        {
            Name = "Libya", NamePersian = "لیبی", FlagEmoji = "🇱🇾", Continent = "شمال آفریقا (MENA)",
            QualityOfLifeScore = 35, SafetyScore = 20, HealthcareScore = 25, EducationScore = 30,
            EconomicOpportunityScore = 30, PoliticalStabilityScore = 15, ClimateScore = 55,
            CostOfLivingIndex = 28, AverageRentUSD = 200, AverageSalaryUSD = 500,
            OfficialLanguages = new() { "عربی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = false,
            IranianPopulation = 100, HasIranianCommunity = false,
            HealthcareSystem = "آسیب‌دیده", UniversalHealthcare = false,
            EducationSystemQuality = "ضعیف", FreeEducation = true,
            Climate = "صحرایی/مدیترانه‌ای", DistanceFromIranKm = 4000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new(),
            Restrictions = new() { "جنگ داخلی", "ناامنی شدید", "بی‌ثباتی سیاسی", "عدم توصیه برای مهاجرت" }
        },

        // ═══════════ یمن ═══════════
        new Country
        {
            Name = "Yemen", NamePersian = "یمن", FlagEmoji = "🇾🇪", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 20, SafetyScore = 10, HealthcareScore = 15, EducationScore = 20,
            EconomicOpportunityScore = 10, PoliticalStabilityScore = 8, ClimateScore = 55,
            CostOfLivingIndex = 15, AverageRentUSD = 80, AverageSalaryUSD = 150,
            OfficialLanguages = new() { "عربی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = false,
            IranianPopulation = 50, HasIranianCommunity = false,
            HealthcareSystem = "آسیب‌دیده", UniversalHealthcare = false,
            EducationSystemQuality = "بسیار ضعیف", FreeEducation = true,
            Climate = "صحرایی/نیمه‌گرمسیری", DistanceFromIranKm = 2000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new(),
            Restrictions = new() { "جنگ داخلی فعال", "بحران انسانی", "ناامنی مطلق", "عدم امکان مهاجرت" }
        },

        // ═══════════ فلسطین ═══════════
        new Country
        {
            Name = "Palestine", NamePersian = "فلسطین", FlagEmoji = "🇵🇸", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 30, SafetyScore = 15, HealthcareScore = 30, EducationScore = 35,
            EconomicOpportunityScore = 20, PoliticalStabilityScore = 10, ClimateScore = 72,
            CostOfLivingIndex = 25, AverageRentUSD = 200, AverageSalaryUSD = 350,
            OfficialLanguages = new() { "عربی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 0, AllowsDualCitizenship = false,
            IranianPopulation = 0, HasIranianCommunity = false,
            HealthcareSystem = "آسیب‌دیده", UniversalHealthcare = false,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "مدیترانه‌ای", DistanceFromIranKm = 1500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new(),
            Restrictions = new() { "اشغال نظامی", "عدم استقلال سیاسی", "ناامنی", "محدودیت حرکت" }
        },

        // ═══════════ اسرائیل ═══════════
        new Country
        {
            Name = "Israel", NamePersian = "اسرائیل", FlagEmoji = "🇮🇱", Continent = "خاورمیانه (MENA)",
            QualityOfLifeScore = 80, SafetyScore = 55, HealthcareScore = 85, EducationScore = 85,
            EconomicOpportunityScore = 82, PoliticalStabilityScore = 55, ClimateScore = 75,
            CostOfLivingIndex = 75, AverageRentUSD = 1400, AverageSalaryUSD = 3800,
            OfficialLanguages = new() { "عبری" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 500, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "مدیترانه‌ای/صحرایی", DistanceFromIranKm = 1500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار تخصصی (Hi-Tech)", Type = "اقامت موقت", Duration = "تا ۵ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinExperienceYears = 2,
                    Requirements = new() { "پیشنهاد شغلی در حوزه فناوری", "مهارت‌های تخصصی", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اکوسیستم استارتاپی قوی", "حقوق بالا", "صنعت فناوری پیشرفته", "دسترسی به مدیترانه" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "وضعیت سیاسی پیچیده", "هزینه زندگی بالا", "درگیری‌های منطقه‌ای", "محدودیت برای ایرانیان" }
        }
    };
}
