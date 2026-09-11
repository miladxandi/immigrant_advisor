using ImmigrantAdvisor.Shared.Models;

namespace ImmigrantAdvisor.Shared.Data;

// داده‌های قاره آمریکا (شمالی، مرکزی، جنوبی) - بروزرسانی August/September 2026
// شامل ۲۰ کشور (آمریکا و کانادا + ۱۸ کشور لاتین)
public static class AmericasCountryData
{
    public static List<Country> GetCountries() => new()
    {
        // ═══════════ ایالات متحده آمریکا (بروزرسانی 2026) ═══════════
        new Country
        {
            Name = "United States", NamePersian = "ایالات متحده آمریکا", FlagEmoji = "🇺🇸", Continent = "آمریکای شمالی",
            QualityOfLifeScore = 82, SafetyScore = 65, HealthcareScore = 70, EducationScore = 88,
            EconomicOpportunityScore = 90, PoliticalStabilityScore = 72, ClimateScore = 75,
            CostOfLivingIndex = 68, AverageRentUSD = 1700, AverageSalaryUSD = 5800,
            OfficialLanguages = new() { "انگلیسی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 520000, HasIranianCommunity = true,
            HealthcareSystem = "بیمه خصوصی", UniversalHealthcare = false,
            EducationSystemQuality = "عالی", FreeEducation = false,
            Climate = "متنوع - از گرمسیری تا قطبی", DistanceFromIranKm = 10500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای EB-1 (نخبگان)", Type = "اقامت دائم (Green Card)", Duration = "دائمی",
                    MinEducation = EducationLevel.PhD, MinExperienceYears = 5,
                    Requirements = new() { "دستاوردهای فوق‌العاده در علوم، هنر، آموزش، کسب‌وکار یا ورزش", "مستندات قوی (جوایز، انتشارات، استنادها)", "حداقل ۳ معیار از ۱۰ معیار USCIS", "پیشنهاد شغلی یا خوداسپانسرشیپ" },
                    Benefits = new() { "گرین کارت بدون نیاز به کارفرما", "مسیر مستقیم به تابعیت", "الحاق خانواده", "بدون محدودیت جغرافیایی" },
                    ProcessingTimeMonths = 8, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای EB-2 NIW (منافع ملی)", Type = "اقامت دائم (Green Card)", Duration = "دائمی",
                    MinEducation = EducationLevel.MasterDegree, MinExperienceYears = 3,
                    Requirements = new() { "مدرک فوق‌لیسانس یا بالاتر", "اثبات منافع ملی کار", "توانایی پیشبرد طرح پیشنهادی", "در موقعیتی که منافع آمریکا ایجاب می‌کند" },
                    Benefits = new() { "گرین کارت بدون نیاز به کارفرما", "بدون نیاز به Labor Certification", "الحاق خانواده", "مسیر به تابعیت" },
                    ProcessingTimeMonths = 12, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای H-1B (کار تخصصی) - بروزرسانی 2026", Type = "موقت - منجر به اقامت", Duration = "تا ۶ سال",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Advanced,
                    Requirements = new() { "پیشنهاد شغلی در رشته تخصصی", "حداقل لیسانس مرتبط", "کارفرمای اسپانسر", "قرعه‌کشی سالانه (رقابت بالا)" },
                    Benefits = new() { "اقامت کار تا ۶ سال", "امکان تبدیل به گرین کارت", "حقوق بالا", "فرصت‌های شغلی متنوع" },
                    ProcessingTimeMonths = 6, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی F-1", Type = "موقت", Duration = "تحصیل + ۳ سال (OPT)",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Advanced,
                    Requirements = new() { "پذیرش از دانشگاه معتبر", "تمکن مالی کامل", "نمره TOEFL/IELTS بالا", "اثبات قصد بازگشت" },
                    Benefits = new() { "OPT ۳ ساله برای رشته‌های STEM", "فرصت‌های شغلی عالی", "دانشگاه‌های برتر جهان", "شبکه‌سازی قوی" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای EB-5 (سرمایه‌گذاری) - بروزرسانی 2026", Type = "اقامت دائم (Green Card)", Duration = "دائمی",
                    MinInvestmentUSD = 800000,
                    Requirements = new() { "سرمایه‌گذاری ۸۰۰,۰۰۰ دلار (مناطق هدف) یا ۱,۰۵۰,۰۰۰ دلار", "ایجاد حداقل ۱۰ شغل تمام‌وقت", "اثبات منشأ قانونی سرمایه", "طرح کسب‌وکاری" },
                    Benefits = new() { "گرین کارت برای کل خانواده", "بدون نیاز به کارفرما یا تحصیلات", "آزادی زندگی و کار", "مسیر به تابعیت" },
                    ProcessingTimeMonths = 18, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "فرآیند ویزای بسیار پیچیده و طولانی", "هزینه بهداشت و درمان بالا", "مسائل امنیتی در برخی مناطق", "سیستم مهاجرتی رقابتی", "محدودیت‌های خاص برای ایرانیان" }
        },

        // ═══════════ کانادا (بروزرسانی 2026) ═══════════
        new Country
        {
            Name = "Canada", NamePersian = "کانادا", FlagEmoji = "🇨🇦", Continent = "آمریکای شمالی",
            QualityOfLifeScore = 92, SafetyScore = 88, HealthcareScore = 90, EducationScore = 92,
            EconomicOpportunityScore = 85, PoliticalStabilityScore = 95, ClimateScore = 40,
            CostOfLivingIndex = 72, AverageRentUSD = 1800, AverageSalaryUSD = 4600,
            OfficialLanguages = new() { "انگلیسی", "فرانسوی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 3, AllowsDualCitizenship = true,
            IranianPopulation = 260000, HasIranianCommunity = true,
            HealthcareSystem = "همگانی رایگان", UniversalHealthcare = true,
            EducationSystemQuality = "عالی", FreeEducation = true,
            Climate = "قاره‌ای سرد و معتدل", DistanceFromIranKm = 10000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "اکسپرس انتری (Express Entry) - بروزرسانی 2026", Type = "اقامت دائم", Duration = "دائمی",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Advanced,
                    MinExperienceYears = 1,
                    Requirements = new() { "حداقل مدرک لیسانس", "حداقل ۱ سال سابقه کار مرتبط", "نمره IELTS حداقل ۶ در هر مهارت (CLB 7)", "اثبات تمکن مالی", "آزمایشات پزشکی" },
                    Benefits = new() { "اقامت دائم از روز اول", "حق کار در هر نقطه کانادا", "دسترسی به خدمات بهداشتی رایگان", "امکان دریافت تابعیت پس از ۳ سال", "تحصیل رایگان فرزندان" },
                    ProcessingTimeMonths = 6, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای استارتاپ (Start-Up Visa)", Type = "اقامت دائم", Duration = "دائمی",
                    MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "ایده نوآورانه و قابل توسعه", "پشتیبانی یکی از سازمان‌های تعیین‌شده", "نمره زبان CLB 5", "تمکن مالی برای استقرار" },
                    Benefits = new() { "اقامت دائم بدون نیاز به سرمایه بالا", "امکان راه‌اندازی کسب‌وکار", "دسترسی به اکوسیستم نوآوری کانادا" },
                    ProcessingTimeMonths = 12, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی", Type = "موقت - منجر به اقامت", Duration = "۲ تا ۴ سال",
                    MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new() { "پذیرش از دانشگاه معتبر", "تمکن مالی برای شهریه و زندگی", "نمره زبان مناسب", "انگیزه‌نامه قوی" },
                    Benefits = new() { "امکان کار پاره‌وقت حین تحصیل", "ویزای کار پس از فارغ‌التحصیلی (PGWP)", "مسیر هموار به اقامت دائم", "تحصیل رایگان فرزندان" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "برنامه‌های استانی (PNP)", Type = "اقامت دائم", Duration = "دائمی",
                    MinEducation = EducationLevel.Diploma, MinLanguageLevel = LanguageProficiency.Intermediate,
                    MinExperienceYears = 1,
                    Requirements = new() { "پیشنهاد شغلی از کارفرمای استان", "تطابق با مشاغل مورد نیاز استان", "نمره زبان مناسب", "تمایل به زندگی در آن استان" },
                    Benefits = new() { "امتیاز اضافی برای اکسپرس انتری", "اقامت دائم", "فرصت‌های شغلی متنوع" },
                    ProcessingTimeMonths = 18, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "آب‌وهوای سرد در زمستان", "هزینه زندگی بالا در شهرهای بزرگ", "نیاز به یادگیری زبان (انگلیسی یا فرانسوی)" }
        },

        // ═══════════ مکزیک ═══════════
        new Country
        {
            Name = "Mexico", NamePersian = "مکزیک", FlagEmoji = "🇲🇽", Continent = "آمریکای شمالی",
            QualityOfLifeScore = 62, SafetyScore = 45, HealthcareScore = 58, EducationScore = 58,
            EconomicOpportunityScore = 60, PoliticalStabilityScore = 52, ClimateScore = 75,
            CostOfLivingIndex = 35, AverageRentUSD = 500, AverageSalaryUSD = 1200,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 3000, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی (IMSS)", UniversalHealthcare = false,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "گرمسیری/نیمه‌خشک", DistanceFromIranKm = 12000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت موقت (Rentista)", Type = "اقامت موقت", Duration = "تا ۴ سال",
                    MinIncomeUSD = 2500,
                    Requirements = new() { "اثبات درآمد ماهانه حداقل ۲,۵۰۰ دلار", "یا سرمایه ۱۰۰,۰۰۰ دلار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت موقت", "امکان تبدیل به دائم", "هزینه زندگی پایین", "آب‌وهوای عالی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای کار (OFERTA DE TRABAJO)", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقتصاد بزرگ لاتین", "نزدیکی به آمریکا", "فرصت‌های شغلی", "فرهنگ غنی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "ناامنی در برخی مناطق", "بوروکراسی پیچیده", "نیاز به زبان اسپانیایی", "فاصله از ایران" }
        },

        // ═══════════ کاستاریکا ═══════════
        new Country
        {
            Name = "Costa Rica", NamePersian = "کاستاریکا", FlagEmoji = "🇨🇷", Continent = "آمریکای مرکزی",
            QualityOfLifeScore = 72, SafetyScore = 68, HealthcareScore = 72, EducationScore = 68,
            EconomicOpportunityScore = 55, PoliticalStabilityScore = 82, ClimateScore = 85,
            CostOfLivingIndex = 42, AverageRentUSD = 600, AverageSalaryUSD = 1200,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 7, AllowsDualCitizenship = true,
            IranianPopulation = 200, HasIranianCommunity = false,
            HealthcareSystem = "بیمه همگانی (CCSS)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "گرمسیری", DistanceFromIranKm = 13000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای دیجیتال نومد / Rentista", Type = "اقامت موقت", Duration = "۲ سال",
                    MinIncomeUSD = 3000,
                    Requirements = new() { "اثبات درآمد ماهانه حداقل ۳,۰۰۰ دلار", "بیمه درمانی", "عدم سوءپیشینه", "محل اقامت" },
                    Benefits = new() { "اقامت ۲ ساله", "طبیعت فوق‌العاده", "ثبات سیاسی", "هزینه زندگی مناسب" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "بازار کار محدود", "نیاز به زبان اسپانیایی", "فاصله زیاد", "هزینه زندگی بالاتر از همسایگان" }
        },

        // ═══════════ پاناما ═══════════
        new Country
        {
            Name = "Panama", NamePersian = "پاناما", FlagEmoji = "🇵🇦", Continent = "آمریکای مرکزی",
            QualityOfLifeScore = 68, SafetyScore = 62, HealthcareScore = 65, EducationScore = 60,
            EconomicOpportunityScore = 60, PoliticalStabilityScore = 72, ClimateScore = 78,
            CostOfLivingIndex = 42, AverageRentUSD = 600, AverageSalaryUSD = 1300,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 200, HasIranianCommunity = false,
            HealthcareSystem = "بیمه خصوصی/دولتی", UniversalHealthcare = false,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "گرمسیری", DistanceFromIranKm = 13000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای بازنشستگی/سرمایه‌گذاری (Pensionado)", Type = "اقامت دائم", Duration = "دائمی",
                    MinIncomeUSD = 1000,
                    Requirements = new() { "درآمد بازنشستگی حداقل ۱,۰۰۰ دلار/ماه", "یا سرمایه‌گذاری ۲۰۰,۰۰۰ دلار در ملک", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت دائم فوری", "تخفیف‌های ویژه", "مالیات سرزمینی", "اقتصاد دلارمحور" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "آب‌وهوای گرم و مرطوب", "بازار کار محدود", "فاصله از ایران", "نیاز به زبان اسپانیایی" }
        },

        // ═══════════ برزیل ═══════════
        new Country
        {
            Name = "Brazil", NamePersian = "برزیل", FlagEmoji = "🇧🇷", Continent = "آمریکای جنوبی",
            QualityOfLifeScore = 58, SafetyScore = 42, HealthcareScore = 55, EducationScore = 55,
            EconomicOpportunityScore = 58, PoliticalStabilityScore = 52, ClimateScore = 78,
            CostOfLivingIndex = 35, AverageRentUSD = 400, AverageSalaryUSD = 1000,
            OfficialLanguages = new() { "پرتغالی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 4, AllowsDualCitizenship = true,
            IranianPopulation = 2000, HasIranianCommunity = false,
            HealthcareSystem = "همگانی (SUS)", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "گرمسیری/نیمه‌گرمسیری", DistanceFromIranKm = 13000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار (VITEM V)", Type = "اقامت موقت", Duration = "تا ۲ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "بزرگترین اقتصاد لاتین", "فرصت‌های متنوع", "فرهنگ غنی", "تابعیت پس از ۴ سال" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای سرمایه‌گذاری", Type = "اقامت موقت - منجر به دائم", Duration = "۳ سال",
                    MinInvestmentUSD = 150000,
                    Requirements = new() { "سرمایه‌گذاری حداقل ۱۵۰,۰۰۰ دلار", "طرح کسب‌وکاری", "ایجاد شغل", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت موقت", "تبدیل به دائم پس از ۳ سال", "اقتصاد بزرگ", "تابعیت آسان" },
                    ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای دیجیتال نومد", Type = "اقامت موقت", Duration = "۱ سال",
                    MinIncomeUSD = 1500,
                    Requirements = new() { "کار ریموت", "درآمد حداقل ۱,۵۰۰ دلار/ماه", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت ۱ ساله قابل تمدید", "طبیعت فوق‌العاده", "فرهنگ غنی", "هزینه زندگی پایین" },
                    ProcessingTimeMonths = 1, LeadsToPR = false, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "ناامنی در شهرهای بزرگ", "نیاز به زبان پرتغالی", "بوروکراسی", "فاصله زیاد از ایران" }
        },

        // ═══════════ آرژانتین ═══════════
        new Country
        {
            Name = "Argentina", NamePersian = "آرژانتین", FlagEmoji = "🇦🇷", Continent = "آمریکای جنوبی",
            QualityOfLifeScore = 62, SafetyScore = 50, HealthcareScore = 62, EducationScore = 65,
            EconomicOpportunityScore = 48, PoliticalStabilityScore = 45, ClimateScore = 72,
            CostOfLivingIndex = 30, AverageRentUSD = 350, AverageSalaryUSD = 800,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 2, AllowsDualCitizenship = true,
            IranianPopulation = 1500, HasIranianCommunity = false,
            HealthcareSystem = "همگانی", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "معتدل تا گرمسیری", DistanceFromIranKm = 14000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت از درآمد (Rentista)", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    MinIncomeUSD = 1000,
                    Requirements = new() { "اثبات درآمد ماهانه", "بیمه درمانی", "عدم سوءپیشینه", "محل اقامت" },
                    Benefits = new() { "تابعیت پس از فقط ۲ سال!", "هزینه زندگی بسیار پایین", "فرهنگ غنی", "طبیعت متنوع" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای دیجیتال نومد", Type = "اقامت موقت", Duration = "۶ ماه",
                    MinIncomeUSD = 2000,
                    Requirements = new() { "کار ریموت", "درآمد حداقل ۲,۰۰۰ دلار/ماه", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت ۶ ماهه", "هزینه زندگی پایین", "فرهنگ غنی", "طبیعت زیبا" },
                    ProcessingTimeMonths = 1, LeadsToPR = false, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "تورم بسیار بالا (۱۰۰٪+)", "بی‌ثباتی اقتصادی", "نیاز به زبان اسپانیایی", "فاصله زیاد" }
        },

        // ═══════════ شیلی ═══════════
        new Country
        {
            Name = "Chile", NamePersian = "شیلی", FlagEmoji = "🇨🇱", Continent = "آمریکای جنوبی",
            QualityOfLifeScore = 72, SafetyScore = 62, HealthcareScore = 68, EducationScore = 70,
            EconomicOpportunityScore = 65, PoliticalStabilityScore = 72, ClimateScore = 72,
            CostOfLivingIndex = 42, AverageRentUSD = 500, AverageSalaryUSD = 1200,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 500, HasIranianCommunity = false,
            HealthcareSystem = "بیمه خصوصی/دولتی (FONASA)", UniversalHealthcare = false,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "معتدل/مدیترانه‌ای", DistanceFromIranKm = 15000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار تخصصی", Type = "اقامت موقت", Duration = "تا ۲ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "باتثبات‌ترین اقتصاد آمریکای لاتین", "طبیعت متنوع", "امنیت نسبتاً خوب", "مسیر به تابعیت" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای دیجیتال نومد", Type = "اقامت موقت", Duration = "۱ سال",
                    MinIncomeUSD = 1500,
                    Requirements = new() { "کار ریموت", "درآمد حداقل ۱,۵۰۰ دلار/ماه", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت ۱ ساله", "اقتصاد پایدار", "طبیعت فوق‌العاده", "هزینه زندگی مناسب" },
                    ProcessingTimeMonths = 1, LeadsToPR = false, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "زبان اسپانیایی", "فاصله بسیار زیاد", "بازار کار رقابتی", "زلزله‌خیز" }
        },

        // ═══════════ کلمبیا ═══════════
        new Country
        {
            Name = "Colombia", NamePersian = "کلمبیا", FlagEmoji = "🇨🇴", Continent = "آمریکای جنوبی",
            QualityOfLifeScore = 58, SafetyScore = 42, HealthcareScore = 58, EducationScore = 55,
            EconomicOpportunityScore = 52, PoliticalStabilityScore = 48, ClimateScore = 78,
            CostOfLivingIndex = 30, AverageRentUSD = 300, AverageSalaryUSD = 700,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 300, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری (EPS)", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "گرمسیری/معتدل", DistanceFromIranKm = 13000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای دیجیتال نومد", Type = "اقامت موقت", Duration = "۲ سال",
                    MinIncomeUSD = 900,
                    Requirements = new() { "کار ریموت", "درآمد حداقل ۹۰۰ دلار/ماه", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت ۲ ساله", "هزینه زندگی بسیار پایین", "طبیعت متنوع", "فرهنگ غنی" },
                    ProcessingTimeMonths = 1, LeadsToPR = false, LeadsToCitizenship = false
                },
                new VisaOption
                {
                    Name = "ویزای سرمایه‌گذاری", Type = "اقامت موقت - منجر به دائم", Duration = "۳ سال",
                    MinInvestmentUSD = 100000,
                    Requirements = new() { "سرمایه‌گذاری حداقل ۱۰۰,۰۰۰ دلار", "طرح کسب‌وکاری", "عدم سوءپیشینه", "بیمه درمانی" },
                    Benefits = new() { "اقامت موقت", "تبدیل به دائم", "هزینه زندگی پایین", "اقتصاد در حال رشد" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "ناامنی در برخی مناطق", "نیاز به زبان اسپانیایی", "فاصله زیاد", "تورم" }
        },

        // ═══════════ پرو ═══════════
        new Country
        {
            Name = "Peru", NamePersian = "پرو", FlagEmoji = "🇵🇪", Continent = "آمریکای جنوبی",
            QualityOfLifeScore = 55, SafetyScore = 48, HealthcareScore = 50, EducationScore = 52,
            EconomicOpportunityScore = 48, PoliticalStabilityScore = 42, ClimateScore = 70,
            CostOfLivingIndex = 28, AverageRentUSD = 280, AverageSalaryUSD = 600,
            OfficialLanguages = new() { "اسپانیایی", "کچوا" }, EnglishWidelySpoken = false,
            CitizenshipYears = 2, AllowsDualCitizenship = true,
            IranianPopulation = 100, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجباری (EsSalud)", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "معتدل/گرمسیری", DistanceFromIranKm = 15000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت موقت", Type = "اقامت موقت", Duration = "۱ سال",
                    MinIncomeUSD = 1000,
                    Requirements = new() { "تمکن مالی یا درآمد", "بیمه درمانی", "عدم سوءپیشینه", "محل اقامت" },
                    Benefits = new() { "تابعیت پس از فقط ۲ سال!", "هزینه زندگی بسیار پایین", "تاریخ و فرهنگ غنی", "طبیعت متنوع" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "بی‌ثباتی سیاسی", "ناامنی", "نیاز به زبان اسپانیایی", "فاصله بسیار زیاد" }
        },

        // ═══════════ اروگوئه ═══════════
        new Country
        {
            Name = "Uruguay", NamePersian = "اروگوئه", FlagEmoji = "🇺🇾", Continent = "آمریکای جنوبی",
            QualityOfLifeScore = 72, SafetyScore = 72, HealthcareScore = 70, EducationScore = 68,
            EconomicOpportunityScore = 55, PoliticalStabilityScore = 82, ClimateScore = 68,
            CostOfLivingIndex = 45, AverageRentUSD = 500, AverageSalaryUSD = 1100,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 100, HasIranianCommunity = false,
            HealthcareSystem = "همگانی (SNIS)", UniversalHealthcare = true,
            EducationSystemQuality = "خوب", FreeEducation = true,
            Climate = "معتدل", DistanceFromIranKm = 14000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت", Type = "اقامت موقت - منجر به دائم", Duration = "۱ تا ۳ سال",
                    MinIncomeUSD = 500,
                    Requirements = new() { "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه", "محل اقامت" },
                    Benefits = new() { "باتثبات‌ترین کشور آمریکای لاتین", "امنیت بالا", "تابعیت دوگانه", "مسیر سریع به تابعیت" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "بازار کار کوچک", "نیاز به زبان اسپانیایی", "فاصله زیاد", "هزینه زندگی بالاتر از همسایگان" }
        },

        // ═══════════ پاراگوئه ═══════════
        new Country
        {
            Name = "Paraguay", NamePersian = "پاراگوئه", FlagEmoji = "🇵🇾", Continent = "آمریکای جنوبی",
            QualityOfLifeScore = 52, SafetyScore = 55, HealthcareScore = 45, EducationScore = 48,
            EconomicOpportunityScore = 42, PoliticalStabilityScore = 55, ClimateScore = 65,
            CostOfLivingIndex = 22, AverageRentUSD = 200, AverageSalaryUSD = 500,
            OfficialLanguages = new() { "اسپانیایی", "گوارانی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 3, AllowsDualCitizenship = true,
            IranianPopulation = 50, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی (IPS)", UniversalHealthcare = false,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "نیمه‌گرمسیری", DistanceFromIranKm = 14000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت دائم فوری", Type = "اقامت دائم", Duration = "دائمی",
                    MinInvestmentUSD = 5000,
                    Requirements = new() { "سپرده ۵,۰۰۰ دلار در بانک", "عدم سوءپیشینه", "بیمه درمانی", "تمکن مالی" },
                    Benefits = new() { "اقامت دائم فوری!", "مالیات سرزمینی (۰٪ بر درآمد خارجی)", "تابعیت پس از ۳ سال", "هزینه زندگی بسیار پایین" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "اقتصاد ضعیف", "زبان گوارانی/اسپانیایی", "گرمای شدید", "فاصله زیاد" }
        },

        // ═══════════ اکوادور ═══════════
        new Country
        {
            Name = "Ecuador", NamePersian = "اکوادور", FlagEmoji = "🇪🇨", Continent = "آمریکای جنوبی",
            QualityOfLifeScore = 55, SafetyScore = 45, HealthcareScore = 50, EducationScore = 50,
            EconomicOpportunityScore = 42, PoliticalStabilityScore = 42, ClimateScore = 75,
            CostOfLivingIndex = 28, AverageRentUSD = 300, AverageSalaryUSD = 600,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 3, AllowsDualCitizenship = true,
            IranianPopulation = 50, HasIranianCommunity = false,
            HealthcareSystem = "بیمه همگانی (IESS)", UniversalHealthcare = true,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "گرمسیری/معتدل", DistanceFromIranKm = 14500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای بازنشستگی/سرمایه‌گذاری", Type = "اقامت موقت - منجر به دائم", Duration = "۲ سال",
                    MinIncomeUSD = 1300,
                    Requirements = new() { "درآمد حداقل ۱,۳۰۰ دلار/ماه", "یا سرمایه‌گذاری ۴۵,۰۰۰ دلار در ملک", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "تابعیت پس از ۳ سال", "اقتصاد دلارمحور", "طبیعت متنوع", "هزینه زندگی پایین" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "ناامنی رو به افزایش", "زلزله‌خیز", "نیاز به زبان اسپانیایی", "فاصله زیاد" }
        },

        // ═══════════ بولیوی ═══════════
        new Country
        {
            Name = "Bolivia", NamePersian = "بولیوی", FlagEmoji = "🇧🇴", Continent = "آمریکای جنوبی",
            QualityOfLifeScore = 45, SafetyScore = 48, HealthcareScore = 38, EducationScore = 42,
            EconomicOpportunityScore = 35, PoliticalStabilityScore = 38, ClimateScore = 60,
            CostOfLivingIndex = 18, AverageRentUSD = 150, AverageSalaryUSD = 350,
            OfficialLanguages = new() { "اسپانیایی", "کچوا", "آیمارا" }, EnglishWidelySpoken = false,
            CitizenshipYears = 3, AllowsDualCitizenship = true,
            IranianPopulation = 20, HasIranianCommunity = false,
            HealthcareSystem = "دولتی (ضعیف)", UniversalHealthcare = true,
            EducationSystemQuality = "ضعیف", FreeEducation = true,
            Climate = "معتدل/سرد (آلتیپلان)", DistanceFromIranKm = 15000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه", "محل اقامت" },
                    Benefits = new() { "تابعیت پس از ۳ سال", "ارزان‌ترین کشور آمریکای جنوبی", "طبیعت متنوع", "فرهنگ بومی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "فقر بالا", "زیرساخت ضعیف", "ارتفاع زیاد", "بی‌ثباتی سیاسی" }
        },

        // ═══════════ ونزوئلا ═══════════
        new Country
        {
            Name = "Venezuela", NamePersian = "ونزوئلا", FlagEmoji = "🇻🇪", Continent = "آمریکای جنوبی",
            QualityOfLifeScore = 30, SafetyScore = 20, HealthcareScore = 20, EducationScore = 35,
            EconomicOpportunityScore = 20, PoliticalStabilityScore = 15, ClimateScore = 75,
            CostOfLivingIndex = 15, AverageRentUSD = 100, AverageSalaryUSD = 100,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 200, HasIranianCommunity = false,
            HealthcareSystem = "آسیب‌دیده", UniversalHealthcare = false,
            EducationSystemQuality = "ضعیف", FreeEducation = true,
            Climate = "گرمسیری", DistanceFromIranKm = 13000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new(),
            Restrictions = new() { "بحران اقتصادی شدید", "ناامنی", "بی‌ثباتی سیاسی", "تورم فوق‌العاده بالا", "عدم توصیه" }
        },

        // ═══════════ گواتمالا ═══════════
        new Country
        {
            Name = "Guatemala", NamePersian = "گواتمالا", FlagEmoji = "🇬🇹", Continent = "آمریکای مرکزی",
            QualityOfLifeScore = 48, SafetyScore = 38, HealthcareScore = 40, EducationScore = 42,
            EconomicOpportunityScore = 38, PoliticalStabilityScore = 40, ClimateScore = 75,
            CostOfLivingIndex = 25, AverageRentUSD = 250, AverageSalaryUSD = 450,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 20, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی (IGSS)", UniversalHealthcare = false,
            EducationSystemQuality = "ضعیف", FreeEducation = true,
            Climate = "گرمسیری", DistanceFromIranKm = 13000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت", Type = "اقامت موقت", Duration = "۲ سال",
                    MinIncomeUSD = 1000,
                    Requirements = new() { "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه", "محل اقامت" },
                    Benefits = new() { "هزینه زندگی پایین", "طبیعت زیبا", "فرهنگ مایایی", "آب‌وهوای خوب" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "ناامنی بالا", "فقر", "زبان اسپانیایی", "فاصله زیاد" }
        },

        // ═══════════ هندوراس ═══════════
        new Country
        {
            Name = "Honduras", NamePersian = "هندوراس", FlagEmoji = "🇭🇳", Continent = "آمریکای مرکزی",
            QualityOfLifeScore = 40, SafetyScore = 25, HealthcareScore = 35, EducationScore = 38,
            EconomicOpportunityScore = 30, PoliticalStabilityScore = 32, ClimateScore = 75,
            CostOfLivingIndex = 22, AverageRentUSD = 200, AverageSalaryUSD = 350,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 10, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی (IHSS)", UniversalHealthcare = false,
            EducationSystemQuality = "ضعیف", FreeEducation = true,
            Climate = "گرمسیری", DistanceFromIranKm = 13000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت", Type = "اقامت موقت", Duration = "۱ سال",
                    Requirements = new() { "تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه", "محل اقامت" },
                    Benefits = new() { "هزینه زندگی پایین", "طبیعت کارائیب", "فرهنگ غنی", "نزدیکی به آمریکا" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "ناامنی بسیار بالا", "فقر", "زبان اسپانیایی", "عدم توصیه" }
        },

        // ═══════════ السالوادور ═══════════
        new Country
        {
            Name = "El Salvador", NamePersian = "السالوادور", FlagEmoji = "🇸🇻", Continent = "آمریکای مرکزی",
            QualityOfLifeScore = 48, SafetyScore = 55, HealthcareScore = 42, EducationScore = 42,
            EconomicOpportunityScore = 38, PoliticalStabilityScore = 45, ClimateScore = 75,
            CostOfLivingIndex = 25, AverageRentUSD = 250, AverageSalaryUSD = 400,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 10, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی (ISSS)", UniversalHealthcare = false,
            EducationSystemQuality = "ضعیف", FreeEducation = true,
            Climate = "گرمسیری", DistanceFromIranKm = 13000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای دیجیتال نومد / Bitcoin", Type = "اقامت موقت", Duration = "۲ سال",
                    Requirements = new() { "کار ریموت یا سرمایه‌گذاری", "بیمه درمانی", "عدم سوءپیشینه", "تمکن مالی" },
                    Benefits = new() { "اقتصاد بیتکوینی", "هزینه زندگی پایین", "طبیعت زیبا", "بهبود امنیت" },
                    ProcessingTimeMonths = 1, LeadsToPR = false, LeadsToCitizenship = false
                }
            },
            Restrictions = new() { "سابقه ناامنی", "کشور کوچک", "زبان اسپانیایی", "فاصله زیاد" }
        },

        // ═══════════ نیکاراگوئه ═══════════
        new Country
        {
            Name = "Nicaragua", NamePersian = "نیکاراگوئه", FlagEmoji = "🇳🇮", Continent = "آمریکای مرکزی",
            QualityOfLifeScore = 42, SafetyScore = 42, HealthcareScore = 35, EducationScore = 38,
            EconomicOpportunityScore = 28, PoliticalStabilityScore = 25, ClimateScore = 78,
            CostOfLivingIndex = 20, AverageRentUSD = 180, AverageSalaryUSD = 300,
            OfficialLanguages = new() { "اسپانیایی" }, EnglishWidelySpoken = false,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 5, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی (INSS)", UniversalHealthcare = false,
            EducationSystemQuality = "ضعیف", FreeEducation = true,
            Climate = "گرمسیری", DistanceFromIranKm = 13500,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای اقامت از درآمد", Type = "اقامت موقت", Duration = "۱ سال",
                    MinIncomeUSD = 600,
                    Requirements = new() { "اثبات درآمد ماهانه", "بیمه درمانی", "عدم سوءپیشینه", "محل اقامت" },
                    Benefits = new() { "ارزان‌ترین کشور آمریکای مرکزی", "طبیعت زیبا", "آب‌وهوای گرم", "هزینه زندگی پایین" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "حکومت اقتدارگرا", "فقر بالا", "زبان اسپانیایی", "عدم توصیه" }
        },

        // ═══════════ بلیز ═══════════
        new Country
        {
            Name = "Belize", NamePersian = "بلیز", FlagEmoji = "🇧🇿", Continent = "آمریکای مرکزی",
            QualityOfLifeScore = 55, SafetyScore = 48, HealthcareScore = 42, EducationScore = 48,
            EconomicOpportunityScore = 38, PoliticalStabilityScore = 62, ClimateScore = 80,
            CostOfLivingIndex = 30, AverageRentUSD = 300, AverageSalaryUSD = 500,
            OfficialLanguages = new() { "انگلیسی" }, EnglishWidelySpoken = true,
            CitizenshipYears = 5, AllowsDualCitizenship = true,
            IranianPopulation = 5, HasIranianCommunity = false,
            HealthcareSystem = "بیمه اجتماعی (NHI)", UniversalHealthcare = false,
            EducationSystemQuality = "متوسط", FreeEducation = true,
            Climate = "گرمسیری کارائیب", DistanceFromIranKm = 13000,
            DataVersion = "2026.08", LastUpdated = "2026-09-01",
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای QRP (Qualified Retired Persons)", Type = "اقامت موقت", Duration = "۱ سال (قابل تمدید)",
                    MinIncomeUSD = 2000,
                    Requirements = new() { "سن بالای ۴۵ سال", "درآمد حداقل ۲,۰۰۰ دلار/ماه", "بیمه درمانی", "عدم سوءپیشینه" },
                    Benefits = new() { "اقامت با تخفیف مالیاتی", "زبان انگلیسی", "طبیعت کارائیب", "غواصی عالی" },
                    ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
                }
            },
            Restrictions = new() { "کشور کوچک", "بازار کار محدود", "ناامنی در برخی مناطق", "فاصله زیاد" }
        }
    };
}
