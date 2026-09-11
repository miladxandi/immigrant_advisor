using ImmigrantAdvisor.Shared.Models;

namespace ImmigrantAdvisor.Shared.Data;

// داده‌های اتحادیه اروپا - بروزرسانی August/September 2026
// شامل ۲۷ کشور عضو اتحادیه اروپا
public static class EuCountryData
{
    public static List<Country> GetCountries() => new()
    {
        // ═══════════ آلمان (بروزرسانی 2026 - Chancenkarte) ═══════════
        new Country
        {
            Name = "Germany", NamePersian = "آلمان", FlagEmoji = "🇩🇪", Continent = "اروپا",
            QualityOfLifeScore = 90, SafetyScore = 85, HealthcareScore = 92, EducationScore = 90,
            EconomicOpportunityScore = 84, PoliticalStabilityScore = 88, ClimateScore = 55,
            CostOfLivingIndex = 65, AverageRentUSD = 1300, AverageSalaryUSD = 4500,
            OfficialLanguages = new() { "آلمانی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 55000, HasIranianCommunity = true,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "معتدل قاره‌ای", DistanceFromIranKm = 3500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت اتحادیه اروپا (Blaue Karte EU) - بروزرسانی 2026",
                    Type = "اقامت موقت - منجر به دائم", Duration = "۱ تا ۴ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 3200,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی با حقوق حداقلی ۳۲۰۰ یورو/ماه (2026)", "مدرک زبان A1", "شغل در لیست مشاغل مورد نیاز" },
                    Benefits = new() { "اقامت سریع (۲۱ ماه با B1)", "حرکت آزاد در EU", "الحاق خانواده آسان", "حقوق بالاتر از میانگین" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "کارت شانس (Chancenkarte) - جدید 2024/2026",
                    Type = "موقت - جستجوی کار", Duration = "۱ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "مدرک دانشگاهی یا فنی‌حرفه‌ای", "سیستم امتیازبندی (۶ از ۱۰)", "زبان A1 آلمانی یا B2 انگلیسی", "تمکن مالی" },
                    Benefits = new() { "امکان جستجوی کار ۱ ساله", "کار پاره‌وقت ۲۰ ساعت/هفته", "بدون نیاز به پیشنهاد شغلی اولیه", "تبدیل به ویزای کار" },
                    ProcessingTimeMonths = 3, LeadsToPR = false, LeadsToCitizenship = false
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت - منجر به اقامت", Duration = "۲ تا ۳ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه آلمانی", "تمکن مالی (حساب مسدود ~۱۱,۹۰۰ یورو - 2026)", "مدرک B2 آلمانی یا IELTS 6.5", "بیمه درمانی" },
                    Benefits = new() { "تحصیل رایگان در دانشگاه‌های دولتی", "اجازه کار ۱۲۰ روز کامل", "ویزای کار ۱۸ ماهه پس از فارغ‌التحصیلی", "مسیر هموار به اقامت دائم" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای کار تخصصی (Fachkräfte)", Type = "اقامت موقت - منجر به دائم", Duration = "۱ تا ۴ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Intermediate,
                    MinExperienceYears = 2,
                    Requirements = new() { "مدرک دانشگاهی یا فنی‌حرفه‌ای معتبر", "پیشنهاد شغلی مرتبط", "مدرک زبان B1", "تطابق مدرک با شغل" },
                    Benefits = new() { "اقامت کار تا ۴ سال", "الحاق خانواده", "مسیر به اقامت دائم پس از ۴ سال", "دسترسی به سیستم بهداشتی عالی" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "نیاز به یادگیری زبان آلمانی", "فرآیند معادل‌سازی مدارک پیچیده", "مالیات بالا (تا ۴۵٪)" }
        },

        // ═══════════ فرانسه ═══════════
        new Country
        {
            Name = "France", NamePersian = "فرانسه", FlagEmoji = "🇫🇷", Continent = "اروپا",
            QualityOfLifeScore = 87, SafetyScore = 72, HealthcareScore = 90, EducationScore = 88,
            EconomicOpportunityScore = 78, PoliticalStabilityScore = 78, ClimateScore = 65,
            CostOfLivingIndex = 68, AverageRentUSD = 1200, AverageSalaryUSD = 3800,
            OfficialLanguages = new() { "فرانسوی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 30000, HasIranianCommunity = true,
            HealthcareSystem = "همگانی (Assurance Maladie)", UniversalHealthcare = true,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "اقیانوسی معتدل", DistanceFromIranKm = 4000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "پاسپورت تلنت (Passeport Talent) - بروزرسانی 2026",
                    Type = "اقامت موقت - منجر به دائم", Duration = "۴ سال",
                    MinEducation = EducationLevel.MasterDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 3,
                    Requirements = new() { "مدرک حداقل فوق‌لیسانس", "پیشنهاد شغلی با حقوق حداقل ۴۲,۰۰۰ یورو/سال (2026)", "طرح تحقیقاتی یا نوآورانه", "مدرک زبان A2 فرانسوی" },
                    Benefits = new() { "اقامت ۴ ساله", "الحاق خانواده خودکار", "مسیر سریع به اقامت دائم", "دسترسی به شنگن" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای کار (Salarié Qualifié)", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 1,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار از DIRECCTE", "مدرک زبان A2", "تمکن مالی" },
                    Benefits = new() { "اقامت کاری", "الحاق خانواده", "مسیر به اقامت دائم", "دسترسی به بهداشت همگانی" },
                    ProcessingTimeMonths = 4, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی (Étudiant)", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه فرانسوی", "تمکن مالی (~۶۱۵ یورو/ماه)", "مدرک B1 فرانسوی یا B2 انگلیسی", "بیمه درمانی" },
                    Benefits = new() { "شهریه پایین دانشگاه‌های دولتی", "اجازه کار پاره‌وقت", "ویزای جستجوی کار ۱ ساله", "امکان تابعیت پس از ۲ سال تحصیل" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای فریلنسر/خوداشتغال (Profession Libérale)", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    MinIncomeUSD = 2000,
                    Requirements = new() { "طرح کسب‌وکاری", "اثبات درآمد حداقل ۲,۰۰۰ یورو/ماه", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "امکان کار آزاد", "مسیر به اقامت دائم", "کیفیت زندگی بالا", "دسترسی به شنگن" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "نیاز به یادگیری زبان فرانسوی", "بوروکراسی پیچیده", "امنیت در برخی مناطق", "مالیات بالا" }
        },

        // ═══════════ اتریش ═══════════
        new Country
        {
            Name = "Austria", NamePersian = "اتریش", FlagEmoji = "🇦🇹", Continent = "اروپا",
            QualityOfLifeScore = 91, SafetyScore = 88, HealthcareScore = 90, EducationScore = 87,
            EconomicOpportunityScore = 78, PoliticalStabilityScore = 90, ClimateScore = 55,
            CostOfLivingIndex = 65, AverageRentUSD = 1100, AverageSalaryUSD = 4000,
            OfficialLanguages = new() { "آلمانی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = false,
            IranianPopulation = 15000, HasIranianCommunity = true,
            HealthcareSystem = "بیمه اجتماعی", UniversalHealthcare = true,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "قاره‌ای/آلپی", DistanceFromIranKm = 3200,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU (Rot-Weiß-Rot – Karte)", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 3000,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک A1 آلمانی", "شغل در لیست مشاغل مورد نیاز" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم پس از ۲ سال", "کیفیت زندگی بسیار بالا" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱۲ ماه",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه اتریشی", "تمکن مالی (~۱,۱۰۰ یورو/ماه)", "مدرک B1 آلمانی", "بیمه درمانی" },
                    Benefits = new() { "تحصیل رایگان یا کم‌هزینه", "اجازه کار پاره‌وقت", "ویزای کار پس از فارغ‌التحصیلی", "کیفیت زندگی عالی" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای خوداشتغالی (Selbständiger)", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    MinInvestmentUSD = 50000,
                    Requirements = new() { "طرح کسب‌وکاری معتبر", "تمکن مالی", "سابقه کار مرتبط", "محل فعالیت" },
                    Benefits = new() { "امکان راه‌اندازی کسب‌وکار", "الحاق خانواده", "مسیر به اقامت دائم", "اکوسیستم کسب‌وکار قوی" },
                    ProcessingTimeMonths = 4, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "تابعیت پس از ۱۰ سال (طولانی)", "عدم اجازه تابعیت دوگانه", "نیاز به زبان آلمانی", "هزینه زندگی بالا" }
        },

        // ═══════════ بلژیک ═══════════
        new Country
        {
            Name = "Belgium", NamePersian = "بلژیک", FlagEmoji = "🇧🇪", Continent = "اروپا",
            QualityOfLifeScore = 86, SafetyScore = 78, HealthcareScore = 88, EducationScore = 85,
            EconomicOpportunityScore = 76, PoliticalStabilityScore = 82, ClimateScore = 55,
            CostOfLivingIndex = 65, AverageRentUSD = 1100, AverageSalaryUSD = 3800,
            OfficialLanguages = new() { "هلندی", "فرانسوی", "آلمانی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 8000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "اقیانوسی معتدل", DistanceFromIranKm = 4000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۱ تا ۴ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 3500,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی با حقوق حداقلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "دسترسی به شنگن" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه بلژیکی", "تمکن مالی (~۸00 یورو/ماه)", "مدرک زبان", "بیمه درمانی" },
                    Benefits = new() { "شهریه پایین", "اجازه کار پاره‌وقت", "ویزای جستجوی کار", "محیط چندزبانه" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای حرفه‌ای (Carte Professionnelle)", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    MinIncomeUSD = 2000,
                    Requirements = new() { "طرح کسب‌وکاری", "اثبات درآمد", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "امکان کار آزاد", "مسیر به اقامت دائم", "موقعیت مرکزی اروپا", "دسترسی به شنگن" },
                    ProcessingTimeMonths = 4, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "سیستم سیاسی پیچیده", "نیاز به یادگیری زبان محلی", "مالیات بسیار بالا", "آب‌وهوای ابری" }
        },

        // ═══════════ دانمارک ═══════════
        new Country
        {
            Name = "Denmark", NamePersian = "دانمارک", FlagEmoji = "🇩🇰", Continent = "اروپا",
            QualityOfLifeScore = 92, SafetyScore = 90, HealthcareScore = 88, EducationScore = 90,
            EconomicOpportunityScore = 78, PoliticalStabilityScore = 92, ClimateScore = 40,
            CostOfLivingIndex = 72, AverageRentUSD = 1200, AverageSalaryUSD = 4200,
            OfficialLanguages = new() { "دانمارکی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 9, AllowsDualCitizenship = true,
            IranianPopulation = 15000, HasIranianCommunity = true,
            HealthcareSystem = "همگانی رایگان", UniversalHealthcare = true,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "شمالی سرد و بادی", DistanceFromIranKm = 3800,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU / ویزای کار مثبت", Type = "اقامت موقت - منجر به دائم", Duration = "۱ تا ۴ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2,
                    Requirements = new() { "پیشنهاد شغلی با حقوق حداقلی", "مدرک دانشگاهی", "مدرک زبان", "شغل در لیست مثبت" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم پس از ۴ سال", "کیفیت زندگی بسیار بالا" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۳ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه دانمارکی", "تمکن مالی (~۹۰۰ یورو/ماه)", "زبان انگلیسی یا دانمارکی", "بیمه درمانی" },
                    Benefits = new() { "تحصیل رایگان برای EU", "ویزای کار ۳ ساله پس از فارغ‌التحصیلی", "تحصیل به انگلیسی", "کیفیت آموزش عالی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای استارتاپ", Type = "اقامت موقت", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new() { "ایده نوآورانه", "تأییدیه از هیئت استارتاپ دانمارک", "طرح کسب‌وکاری", "تمکن مالی" },
                    Benefits = new() { "اقامت ۲ ساله", "دسترسی به اکوسیستم نوآوری", "الحاق خانواده", "مسیر به اقامت دائم" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "تابعیت پس از ۹ سال", "هزینه زندگی بسیار بالا", "نیاز به زبان دانمارکی", "آب‌وهوای سرد" }
        },

        // ═══════════ فنلاند ═══════════
        new Country
        {
            Name = "Finland", NamePersian = "فنلاند", FlagEmoji = "🇫🇮", Continent = "اروپا",
            QualityOfLifeScore = 93, SafetyScore = 92, HealthcareScore = 87, EducationScore = 93,
            EconomicOpportunityScore = 76, PoliticalStabilityScore = 92, ClimateScore = 30,
            CostOfLivingIndex = 68, AverageRentUSD = 1000, AverageSalaryUSD = 3800,
            OfficialLanguages = new() { "فنلاندی", "سوئدی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 12000, HasIranianCommunity = true,
            HealthcareSystem = "همگانی یارانه‌ای", UniversalHealthcare = true,
            EducationSystemQuality = "بهترین در جهان", FreeEducation = true,
            Climate = "شمالی سرد", DistanceFromIranKm = 3500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU / ویزای کار متخصص", Type = "اقامت موقت - منجر به دائم", Duration = "۲ تا ۴ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2,
                    Requirements = new() { "پیشنهاد شغلی", "مدرک دانشگاهی", "مدرک زبان", "حقوق حداقلی" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر سریع به اقامت دائم", "شادترین کشور جهان" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای استارتاپ", Type = "اقامت موقت", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new() { "ایده نوآورانه", "تأیید Business Finland", "طرح کسب‌وکاری", "تمکن مالی" },
                    Benefits = new() { "اقامت ۲ ساله", "اکوسیستم نوآوری قوی", "الحاق خانواده", "مسیر به اقامت دائم" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۲ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه فنلاندی", "تمکن مالی (~۱,۰۰۰ یورو/ماه)", "زبان انگلیسی یا فنلاندی", "بیمه درمانی" },
                    Benefits = new() { "تحصیل رایگان (EU) یا کم‌هزینه", "ویزای کار ۲ ساله", "بهترین سیستم آموزشی جهان", "امنیت بالا" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "آب‌وهوای بسیار سرد", "زبان فنلاندی دشوار", "بازار کار کوچک", "فاصله از ایران" }
        },

        // ═══════════ ایرلند ═══════════
        new Country
        {
            Name = "Ireland", NamePersian = "ایرلند", FlagEmoji = "🇮🇪", Continent = "اروپا",
            QualityOfLifeScore = 87, SafetyScore = 82, HealthcareScore = 80, EducationScore = 88,
            EconomicOpportunityScore = 82, PoliticalStabilityScore = 85, ClimateScore = 50,
            CostOfLivingIndex = 72, AverageRentUSD = 1600, AverageSalaryUSD = 4200,
            OfficialLanguages = new() { "انگلیسی", "ایرلندی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 8000, HasIranianCommunity = false,
            HealthcareSystem = "همگانی (HSE)", UniversalHealthcare = true,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "اقیانوسی معتدل", DistanceFromIranKm = 4800,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار تخصصی (Critical Skills)", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Intermediate,
                    MinExperienceYears = 2, MinIncomeUSD = 3500,
                    Requirements = new() { "پیشنهاد شغلی در مشاغل حیاتی", "حداقل حقوق ۳۸,۰۰۰ یورو (2026)", "مدرک دانشگاهی", "زبان انگلیسی" },
                    Benefits = new() { "اقامت کار ۲ ساله", "الحاق خانواده فوری", "مسیر سریع به اقامت دائم (Stamp 4)", "زبان انگلیسی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای استارتاپ (STEP)", Type = "اقامت موقت", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new() { "ایده نوآورانه", "تأییدیه Enterprise Ireland", "طرح کسب‌وکاری", "تمکن مالی" },
                    Benefits = new() { "اقامت ۲ ساله", "اکوسیستم نوآوری قوی", "زبان انگلیسی", "مسیر به اقامت دائم" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۲ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Advanced,
                    Requirements = new() { "پذیرش از دانشگاه ایرلندی", "تمکن مالی (~۱۰,۰۰۰ یورو/سال)", "IELTS 6.5+", "بیمه درمانی" },
                    Benefits = new() { "تحصیل به انگلیسی", "ویزای کار ۲ ساله (Stay Back)", "اجازه کار پاره‌وقت", "صنعت فناوری قوی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "بحران مسکن شدید", "هزینه زندگی بالا", "بازار کار رقابتی", "آب‌وهوای بارانی" }
        },

        // ═══════════ ایتالیا ═══════════
        new Country
        {
            Name = "Italy", NamePersian = "ایتالیا", FlagEmoji = "🇮🇹", Continent = "اروپا",
            QualityOfLifeScore = 82, SafetyScore = 72, HealthcareScore = 82, EducationScore = 78,
            EconomicOpportunityScore = 65, PoliticalStabilityScore = 70, ClimateScore = 75,
            CostOfLivingIndex = 55, AverageRentUSD = 900, AverageSalaryUSD = 2800,
            OfficialLanguages = new() { "ایتالیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = true,
            IranianPopulation = 12000, HasIranianCommunity = true,
            HealthcareSystem = "همگانی (SSN)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "مدیترانه‌ای", DistanceFromIranKm = 3500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 2800,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی با حقوق حداقلی", "مدرک A2 ایتالیایی", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "کیفیت زندگی بالا" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای خوداشتغالی (Lavoro Autonomo)", Type = "اقامت موقت", Duration = "۲ سال",
                    MinIncomeUSD = 1500,
                    Requirements = new() { "طرح کسب‌وکاری", "تمکن مالی", "مجوز از Questura", "محل فعالیت" },
                    Benefits = new() { "امکان کار آزاد", "هزینه زندگی پایین", "آب‌وهوای عالی", "مسیر به اقامت دائم" },
                    ProcessingTimeMonths = 4, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه ایتالیایی", "تمکن مالی", "مدرک زبان", "بیمه درمانی" },
                    Benefits = new() { "شهریه پایین", "اجازه کار پاره‌وقت", "فرهنگ غنی", "ویزای تبدیل به کار" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "تابعیت پس از ۱۰ سال", "بازار کار ضعیف", "بوروکراسی کند", "نیاز به زبان ایتالیایی" }
        },

        // ═══════════ اسپانیا ═══════════
        new Country
        {
            Name = "Spain", NamePersian = "اسپانیا", FlagEmoji = "🇪🇸", Continent = "اروپا",
            QualityOfLifeScore = 83, SafetyScore = 75, HealthcareScore = 85, EducationScore = 80,
            EconomicOpportunityScore = 68, PoliticalStabilityScore = 75, ClimateScore = 85,
            CostOfLivingIndex = 52, AverageRentUSD = 900, AverageSalaryUSD = 2600,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = true,
            IranianPopulation = 8000, HasIranianCommunity = false,
            HealthcareSystem = "همگانی (SNS)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "مدیترانه‌ای", DistanceFromIranKm = 4800,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 2500,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "آب‌وهوای عالی" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای دیجیتال نومد (Digital Nomad) - 2026", Type = "اقامت موقت", Duration = "۳ سال",
                    MinIncomeUSD = 2800,
                    Requirements = new() { "کار ریموت برای شرکت غیراسپانیایی", "درآمد حداقل ۲,۸۰۰ یورو/ماه (2026)", "بیمه درمانی خصوصی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت ۳ ساله", "مالیات ویژه ۲۴٪", "امکان الحاق خانواده", "آب‌وهوای مدیترانه‌ای" },
                    ProcessingTimeMonths = 2, LeadsToPR = false, LeadsToCitizenship = false
                },
                new VisaOption
                {
                    Name = "ویزای غیرانتفاعی (Visado No Lucrativo)", Type = "اقامت موقت", Duration = "۲ سال",
                    MinIncomeUSD = 2400,
                    Requirements = new() { "درآمد غیرفعال حداقل ۲۸,۸۰۰ یورو/سال (2026)", "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت بدون کار", "مسیر به اقامت دائم", "هزینه زندگی پایین", "آب‌وهوای عالی" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه اسپانیایی", "تمکن مالی", "مدرک زبان", "بیمه درمانی" },
                    Benefits = new() { "شهریه پایین", "اجازه کار پاره‌وقت", "امکان تبدیل به ویزای کار", "فرهنگ غنی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "تابعیت پس از ۱۰ سال", "بازار کار ضعیف (بیکاری بالا)", "نیاز به زبان اسپانیایی", "بوروکراسی کند" }
        },

        // ═══════════ یونان ═══════════
        new Country
        {
            Name = "Greece", NamePersian = "یونان", FlagEmoji = "🇬🇷", Continent = "اروپا",
            QualityOfLifeScore = 75, SafetyScore = 72, HealthcareScore = 78, EducationScore = 72,
            EconomicOpportunityScore = 58, PoliticalStabilityScore = 72, ClimateScore = 85,
            CostOfLivingIndex = 42, AverageRentUSD = 550, AverageSalaryUSD = 1800,
            OfficialLanguages = new() { "یونانی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 7, AllowsDualCitizenship = true,
            IranianPopulation = 5000, HasIranianCommunity = false,
            HealthcareSystem = "همگانی (ESY)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "مدیترانه‌ای", DistanceFromIranKm = 2500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای طلایی (Golden Visa) - بروزرسانی 2026", Type = "اقامت بلندمدت", Duration = "۵ سال",
                    MinInvestmentUSD = 400000,
                    Requirements = new() { "سرمایه‌گذاری ۴۰۰,۰۰۰ یورو در ملک (مناطق خاص - 2026)", "یا ۸۰۰,۰۰۰ یورو (آتن/سالونیک)", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت ۵ ساله", "دسترسی به شنگن", "حداقل حضور ۰ روز", "مسیر به تابعیت پس از ۷ سال" },
                    ProcessingTimeMonths = 4, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "مدرک زبان A2", "بیمه درمانی" },
                    Benefits = new() { "اقامت کاری", "هزینه زندگی پایین", "آب‌وهوای عالی", "مسیر به اقامت دائم" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای دیجیتال نومد", Type = "اقامت موقت", Duration = "۲ سال",
                    MinIncomeUSD = 3500,
                    Requirements = new() { "کار ریموت", "درآمد حداقل ۳,۵۰۰ یورو/ماه", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت ۲ ساله", "مالیات ویژه", "آب‌وهوای مدیترانه‌ای", "دسترسی به شنگن" },
                    ProcessingTimeMonths = 2, LeadsToPR = false, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "بازار کار ضعیف", "بوروکراسی دولتی", "نیاز به زبان یونانی", "بحران اقتصادی ادامه‌دار" }
        },

        // ═══════════ قبرس ═══════════
        new Country
        {
            Name = "Cyprus", NamePersian = "قبرس", FlagEmoji = "🇨🇾", Continent = "اروپا",
            QualityOfLifeScore = 76, SafetyScore = 82, HealthcareScore = 72, EducationScore = 70,
            EconomicOpportunityScore = 62, PoliticalStabilityScore = 75, ClimateScore = 85,
            CostOfLivingIndex = 45, AverageRentUSD = 700, AverageSalaryUSD = 2000,
            OfficialLanguages = new() { "یونانی", "ترکی", "انگلیسی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 7, AllowsDualCitizenship = true,
            IranianPopulation = 3000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه همگانی (GESY)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "مدیترانه‌ای", DistanceFromIranKm = 2000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت از سرمایه‌گذاری", Type = "اقامت دائم", Duration = "دائمی",
                    MinInvestmentUSD = 300000,
                    Requirements = new() { "سرمایه‌گذاری ۳۰۰,۰۰۰ یورو در ملک", "درآمد سالانه حداقل ۳۰,۰۰۰ یورو", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت دائم فوری", "مالیات پایین", "زبان انگلیسی رایج", "آب‌وهوای عالی" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای کار", Type = "اقامت موقت", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت کاری", "مالیات ۱۲.۵٪", "زبان انگلیسی", "نزدیکی به ایران" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای فریلنسر", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    MinIncomeUSD = 2000,
                    Requirements = new() { "اثبات درآمد", "بیمه درمانی", "عدم سوءپیشینه", "محل اقامت" },
                    Benefits = new() { "امکان کار آزاد", "مالیات پایین", "آب‌وهوای مدیترانه‌ای", "دسترسی به شنگن" },
                    ProcessingTimeMonths = 2, LeadsToPR = false, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "جزیره تقسیم‌شده", "بازار کار کوچک", "فاصله از مرکز اروپا", "مسائل سیاسی منطقه‌ای" }
        },

        // ═══════════ مالت ═══════════
        new Country
        {
            Name = "Malta", NamePersian = "مالت", FlagEmoji = "🇲🇹", Continent = "اروپا",
            QualityOfLifeScore = 78, SafetyScore = 85, HealthcareScore = 75, EducationScore = 72,
            EconomicOpportunityScore = 65, PoliticalStabilityScore = 78, ClimateScore = 82,
            CostOfLivingIndex = 50, AverageRentUSD = 800, AverageSalaryUSD = 2200,
            OfficialLanguages = new() { "مالتی", "انگلیسی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 2000, HasIranianCommunity = false,
            HealthcareSystem = "همگانی", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "مدیترانه‌ای", DistanceFromIranKm = 3500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت از سرمایه‌گذاری (MEIN)", Type = "اقامت دائم", Duration = "دائمی",
                    MinInvestmentUSD = 750000,
                    Requirements = new() { "سرمایه‌گذاری ۷۰۰,۰۰۰ یورو + کمک دولتی", "حداقل ۱۲ ماه اقامت", "عدم سوءپیشینه", "بیمه درمانی" },
                    Benefits = new() { "تابعیت مستقیم", "دسترسی به EU و شنگن", "زبان انگلیسی", "مالیات پایین" },
                    ProcessingTimeMonths = 12, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای کار (Single Permit)", Type = "اقامت موقت", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار از Identità", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت کاری", "زبان انگلیسی", "مالیات ۱۵-۳۵٪", "آب‌وهوای عالی" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای دیجیتال نومد (Nomad Residence Permit)", Type = "اقامت موقت", Duration = "۱ سال",
                    MinIncomeUSD = 3500,
                    Requirements = new() { "کار ریموت", "درآمد حداقل ۲,۷۰۰ یورو/ماه", "بیمه درمانی", "اجاره یا خرید ملک" },
                    Benefits = new() { "اقامت ۱ ساله قابل تمدید", "مالیات ویژه ۱۵٪", "زبان انگلیسی", "دسترسی به شنگن" },
                    ProcessingTimeMonths = 2, LeadsToPR = false, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "جزیره کوچک", "بازار کار محدود", "هزینه سرمایه‌گذاری بالا", "ترافیک سنگین" }
        },

        // ═══════════ لهستان ═══════════
        new Country
        {
            Name = "Poland", NamePersian = "لهستان", FlagEmoji = "🇵🇱", Continent = "اروپا",
            QualityOfLifeScore = 78, SafetyScore = 80, HealthcareScore = 72, EducationScore = 78,
            EconomicOpportunityScore = 72, PoliticalStabilityScore = 75, ClimateScore = 45,
            CostOfLivingIndex = 45, AverageRentUSD = 700, AverageSalaryUSD = 2200,
            OfficialLanguages = new() { "لهستانی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 5000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی (NFZ)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "قاره‌ای معتدل", DistanceFromIranKm = 3000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 1800,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی با حقوق حداقلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "هزینه زندگی پایین" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای کار (زبان A)", Type = "اقامت موقت", Duration = "۱ تا ۳ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار از Voivode", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "اقامت کاری", "هزینه زندگی پایین", "اقتصاد در حال رشد", "مسیر به اقامت دائم" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "پذیرش از دانشگاه لهستانی", "تمکن مالی (~۶۰۰ یورو/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه پایین", "اجازه کار پاره‌وقت", "ویزای کار پس از فارغ‌التحصیلی", "هزینه زندگی پایین" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "نیاز به زبان لهستانی", "آب‌وهوای سرد", "بوروکراسی اداری", "تفاوت فرهنگی" }
        },

        // ═══════════ جمهوری چک ═══════════
        new Country
        {
            Name = "Czech Republic", NamePersian = "جمهوری چک", FlagEmoji = "🇨🇿", Continent = "اروپا",
            QualityOfLifeScore = 82, SafetyScore = 85, HealthcareScore = 80, EducationScore = 82,
            EconomicOpportunityScore = 74, PoliticalStabilityScore = 80, ClimateScore = 50,
            CostOfLivingIndex = 50, AverageRentUSD = 800, AverageSalaryUSD = 2500,
            OfficialLanguages = new() { "چکی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 4000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "قاره‌ای معتدل", DistanceFromIranKm = 3200,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 2000,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "هزینه زندگی مناسب" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای کارمند (Zaměstnanecká karta)", Type = "اقامت موقت", Duration = "تا ۲ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "اقامت کاری", "هزینه زندگی پایین", "امنیت بالا", "مسیر به اقامت دائم" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "پذیرش از دانشگاه چکی", "تمکن مالی (~۵۰۰ یورو/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "تحصیل رایگان (به چکی)", "شهریه پایین به انگلیسی", "ویزای کار پس از تحصیل", "کیفیت زندگی خوب" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "زبان چکی دشوار", "بوروکراسی پیچیده", "بازار مسکن رقابتی", "تفاوت فرهنگی" }
        },

        // ═══════════ اسلواکی ═══════════
        new Country
        {
            Name = "Slovakia", NamePersian = "اسلواکی", FlagEmoji = "🇸🇰", Continent = "اروپا",
            QualityOfLifeScore = 75, SafetyScore = 82, HealthcareScore = 72, EducationScore = 74,
            EconomicOpportunityScore = 68, PoliticalStabilityScore = 76, ClimateScore = 48,
            CostOfLivingIndex = 42, AverageRentUSD = 600, AverageSalaryUSD = 1800,
            OfficialLanguages = new() { "اسلواکی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 8, AllowsDualCitizenship = false,
            IranianPopulation = 2000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "قاره‌ای معتدل", DistanceFromIranKm = 3100,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 1500,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "هزینه زندگی بسیار پایین" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی (~۴۰۰ یورو/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "تحصیل رایگان", "هزینه زندگی پایین", "ویزای کار پس از تحصیل", "امنیت بالا" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "عدم اجازه تابعیت دوگانه", "زبان اسلواکی", "بازار کار کوچک", "تابعیت پس از ۸ سال" }
        },

        // ═══════════ اسلوونی ═══════════
        new Country
        {
            Name = "Slovenia", NamePersian = "اسلوونی", FlagEmoji = "🇸🇮", Continent = "اروپا",
            QualityOfLifeScore = 82, SafetyScore = 88, HealthcareScore = 78, EducationScore = 80,
            EconomicOpportunityScore = 68, PoliticalStabilityScore = 82, ClimateScore = 55,
            CostOfLivingIndex = 48, AverageRentUSD = 700, AverageSalaryUSD = 2100,
            OfficialLanguages = new() { "اسلوونیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = true,
            IranianPopulation = 1500, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "آلپی/مدیترانه‌ای", DistanceFromIranKm = 3000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 1800,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "کیفیت زندگی بالا" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی (~۵۰۰ یورو/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه پایین", "طبیعت زیبا", "امنیت بالا", "ویزای کار پس از تحصیل" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "تابعیت پس از ۱۰ سال", "زبان اسلوونیایی", "بازار کار کوچک", "کشور کوچک" }
        },

        // ═══════════ کرواسی ═══════════
        new Country
        {
            Name = "Croatia", NamePersian = "کرواسی", FlagEmoji = "🇭🇷", Continent = "اروپا",
            QualityOfLifeScore = 76, SafetyScore = 82, HealthcareScore = 72, EducationScore = 72,
            EconomicOpportunityScore = 60, PoliticalStabilityScore = 76, ClimateScore = 80,
            CostOfLivingIndex = 42, AverageRentUSD = 550, AverageSalaryUSD = 1700,
            OfficialLanguages = new() { "کرواتی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 8, AllowsDualCitizenship = true,
            IranianPopulation = 1500, HasIranianCommunity = false,
            HealthcareSystem = "بیمه همگانی (HZZO)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "مدیترانه‌ای/قاره‌ای", DistanceFromIranKm = 2800,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 1500,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "آب‌وهوای عالی" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای دیجیتال نومد", Type = "اقامت موقت", Duration = "۱ سال",
                    MinIncomeUSD = 2500,
                    Requirements = new() { "کار ریموت", "درآمد حداقل ۲,۵۰۰ یورو/ماه", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت ۱ ساله", "مالیات ویژه", "ساحل دریای آدریاتیک", "هزینه زندگی پایین" },
                    ProcessingTimeMonths = 2, LeadsToPR = false, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "تابعیت پس از ۸ سال", "بازار کار کوچک", "نیاز به زبان کرواتی", "فصل توریستی" }
        },

        // ═══════════ بلغارستان ═══════════
        new Country
        {
            Name = "Bulgaria", NamePersian = "بلغارستان", FlagEmoji = "🇧🇬", Continent = "اروپا",
            QualityOfLifeScore = 68, SafetyScore = 75, HealthcareScore = 65, EducationScore = 70,
            EconomicOpportunityScore = 60, PoliticalStabilityScore = 68, ClimateScore = 60,
            CostOfLivingIndex = 35, AverageRentUSD = 400, AverageSalaryUSD = 1400,
            OfficialLanguages = new() { "بلغاری" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 2000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی (NHIF)", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "قاره‌ای معتدل", DistanceFromIranKm = 2200,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 1200,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "هزینه زندگی بسیار پایین" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی (~۳۵۰ یورو/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه بسیار پایین", "هزینه زندگی پایین", "نزدیکی به ایران", "عضو EU" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "فساد اداری", "زبان بلغاری", "زیرساخت ضعیف‌تر", "بازار کار محدود" }
        },

        // ═══════════ رومانی ═══════════
        new Country
        {
            Name = "Romania", NamePersian = "رومانی", FlagEmoji = "🇷🇴", Continent = "اروپا",
            QualityOfLifeScore = 70, SafetyScore = 76, HealthcareScore = 65, EducationScore = 72,
            EconomicOpportunityScore = 64, PoliticalStabilityScore = 70, ClimateScore = 55,
            CostOfLivingIndex = 38, AverageRentUSD = 450, AverageSalaryUSD = 1500,
            OfficialLanguages = new() { "رومانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 8, AllowsDualCitizenship = true,
            IranianPopulation = 2500, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی (CNAS)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "قاره‌ای معتدل", DistanceFromIranKm = 2500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 1300,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "هزینه زندگی پایین" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی (~۴۰۰ یورو/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه پایین", "هزینه زندگی پایین", "اقتصاد در حال رشد", "عضو EU" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "تابعیت پس از ۸ سال", "زبان رومانیایی", "بوروکراسی", "زیرساخت ناهمگون" }
        },

        // ═══════════ مجارستان ═══════════
        new Country
        {
            Name = "Hungary", NamePersian = "مجارستان", FlagEmoji = "🇭🇺", Continent = "اروپا",
            QualityOfLifeScore = 74, SafetyScore = 78, HealthcareScore = 70, EducationScore = 74,
            EconomicOpportunityScore = 65, PoliticalStabilityScore = 68, ClimateScore = 52,
            CostOfLivingIndex = 40, AverageRentUSD = 500, AverageSalaryUSD = 1600,
            OfficialLanguages = new() { "مجاری" }, EnglishWidelySpoken = false,
            CitizenshipYears = 8, AllowsDualCitizenship = true,
            IranianPopulation = 5000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری (TAJ)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "قاره‌ای معتدل", DistanceFromIranKm = 2800,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 1400,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "هزینه زندگی پایین" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "پذیرش از دانشگاه مجاری", "تمکن مالی (~۴۰۰ یورو/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "تحصیل به انگلیسی موجود", "شهریه پایین", "هزینه زندگی پایین", "ویزای کار پس از تحصیل" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای مهمان سرمایه‌گذار (Guest Investor)", Type = "اقامت موقت", Duration = "۱۰ سال",
                    MinInvestmentUSD = 250000,
                    Requirements = new() { "سرمایه‌گذاری ۲۵۰,۰۰۰ یورو در صندوق", "عدم سوءپیشینه", "بیمه درمانی", "تمکن مالی" },
                    Benefits = new() { "اقامت ۱۰ ساله", "دسترسی به شنگن", "الحاق خانواده", "هزینه زندگی پایین" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "زبان مجاری بسیار دشوار", "وضعیت سیاسی ناپایدار", "تابعیت پس از ۸ سال", "بوروکراسی" }
        },

        // ═══════════ لوکزامبورگ ═══════════
        new Country
        {
            Name = "Luxembourg", NamePersian = "لوکزامبورگ", FlagEmoji = "🇱🇺", Continent = "اروپا",
            QualityOfLifeScore = 90, SafetyScore = 90, HealthcareScore = 88, EducationScore = 85,
            EconomicOpportunityScore = 82, PoliticalStabilityScore = 90, ClimateScore = 52,
            CostOfLivingIndex = 85, AverageRentUSD = 2000, AverageSalaryUSD = 5500,
            OfficialLanguages = new() { "فرانسوی", "آلمانی", "لوکزامبورگی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 1000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی", UniversalHealthcare = true,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "اقیانوسی معتدل", DistanceFromIranKm = 4000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 5000,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی با حقوق بالا", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "حقوق بسیار بالا", "الحاق خانواده", "مسیر به اقامت دائم", "مرکز مالی اروپا" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی (~۱,۵۰۰ یورو/ماه)", "زبان فرانسوی یا انگلیسی", "بیمه درمانی" },
                    Benefits = new() { "دانشگاه لوکزامبورگ چندزبانه", "محیط بین‌المللی", "ویزای کار پس از تحصیل", "حقوق بالا" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "هزینه زندگی بسیار بالا", "بحران مسکن", "کشور بسیار کوچک", "زبان‌های متعدد" }
        },

        // ═══════════ استونی ═══════════
        new Country
        {
            Name = "Estonia", NamePersian = "استونی", FlagEmoji = "🇪🇪", Continent = "اروپا (بالتیک)",
            QualityOfLifeScore = 80, SafetyScore = 85, HealthcareScore = 72, EducationScore = 82,
            EconomicOpportunityScore = 72, PoliticalStabilityScore = 82, ClimateScore = 35,
            CostOfLivingIndex = 45, AverageRentUSD = 600, AverageSalaryUSD = 2000,
            OfficialLanguages = new() { "استونیایی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 8, AllowsDualCitizenship = true,
            IranianPopulation = 500, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی", UniversalHealthcare = true,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "شمالی سرد", DistanceFromIranKm = 3200,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 1800,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "اکوسیستم فناوری قوی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای استارتاپ", Type = "اقامت موقت", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new() { "ایده نوآورانه", "تأییدیه Startup Estonia", "طرح کسب‌وکاری", "تمکن مالی" },
                    Benefits = new() { "اقامت ۲ ساله", "بهترین اکوسیستم استارتاپی بالتیک", "زبان انگلیسی رایج", "دولت الکترونیک" },
                    ProcessingTimeMonths = 1, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای دیجیتال نومد (e-Residency + Digital Nomad)", Type = "اقامت موقت", Duration = "۱ سال",
                    MinIncomeUSD = 3500,
                    Requirements = new() { "کار ریموت", "درآمد حداقل ۳,۵۰۰ یورو/ماه", "بیمه درمانی", "ثبت شرکت اختیاری" },
                    Benefits = new() { "اقامت ۱ ساله", "e-Residency برای کسب‌وکار", "دولت دیجیتال", "زبان انگلیسی" },
                    ProcessingTimeMonths = 1, LeadsToPR = false, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "آب‌وهوای سرد", "زبان استونیایی", "بازار کار کوچک", "تابعیت پس از ۸ سال" }
        },

        // ═══════════ لتونی ═══════════
        new Country
        {
            Name = "Latvia", NamePersian = "لتونی", FlagEmoji = "🇱🇻", Continent = "اروپا (بالتیک)",
            QualityOfLifeScore = 74, SafetyScore = 78, HealthcareScore = 68, EducationScore = 74,
            EconomicOpportunityScore = 64, PoliticalStabilityScore = 76, ClimateScore = 35,
            CostOfLivingIndex = 40, AverageRentUSD = 450, AverageSalaryUSD = 1600,
            OfficialLanguages = new() { "لتونیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = true,
            IranianPopulation = 300, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "شمالی سرد", DistanceFromIranKm = 3000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 1500,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک زبان لتونیایی", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "هزینه زندگی پایین" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی (~۳۵۰ یورو/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه پایین", "هزینه زندگی پایین", "عضو EU و شنگن", "طبیعت زیبا" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "تابعیت پس از ۱۰ سال", "زبان لتونیایی", "آب‌وهوای سرد", "بازار کار کوچک" }
        },

        // ═══════════ لیتوانی ═══════════
        new Country
        {
            Name = "Lithuania", NamePersian = "لیتوانی", FlagEmoji = "🇱🇹", Continent = "اروپا (بالتیک)",
            QualityOfLifeScore = 75, SafetyScore = 80, HealthcareScore = 68, EducationScore = 76,
            EconomicOpportunityScore = 66, PoliticalStabilityScore = 78, ClimateScore = 35,
            CostOfLivingIndex = 40, AverageRentUSD = 450, AverageSalaryUSD = 1700,
            OfficialLanguages = new() { "لیتوانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 10, AllowsDualCitizenship = true,
            IranianPopulation = 300, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری (PSD)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "شمالی سرد", DistanceFromIranKm = 3100,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "بلوکارت EU", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2, MinIncomeUSD = 1500,
                    Requirements = new() { "مدرک دانشگاهی", "پیشنهاد شغلی", "مدرک زبان", "شغل واجد شرایط" },
                    Benefits = new() { "اقامت کار", "الحاق خانواده", "مسیر به اقامت دائم", "اکوسیستم فین‌تک قوی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای استارتاپ", Type = "اقامت موقت", Duration = "۲ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new() { "ایده نوآورانه", "تأییدیه Startup Lithuania", "طرح کسب‌وکاری", "تمکن مالی" },
                    Benefits = new() { "اقامت ۲ ساله", "اکوسیستم استارتاپی رو به رشد", "هزینه زندگی پایین", "مسیر به اقامت دائم" },
                    ProcessingTimeMonths = 1, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Basic,
                    Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی (~۳۵۰ یورو/ماه)", "بیمه درمانی", "محل اقامت" },
                    Benefits = new() { "شهریه پایین", "تحصیل به انگلیسی موجود", "هزینه زندگی پایین", "عضو EU" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "تابعیت پس از ۱۰ سال", "زبان لیتوانیایی", "آب‌وهوای سرد", "بازار کار کوچک" }
        },

        // ═══════════ هلند ═══════════
        new Country
        {
            Name = "Netherlands", NamePersian = "هلند", FlagEmoji = "🇳🇱", Continent = "اروپا",
            QualityOfLifeScore = 89, SafetyScore = 84, HealthcareScore = 88, EducationScore = 87,
            EconomicOpportunityScore = 80, PoliticalStabilityScore = 88, ClimateScore = 55,
            CostOfLivingIndex = 68, AverageRentUSD = 1400, AverageSalaryUSD = 4200,
            OfficialLanguages = new() { "هلندی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 42000, HasIranianCommunity = true,
            HealthcareSystem = "بیمه خصوصی اجباری", UniversalHealthcare = false,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "معتدل اقیانوسی", DistanceFromIranKm = 4000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار تخصصی (Highly Skilled Migrant) - بروزرسانی 2026",
                    Type = "اقامت موقت - منجر به دائم", Duration = "تا ۵ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Intermediate,
                    MinExperienceYears = 2, MinIncomeUSD = 4200,
                    Requirements = new() { "پیشنهاد شغلی از کارفرمای مورد تأیید IND", "حقوق حداقل ۴,۸۴۰ یورو/ماه (2026) یا ۳,۵۴۶ برای زیر ۳۰ سال", "مدرک زبان انگلیسی یا هلندی", "مدرک دانشگاهی" },
                    Benefits = new() { "اقامت کار سریع", "تخفیف مالیاتی ۳۰٪ (30% ruling)", "الحاق خانواده", "مسیر به اقامت دائم", "امکان تابعیت پس از ۵ سال" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای استارتاپ", Type = "اقامت موقت", Duration = "۱ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new() { "ایده نوآورانه", "پشتیبانی یک تسهیل‌گر معتبر (Facilitator)", "طرح کسب‌وکاری", "تمکن مالی" },
                    Benefits = new() { "اقامت ۱ ساله", "دسترسی به اکوسیستم نوآوری", "امکان تبدیل به ویزای خوداشتغال", "محیط کسب‌وکار عالی" },
                    ProcessingTimeMonths = 3, LeadsToPR = false, LeadsToCitizenship = false
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال (Orientation Year)",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه هلندی", "تمکن مالی", "IELTS 6.0+", "بیمه درمانی" },
                    Benefits = new() { "تحصیل به انگلیسی", "ویزای جستجوی کار ۱ ساله (Orientation Year)", "اجازه کار پاره‌وقت", "کیفیت آموزش بالا" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "بحران مسکن شدید", "مالیات بالا", "نیاز به یادگیری زبان هلندی", "هزینه زندگی بالا" }
        },

        // ═══════════ پرتغال ═══════════
        new Country
        {
            Name = "Portugal", NamePersian = "پرتغال", FlagEmoji = "🇵🇹", Continent = "اروپا",
            QualityOfLifeScore = 78, SafetyScore = 80, HealthcareScore = 75, EducationScore = 70,
            EconomicOpportunityScore = 62, PoliticalStabilityScore = 82, ClimateScore = 90,
            CostOfLivingIndex = 45, AverageRentUSD = 850, AverageSalaryUSD = 1900,
            OfficialLanguages = new() { "پرتغالی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 5000, HasIranianCommunity = false,
            HealthcareSystem = "همگانی (SNS)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "مدیترانه‌ای", DistanceFromIranKm = 5000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای D7 (درآمد غیرفعال) - بروزرسانی 2026",
                    Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال (قابل تمدید)",
                    MinIncomeUSD = 1000,
                    Requirements = new() { "درآمد غیرفعال حداقل ۸۲۰ یورو/ماه (2026)", "تمکن مالی", "محل اقامت در پرتغال", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "مسیر به اقامت دائم و تابعیت", "هزینه زندگی پایین", "آب‌وهوای عالی", "مالیات ویژه (NHR) محدود - 2026", "دسترسی به شنگن" },
                    ProcessingTimeMonths = 4, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای طلایی (Golden Visa) - بروزرسانی 2026",
                    Type = "اقامت موقت - منجر به تابعیت", Duration = "۲ سال (قابل تمدید)",
                    MinInvestmentUSD = 250000,
                    Requirements = new() { "سرمایه‌گذاری ۲۵۰,۰۰۰ یورو در تحقیقات/هنر", "یا ۵۰۰,۰۰۰ یورو در صندوق سرمایه‌گذاری", "ایجاد ۱۰ شغل", "حداقل ۷ روز حضور در سال" },
                    Benefits = new() { "اقامت با حداقل حضور", "دسترسی به شنگن", "تابعیت پس از ۵ سال", "بدون نیاز به اقامت دائم" },
                    ProcessingTimeMonths = 6, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای D2 (خوداشتغال/فریلنسر)", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    MinIncomeUSD = 1500,
                    Requirements = new() { "قرارداد فریلنسری یا طرح کسب‌وکار", "تمکن مالی", "محل اقامت", "بیمه درمانی" },
                    Benefits = new() { "امکان کار آزاد", "مسیر به اقامت دائم", "هزینه زندگی پایین", "آب‌وهوای مدیترانه‌ای" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "حقوق پایین نسبت به اروپای غربی", "بازار کار محدود", "نیاز به یادگیری زبان پرتغالی", "بوروکراسی کند" }
        },

        // ═══════════ سوئد ═══════════
        new Country
        {
            Name = "Sweden", NamePersian = "سوئد", FlagEmoji = "🇸🇪", Continent = "اروپا",
            QualityOfLifeScore = 91, SafetyScore = 82, HealthcareScore = 85, EducationScore = 88,
            EconomicOpportunityScore = 78, PoliticalStabilityScore = 88, ClimateScore = 35,
            CostOfLivingIndex = 70, AverageRentUSD = 1100, AverageSalaryUSD = 3900,
            OfficialLanguages = new() { "سوئدی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 72000, HasIranianCommunity = true,
            HealthcareSystem = "همگانی یارانه‌ای", UniversalHealthcare = true,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "شمالی سرد", DistanceFromIranKm = 3800,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار - بروزرسانی 2026 (قوانین سخت‌گیرانه‌تر)",
                    Type = "اقامت موقت - منجر به دائم", Duration = "تا ۲ سال (قابل تمدید)",
                    MinEducation = EducationLevel.BachelorDegree, MinExperienceYears = 1,
                    Requirements = new() { "پیشنهاد شغلی از کارفرمای سوئدی", "حقوق مطابق قرارداد جمعی (حداقل ۱۳,۳۰۰ کرون/ماه - 2026)", "بیمه درمانی", "گذرنامه معتبر" },
                    Benefits = new() { "اقامت کار قابل تمدید", "الحاق خانواده", "مسیر به اقامت دائم پس از ۲ سال", "امکان تابعیت پس از ۵ سال", "تعادل کار و زندگی عالی" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۶ ماه",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه سوئدی", "پرداخت شهریه (برای غیر EU)", "تمکن مالی", "بیمه درمانی" },
                    Benefits = new() { "تحصیل به انگلیسی", "ویزای کار ۶ ماهه پس از فارغ‌التحصیلی", "کیفیت بالای آموزش", "محیط چندفرهنگی" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای خوداشتغالی", Type = "اقامت موقت", Duration = "۲ سال",
                    MinInvestmentUSD = 25000,
                    Requirements = new() { "طرح کسب‌وکاری معتبر", "حداقل ۱۰٪ سهام شرکت", "تمکن مالی برای ۲ سال", "سابقه کار مرتبط" },
                    Benefits = new() { "امکان راه‌اندازی کسب‌وکار", "الحاق خانواده", "مسیر به اقامت دائم", "اکوسیستم نوآوری قوی" },
                    ProcessingTimeMonths = 4, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "آب‌وهوای سرد و تاریک در زمستان", "مالیات بالا", "نیاز به یادگیری زبان سوئدی", "بحران مسکن در شهرهای بزرگ" }
        }
    };
}
