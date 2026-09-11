using ImmigrantAdvisor.Shared.Models;

namespace ImmigrantAdvisor.Shared.Data;

// داده‌های حوزه CIS (کشورهای مستقل همسود) - بروزرسانی August/September 2026
// شامل ۱۲ کشور
public static class CisCountryData
{
    public static List<Country> GetCountries() => new()
    {
        // ═══════════ روسیه ═══════════
        new Country
        {
            Name = "Russia", NamePersian = "روسیه", FlagEmoji = "🇷🇺", Continent = "اروپا/آسیا (CIS)",
            QualityOfLifeScore = 62, SafetyScore = 50, HealthcareScore = 60, EducationScore = 72,
            EconomicOpportunityScore = 60, PoliticalStabilityScore = 45, ClimateScore = 35,
            CostOfLivingIndex = 40, AverageRentUSD = 600, AverageSalaryUSD = 1500,
            OfficialLanguages = new() { "روسی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 20000, HasIranianCommunity = true,
            HealthcareSystem = "بیمه اجباری (OMS)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "قاره‌ای سرد", DistanceFromIranKm = 2500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار (HVS - مجوز کار واجد شرایط بالا)", Type = "اقامت موقت - منجر به دائم", Duration = "تا ۳ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinExperienceYears = 2,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار از FMS", "مدرک زبان روسی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "حقوق مناسب" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "پذیرش از دانشگاه روسی", "تمکن مالی (~۳۰۰ دلار/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه پایین", "بورسیه دولتی موجود", "ویزای کار پس از تحصیل", "دانشگاه‌های معتبر" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "وضعیت سیاسی ناپایدار", "تحریم‌های بین‌المللی", "نیاز به زبان روسی", "بوروکراسی پیچیده" }
        },

        // ═══════════ اوکراین ═══════════
        new Country
        {
            Name = "Ukraine", NamePersian = "اوکراین", FlagEmoji = "🇺🇦", Continent = "اروپا (CIS)",
            QualityOfLifeScore = 55, SafetyScore = 25, HealthcareScore = 50, EducationScore = 65,
            EconomicOpportunityScore = 45, PoliticalStabilityScore = 25, ClimateScore = 52,
            CostOfLivingIndex = 30, AverageRentUSD = 300, AverageSalaryUSD = 1000,
            OfficialLanguages = new() { "اوکراینی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = false,
            IranianPopulation = 3000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه دولتی", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "قاره‌ای معتدل", DistanceFromIranKm = 2000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "هزینه زندگی بسیار پایین", "اقامت موقت", "الحاق خانواده", "مسیر به اقامت دائم" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی (~۲۰۰ دلار/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه بسیار پایین", "هزینه زندگی پایین", "ویزای کار پس از تحصیل", "فرصت بازسازی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "جنگ فعال - خطر امنیتی بالا", "وضعیت سیاسی ناپایدار", "زیرساخت آسیب‌دیده", "عدم توصیه برای مهاجرت" }
        },

        // ═══════════ بلاروس ═══════════
        new Country
        {
            Name = "Belarus", NamePersian = "بلاروس", FlagEmoji = "🇧🇾", Continent = "اروپا (CIS)",
            QualityOfLifeScore = 55, SafetyScore = 55, HealthcareScore = 58, EducationScore = 65,
            EconomicOpportunityScore = 45, PoliticalStabilityScore = 35, ClimateScore = 40,
            CostOfLivingIndex = 32, AverageRentUSD = 300, AverageSalaryUSD = 900,
            OfficialLanguages = new() { "بلاروسی", "روسی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 7, AllowsDualCitizenship = false,
            IranianPopulation = 1000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه دولتی", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "قاره‌ای معتدل", DistanceFromIranKm = 2800,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "هزینه زندگی پایین", "اقامت موقت", "نزدیکی به EU", "مسیر به اقامت دائم" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه پایین", "هزینه زندگی پایین", "تحصیل به روسی", "ویزای کار پس از تحصیل" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "وضعیت سیاسی ناپایدار", "تحریم‌های بین‌المللی", "عدم اجازه تابعیت دوگانه", "بوروکراسی" }
        },

        // ═══════════ گرجستان ═══════════
        new Country
        {
            Name = "Georgia", NamePersian = "گرجستان", FlagEmoji = "🇬🇪", Continent = "قفقاز (CIS)",
            QualityOfLifeScore = 65, SafetyScore = 72, HealthcareScore = 60, EducationScore = 65,
            EconomicOpportunityScore = 55, PoliticalStabilityScore = 60, ClimateScore = 75,
            CostOfLivingIndex = 30, AverageRentUSD = 350, AverageSalaryUSD = 800,
            OfficialLanguages = new() { "گرجی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = false,
            IranianPopulation = 2000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه همگانی", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "نیمه‌گرمسیری/قاره‌ای", DistanceFromIranKm = 800,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پیشنهاد شغلی یا ثبت شرکت", "بیمه درمانی", "عدم سوءپیشینه", "تمکن مالی" },
                    Benefits = new() { "مالیات پایین (۲۰٪ و ۱٪ برای کسب‌وکار کوچک)", "هزینه زندگی پایین", "نزدیکی به ایران", "آب‌وهوای خوب" },
                    ProcessingTimeMonths = 1, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی (~۲۰۰ دلار/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه پایین", "هزینه زندگی پایین", "نزدیکی به ایران", "فرهنگ نزدیک" },
                    ProcessingTimeMonths = 1, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "تابعیت پس از ۱۰ سال", "عدم اجازه تابعیت دوگانه", "بازار کار کوچک", "زبان گرجی" }
        },

        // ═══════════ ارمنستان ═══════════
        new Country
        {
            Name = "Armenia", NamePersian = "ارمنستان", FlagEmoji = "🇦🇲", Continent = "قفقاز (CIS)",
            QualityOfLifeScore = 60, SafetyScore = 68, HealthcareScore = 55, EducationScore = 62,
            EconomicOpportunityScore = 48, PoliticalStabilityScore = 55, ClimateScore = 70,
            CostOfLivingIndex = 28, AverageRentUSD = 300, AverageSalaryUSD = 700,
            OfficialLanguages = new() { "ارمنی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 3, AllowsDualCitizenship = true,
            IranianPopulation = 5000, HasIranianCommunity = true,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "قاره‌ای خشک", DistanceFromIranKm = 600,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار / اقامت", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "ثبت شرکت یا پیشنهاد شغلی", "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "تابعیت آسان (۳ سال)", "مالیات پایین", "نزدیکی به ایران", "جامعه ایرانی", "تابعیت دوگانه مجاز" },
                    ProcessingTimeMonths = 1, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه پایین", "نزدیکی به ایران", "فرهنگ نزدیک", "مسیر تابعیت" },
                    ProcessingTimeMonths = 1, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "بازار کار کوچک", "اقتصاد ضعیف", "تنش‌های منطقه‌ای با آذربایجان", "زبان ارمنی" }
        },

        // ═══════════ آذربایجان ═══════════
        new Country
        {
            Name = "Azerbaijan", NamePersian = "آذربایجان", FlagEmoji = "🇦🇿", Continent = "قفقاز (CIS)",
            QualityOfLifeScore = 58, SafetyScore = 70, HealthcareScore = 52, EducationScore = 58,
            EconomicOpportunityScore = 52, PoliticalStabilityScore = 55, ClimateScore = 72,
            CostOfLivingIndex = 30, AverageRentUSD = 350, AverageSalaryUSD = 800,
            OfficialLanguages = new() { "آذربایجانی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = false,
            IranianPopulation = 1000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "نیمه‌خشک تا معتدل", DistanceFromIranKm = 300,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "نزدیکی به ایران", "هزینه زندگی پایین", "صنعت نفت و گاز", "آب‌وهوای مناسب" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه پایین", "نزدیکی به ایران", "صنعت انرژی", "فرهنگ نزدیک" },
                    ProcessingTimeMonths = 1, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "عدم اجازه تابعیت دوگانه", "تنش با ارمنستان", "بازار کار محدود", "زبان آذربایجانی" }
        },

        // ═══════════ قزاقستان ═══════════
        new Country
        {
            Name = "Kazakhstan", NamePersian = "قزاقستان", FlagEmoji = "🇰🇿", Continent = "آسیای مرکزی (CIS)",
            QualityOfLifeScore = 60, SafetyScore = 68, HealthcareScore = 55, EducationScore = 62,
            EconomicOpportunityScore = 58, PoliticalStabilityScore = 58, ClimateScore = 30,
            CostOfLivingIndex = 32, AverageRentUSD = 350, AverageSalaryUSD = 1000,
            OfficialLanguages = new() { "قزاقی", "روسی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = false,
            IranianPopulation = 2000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "قاره‌ای شدید", DistanceFromIranKm = 2000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "تا ۳ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "صنعت نفت و معدن", "حقوق مناسب", "هزینه زندگی پایین", "مسیر به اقامت دائم" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "بورسیه دولتی", "شهریه پایین", "صنعت انرژی", "ویزای کار پس از تحصیل" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "عدم اجازه تابعیت دوگانه", "آب‌وهوای شدید", "نیاز به زبان روسی/قزاقی", "بوروکراسی" }
        },

        // ═══════════ ازبکستان ═══════════
        new Country
        {
            Name = "Uzbekistan", NamePersian = "ازبکستان", FlagEmoji = "🇺🇿", Continent = "آسیای مرکزی (CIS)",
            QualityOfLifeScore = 55, SafetyScore = 70, HealthcareScore = 48, EducationScore = 55,
            EconomicOpportunityScore = 50, PoliticalStabilityScore = 55, ClimateScore = 60,
            CostOfLivingIndex = 22, AverageRentUSD = 200, AverageSalaryUSD = 600,
            OfficialLanguages = new() { "ازبکی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = false,
            IranianPopulation = 1000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه دولتی", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "قاره‌ای خشک", DistanceFromIranKm = 1500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "هزینه زندگی بسیار پایین", "اقتصاد در حال رشد", "فرصت‌های سرمایه‌گذاری", "نزدیکی فرهنگی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه بسیار پایین", "هزینه زندگی پایین", "فرصت‌های آموزشی", "فرهنگ نزدیک" },
                    ProcessingTimeMonths = 1, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "عدم اجازه تابعیت دوگانه", "بازار کار محدود", "زبان ازبکی", "اقتصاد در حال توسعه" }
        },

        // ═══════════ مولداوی ═══════════
        new Country
        {
            Name = "Moldova", NamePersian = "مولداوی", FlagEmoji = "🇲🇩", Continent = "اروپا (CIS)",
            QualityOfLifeScore = 52, SafetyScore = 62, HealthcareScore = 48, EducationScore = 55,
            EconomicOpportunityScore = 42, PoliticalStabilityScore = 50, ClimateScore = 58,
            CostOfLivingIndex = 25, AverageRentUSD = 200, AverageSalaryUSD = 600,
            OfficialLanguages = new() { "رومانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = true,
            IranianPopulation = 200, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "قاره‌ای معتدل", DistanceFromIranKm = 2500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار / اقامت", Type = "اقامت موقت", Duration = "۱ تا ۵ سال",
                    Requirements = new() { "پیشنهاد شغلی یا ثبت شرکت", "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "هزینه زندگی بسیار پایین", "مسیر به عضویت EU (نامزد)", "تابعیت دوگانه مجاز", "نزدیکی به اروپا" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "فقیرترین کشور اروپا", "بازار کار بسیار محدود", "فساد اداری", "بی‌ثباتی سیاسی" }
        },

        // ═══════════ تاجیکستان ═══════════
        new Country
        {
            Name = "Tajikistan", NamePersian = "تاجیکستان", FlagEmoji = "🇹🇯", Continent = "آسیای مرکزی (CIS)",
            QualityOfLifeScore = 48, SafetyScore = 60, HealthcareScore = 40, EducationScore = 48,
            EconomicOpportunityScore = 38, PoliticalStabilityScore = 45, ClimateScore = 55,
            CostOfLivingIndex = 20, AverageRentUSD = 150, AverageSalaryUSD = 400,
            OfficialLanguages = new() { "تاجیکی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = false,
            IranianPopulation = 500, HasIranianCommunity = false,
            HealthcareSystem = "بیمه دولتی", UniversalHealthcare = true,
            EducationSystemQuality = "ضعیف", FreeEducation = true,
            Climate = "قاره‌ای خشک", DistanceFromIranKm = 1200,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "هزینه زندگی بسیار پایین", "زبان نزدیک به فارسی", "نزدیکی به ایران", "فرهنگ مشترک" },
                    ProcessingTimeMonths = 1, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "فقر بالا", "زیرساخت ضعیف", "عدم اجازه تابعیت دوگانه", "بازار کار بسیار محدود" }
        },

        // ═══════════ ترکمنستان ═══════════
        new Country
        {
            Name = "Turkmenistan", NamePersian = "ترکمنستان", FlagEmoji = "🇹🇲", Continent = "آسیای مرکزی (CIS)",
            QualityOfLifeScore = 45, SafetyScore = 65, HealthcareScore = 42, EducationScore = 45,
            EconomicOpportunityScore = 35, PoliticalStabilityScore = 40, ClimateScore = 50,
            CostOfLivingIndex = 22, AverageRentUSD = 200, AverageSalaryUSD = 500,
            OfficialLanguages = new() { "ترکمنی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = false,
            IranianPopulation = 500, HasIranianCommunity = false,
            HealthcareSystem = "دولتی", UniversalHealthcare = true,
            EducationSystemQuality = "ضعیف", FreeEducation = true,
            Climate = "صحرایی خشک", DistanceFromIranKm = 500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار و اقامت", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "صنعت گاز", "نزدیکی به ایران", "هزینه زندگی پایین", "فرهنگ نزدیک" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "کشور بسته و ایزوله", "عدم اجازه تابعیت دوگانه", "حکومت اقتدارگرا", "محدودیت‌های شدید" }
        },

        // ═══════════ قرقیزستان ═══════════
        new Country
        {
            Name = "Kyrgyzstan", NamePersian = "قرقیزستان", FlagEmoji = "🇰🇬", Continent = "آسیای مرکزی (CIS)",
            QualityOfLifeScore = 50, SafetyScore = 58, HealthcareScore = 42, EducationScore = 50,
            EconomicOpportunityScore = 40, PoliticalStabilityScore = 45, ClimateScore = 55,
            CostOfLivingIndex = 20, AverageRentUSD = 150, AverageSalaryUSD = 400,
            OfficialLanguages = new() { "قرقیزی", "روسی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = false,
            IranianPopulation = 200, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "قاره‌ای خشک", DistanceFromIranKm = 1800,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار / سرمایه‌گذاری", Type = "اقامت موقت", Duration = "۱ تا ۳ سال",
                    Requirements = new() { "ثبت شرکت یا پیشنهاد شغلی", "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "هزینه زندگی بسیار پایین", "فرصت‌های سرمایه‌گذاری", "طبیعت زیبا", "نزدیکی فرهنگی" },
                    ProcessingTimeMonths = 1, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "فقر بالا", "بی‌ثباتی سیاسی", "زیرساخت ضعیف", "بازار کار محدود" }
        }
    };
}
