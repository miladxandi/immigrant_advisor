using ImmigrantAdvisor.Shared.Models;

namespace ImmigrantAdvisor.Shared.Data;

// داده‌های کشورها - بروزرسانی August/September 2026
// شامل ۸۲ کشور از مناطق مختلف جهان
public static class CountryData
{
    public static List<Country> GetCountries()
    {
        var countries = new List<Country>();
        
        // اتحادیه اروپا (۲۷ کشور)
        countries.AddRange(EuCountryData.GetCountries());
        
        // حوزه CIS (۱۲ کشور)
        countries.AddRange(CisCountryData.GetCountries());
        
        // منطقه MENA (۱۷ کشور)
        countries.AddRange(MenacountryData.GetCountries());
        
        // قاره آمریکا (۲۰ کشور)
        countries.AddRange(AmericasCountryData.GetCountries());
        
        // اقیانوسیه
        countries.Add(OceaniaAustralia());
        countries.Add(OceaniaNewZealand());
        
        // خاورمیانه (خارج از MENA)
        countries.Add(MiddleEastTurkey());
        countries.Add(MiddleEastUAE());
        
        // آفریقا
        countries.Add(AfricaSouthAfrica());
        
        return countries;
    }

    // ═══════════ استرالیا ═══════════
    private static Country OceaniaAustralia() => new()
    {
        Name = "Australia", NamePersian = "استرالیا", FlagEmoji = "🇦🇺", Continent = "اقیانوسیه",
        QualityOfLifeScore = 93, SafetyScore = 90, HealthcareScore = 88, EducationScore = 88,
        EconomicOpportunityScore = 83, PoliticalStabilityScore = 92, ClimateScore = 80,
        CostOfLivingIndex = 78, AverageRentUSD = 2000, AverageSalaryUSD = 5200,
        OfficialLanguages = new() { "انگلیسی" }, EnglishWidelySpoken = true,
        CitizenshipYears = 4, AllowsDualCitizenship = true,
        IranianPopulation = 62000, HasIranianCommunity = true,
        HealthcareSystem = "Medicare (همگانی)", UniversalHealthcare = true,
        EducationSystemQuality = "عالی", FreeEducation = false,
        Climate = "گرم و معتدل", DistanceFromIranKm = 12000,
        DataVersion = "2026.08", LastUpdated = "2026-09-01",
        VisaOptions = new()
        {
            new VisaOption
            {
                Name = "ویزای مهارت مستقل (Subclass 189) - بروزرسانی 2026", Type = "اقامت دائم", Duration = "دائمی",
                MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Advanced,
                MinExperienceYears = 2,
                Requirements = new() { "شغل در لیست مشاغل مورد نیاز (SOL)", "ارزیابی مهارت مثبت", "نمره IELTS حداقل ۶ در هر مهارت", "سن زیر ۴۵ سال", "حداقل ۶۵ امتیاز" },
                Benefits = new() { "اقامت دائم بدون اسپانسر", "حق کار و تحصیل", "دسترسی به Medicare", "امکان تابعیت پس از ۴ سال" },
                ProcessingTimeMonths = 10, LeadsToPR = true, LeadsToCitizenship = true
            },
            new VisaOption
            {
                Name = "ویزای اسپانسر کارفرما (Subclass 482)", Type = "موقت - منجر به اقامت", Duration = "۲ تا ۴ سال",
                MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Intermediate,
                MinExperienceYears = 2,
                Requirements = new() { "پیشنهاد شغلی از کارفرمای تأییدشده", "حداقل ۲ سال سابقه", "IELTS حداقل ۵", "شغل در لیست واجد شرایط" },
                Benefits = new() { "اقامت موقت با امکان تبدیل به دائم", "الحاق خانواده", "حقوق مناسب", "مسیر به PR پس از ۲-۳ سال" },
                ProcessingTimeMonths = 4, LeadsToPR = true, LeadsToCitizenship = true
            },
            new VisaOption
            {
                Name = "ویزای تحصیلی (Subclass 500)", Type = "موقت", Duration = "۱ تا ۵ سال",
                MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                Requirements = new() { "پذیرش از مؤسسه معتبر", "تمکن مالی", "IELTS مناسب", "بیمه درمانی (OSHC)" },
                Benefits = new() { "اجازه کار ۴۸ ساعت در دو هفته", "ویزای کار پس از فارغ‌التحصیلی (۲-۴ سال)", "الحاق خانواده", "مسیر به PR" },
                ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
            },
            new VisaOption
            {
                Name = "ویزای سرمایه‌گذاری (Subclass 188) - بروزرسانی 2026", Type = "موقت - منجر به اقامت", Duration = "۴ سال",
                MinInvestmentUSD = 500000,
                Requirements = new() { "حداقل سرمایه ۸۰۰,۰۰۰ دلار استرالیا", "سابقه مدیریت کسب‌وکار", "سن زیر ۵۵ سال", "IELTS حداقل ۵" },
                Benefits = new() { "اقامت ۴ ساله", "تبدیل به PR پس از ۲ سال", "الحاق خانواده", "آزادی کسب‌وکار" },
                ProcessingTimeMonths = 12, LeadsToPR = true, LeadsToCitizenship = true
            }
        },
        Restrictions = new() { "فاصله زیاد از ایران", "هزینه زندگی بالا", "فرآیند ویزای رقابتی", "حیوانات وحشی" }
    };

    // ═══════════ نیوزیلند ═══════════
    private static Country OceaniaNewZealand() => new()
    {
        Name = "New Zealand", NamePersian = "نیوزیلند", FlagEmoji = "🇳🇿", Continent = "اقیانوسیه",
        QualityOfLifeScore = 90, SafetyScore = 91, HealthcareScore = 82, EducationScore = 85,
        EconomicOpportunityScore = 72, PoliticalStabilityScore = 93, ClimateScore = 82,
        CostOfLivingIndex = 65, AverageRentUSD = 1400, AverageSalaryUSD = 3900,
        OfficialLanguages = new() { "انگلیسی", "مائوری" }, EnglishWidelySpoken = true,
        CitizenshipYears = 5, AllowsDualCitizenship = true,
        IranianPopulation = 5000, HasIranianCommunity = false,
        HealthcareSystem = "همگانی", UniversalHealthcare = true,
        EducationSystemQuality = "عالی", FreeEducation = true,
        Climate = "معتدل اقیانوسی", DistanceFromIranKm = 14000,
        DataVersion = "2026.08", LastUpdated = "2026-09-01",
        VisaOptions = new()
        {
            new VisaOption
            {
                Name = "ویزای مهارت (Skilled Migrant) - بروزرسانی 2026", Type = "اقامت دائم", Duration = "دائمی",
                MinEducation = EducationLevel.BachelorDegree, MinLanguageLevel = LanguageProficiency.Advanced,
                MinExperienceYears = 2,
                Requirements = new() { "سن زیر ۵۵ سال", "شغل در لیست Skill Shortage", "IELTS حداقل ۶.۵", "حداقل امتیاز", "سلامت خوب" },
                Benefits = new() { "اقامت دائم", "حق کار و تحصیل", "دسترسی به خدمات اجتماعی", "امکان تابعیت پس از ۵ سال" },
                ProcessingTimeMonths = 12, LeadsToPR = true, LeadsToCitizenship = true
            },
            new VisaOption
            {
                Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۳ سال",
                MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                Requirements = new() { "پذیرش از مؤسسه معتبر", "تمکن مالی", "IELTS 5.5+", "بیمه درمانی" },
                Benefits = new() { "ویزای کار ۱-۳ ساله", "اجازه کار پاره‌وقت", "محیط طبیعی زیبا", "امنیت بالا" },
                ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
            }
        },
        Restrictions = new() { "فاصله بسیار زیاد از ایران", "بازار کار کوچک", "هزینه زندگی بالا", "جمعیت ایرانی کم" }
    };

    // ═══════════ ترکیه ═══════════
    private static Country MiddleEastTurkey() => new()
    {
        Name = "Turkey", NamePersian = "ترکیه", FlagEmoji = "🇹🇷", Continent = "اروپا/آسیا",
        QualityOfLifeScore = 65, SafetyScore = 55, HealthcareScore = 70, EducationScore = 60,
        EconomicOpportunityScore = 55, PoliticalStabilityScore = 45, ClimateScore = 85,
        CostOfLivingIndex = 35, AverageRentUSD = 500, AverageSalaryUSD = 800,
        OfficialLanguages = new() { "ترکی" }, EnglishWidelySpoken = false,
        CitizenshipYears = 5, AllowsDualCitizenship = true,
        IranianPopulation = 200000, HasIranianCommunity = true,
        HealthcareSystem = "بیمه همگانی", UniversalHealthcare = true,
        EducationSystemQuality = "متوسط", FreeEducation = true,
        Climate = "مدیترانه‌ای", DistanceFromIranKm = 500,
        DataVersion = "2026.08", LastUpdated = "2026-09-01",
        VisaOptions = new()
        {
            new VisaOption
            {
                Name = "اقامت از طریق خرید ملک - بروزرسانی 2026", Type = "اقامت موقت - منجر به تابعیت", Duration = "۱ سال (قابل تمدید)",
                MinInvestmentUSD = 200000,
                Requirements = new() { "خرید ملک حداقل ۲۰۰,۰۰۰ دلار", "اثبات تمکن مالی", "بیمه درمانی", "عدم سوءپیشینه" },
                Benefits = new() { "اقامت موقت قابل تمدید", "تابعیت با سرمایه ۴۰۰,۰۰۰ دلار", "نزدیکی به ایران", "هزینه زندگی پایین" },
                ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
            },
            new VisaOption
            {
                Name = "ویزای کار", Type = "اقامت موقت", Duration = "۱ سال",
                MinEducation = EducationLevel.HighSchool,
                Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "مدرک زبان ترکی (مزیت)", "عدم سوءپیشینه" },
                Benefits = new() { "اقامت قابل تمدید", "نزدیکی به ایران", "هزینه زندگی پایین", "فرهنگ نزدیک" },
                ProcessingTimeMonths = 2, LeadsToPR = false, LeadsToCitizenship = true
            },
            new VisaOption
            {
                Name = "ویزای تحصیلی", Type = "موقت", Duration = "۱ تا ۴ سال",
                MinEducation = EducationLevel.HighSchool,
                Requirements = new() { "پذیرش از دانشگاه معتبر", "تمکن مالی", "بیمه درمانی" },
                Benefits = new() { "شهریه پایین", "نزدیکی به ایران", "امکان کار پاره‌وقت", "کیفیت زندگی مناسب" },
                ProcessingTimeMonths = 2, LeadsToPR = false, LeadsToCitizenship = false
            }
        },
        Restrictions = new() { "بی‌ثباتی اقتصادی و تورم", "وضعیت سیاسی ناپایدار", "نیاز به زبان ترکی", "بازار کار محدود" }
    };

    // ═══════════ امارات متحده عربی ═══════════
    private static Country MiddleEastUAE() => new()
    {
        Name = "United Arab Emirates", NamePersian = "امارات متحده عربی", FlagEmoji = "🇦🇪", Continent = "آسیا",
        QualityOfLifeScore = 80, SafetyScore = 92, HealthcareScore = 82, EducationScore = 72,
        EconomicOpportunityScore = 80, PoliticalStabilityScore = 85, ClimateScore = 50,
        CostOfLivingIndex = 70, AverageRentUSD = 1500, AverageSalaryUSD = 4200,
        OfficialLanguages = new() { "عربی", "انگلیسی" }, EnglishWidelySpoken = true,
        CitizenshipYears = 20, AllowsDualCitizenship = true,
        IranianPopulation = 500000, HasIranianCommunity = true,
        HealthcareSystem = "بیمه خصوصی اجباری", UniversalHealthcare = false,
        EducationSystemQuality = "خوب", FreeEducation = false,
        Climate = "گرم و خشک بیابانی", DistanceFromIranKm = 1000,
        DataVersion = "2026.08", LastUpdated = "2026-09-01",
        VisaOptions = new()
        {
            new VisaOption
            {
                Name = "ویزای طلایی (Golden Visa) - بروزرسانی 2026", Type = "اقامت بلندمدت", Duration = "۱۰ سال",
                MinInvestmentUSD = 550000,
                Requirements = new() { "سرمایه‌گذاری ۲ میلیون درهم در ملک", "یا ۷۵۰,۰۰۰ درهم در صندوق", "یا سپرده ۲ میلیون درهمی", "یا حقوق ماهانه ۳۰,۰۰۰ درهم" },
                Benefits = new() { "اقامت ۱۰ ساله بدون اسپانسر", "الحاق خانواده", "مالیات صفر بر درآمد", "دسترسی به خدمات بهداشتی و آموزشی" },
                ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = false
            },
            new VisaOption
            {
                Name = "ویزای کار", Type = "اقامت موقت", Duration = "۲ سال",
                Requirements = new() { "پیشنهاد شغلی", "مجوز کار", "آزمایشات پزشکی", "بیمه درمانی" },
                Benefits = new() { "حقوق معاف از مالیات", "امنیت بالا", "نزدیکی به ایران", "جامعه بزرگ ایرانی" },
                ProcessingTimeMonths = 1, LeadsToPR = false, LeadsToCitizenship = false
            },
            new VisaOption
            {
                Name = "ویزای فریلنسر/خوداشتغال", Type = "اقامت موقت", Duration = "۱ تا ۲ سال",
                MinIncomeUSD = 3000,
                Requirements = new() { "مجوز فریلنسری", "اثبات درآمد ماهانه حداقل ۵,۰۰۰ دلار", "بیمه درمانی", "تمکن مالی" },
                Benefits = new() { "امکان کار آزاد", "مالیات صفر", "نزدیکی به ایران", "زیرساخت مناسب" },
                ProcessingTimeMonths = 1, LeadsToPR = false, LeadsToCitizenship = false
            }
        },
        Restrictions = new() { "آب‌وهوای بسیار گرم", "عدم امکان تابعیت آسان", "قوانین سخت‌گیرانه اجتماعی", "هزینه زندگی بالا در دبی" }
    };

    // ═══════════ آفریقای جنوبی ═══════════
    private static Country AfricaSouthAfrica() => new()
    {
        Name = "South Africa", NamePersian = "آفریقای جنوبی", FlagEmoji = "🇿🇦", Continent = "آفریقا",
        QualityOfLifeScore = 55, SafetyScore = 35, HealthcareScore = 52, EducationScore = 58,
        EconomicOpportunityScore = 52, PoliticalStabilityScore = 55, ClimateScore = 78,
        CostOfLivingIndex = 35, AverageRentUSD = 500, AverageSalaryUSD = 1500,
        OfficialLanguages = new() { "انگلیسی", "آفریکانس", "زولو", "کوسا" }, EnglishWidelySpoken = true,
        CitizenshipYears = 5, AllowsDualCitizenship = true,
        IranianPopulation = 500, HasIranianCommunity = false,
        HealthcareSystem = "بیمه خصوصی/دولتی", UniversalHealthcare = false,
        EducationSystemQuality = "متوسط", FreeEducation = true,
        Climate = "معتدل گرمسیری", DistanceFromIranKm = 9000,
        DataVersion = "2026.08", LastUpdated = "2026-09-01",
        VisaOptions = new()
        {
            new VisaOption
            {
                Name = "ویزای کار تخصصی (Critical Skills)", Type = "اقامت موقت - منجر به دائم", Duration = "تا ۵ سال",
                MinEducation = EducationLevel.BachelorDegree, MinExperienceYears = 2,
                Requirements = new() { "شغل در لیست Critical Skills", "پیشنهاد شغلی", "ارزیابی مهارت", "بیمه درمانی" },
                Benefits = new() { "اقامت کار", "مسیر به PR", "زبان انگلیسی", "اقتصاد متنوع آفریقا" },
                ProcessingTimeMonths = 3, LeadsToPR = true, LeadsToCitizenship = true
            },
            new VisaOption
            {
                Name = "ویزای تحصیلی", Type = "موقت", Duration = "تحصیل + ۱ سال",
                MinEducation = EducationLevel.HighSchool, MinLanguageLevel = LanguageProficiency.Intermediate,
                Requirements = new() { "پذیرش از دانشگاه", "تمکن مالی", "بیمه درمانی", "محل اقامت" },
                Benefits = new() { "دانشگاه‌های معتبر", "هزینه زندگی پایین", "زبان انگلیسی", "طبیعت زیبا" },
                ProcessingTimeMonths = 2, LeadsToPR = true, LeadsToCitizenship = true
            },
            new VisaOption
            {
                Name = "ویزای بازنشستگی", Type = "اقامت موقت", Duration = "۴ سال",
                MinIncomeUSD = 1500,
                Requirements = new() { "حقوق بازنشستگی حداقل ۳۷,۰۰۰ رند/ماه", "بیمه درمانی", "عدم سوءپیشینه", "تمکن مالی" },
                Benefits = new() { "اقامت ۴ ساله", "هزینه زندگی پایین", "آب‌وهوای عالی", "طبیعت فوق‌العاده" },
                ProcessingTimeMonths = 3, LeadsToPR = false, LeadsToCitizenship = false
            }
        },
        Restrictions = new() { "ناامنی بالا (جنایت)", "فاصله از ایران", "بازار کار رقابتی", "تفاوت فرهنگی زیاد" }
    };
}
