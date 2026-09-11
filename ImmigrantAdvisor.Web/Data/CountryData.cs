using ImmigrantAdvisor.Web.Models;

namespace ImmigrantAdvisor.Web.Data;

public static class CountryData
{
    public static List<Country> GetCountries() => new()
    {
        new Country
        {
            Name = "Canada",
            NamePersian = "کانادا",
            FlagEmoji = "🇨🇦",
            Continent = "آمریکای شمالی",
            QualityOfLifeScore = 92,
            SafetyScore = 88,
            HealthcareScore = 90,
            EducationScore = 92,
            EconomicOpportunityScore = 85,
            PoliticalStabilityScore = 95,
            ClimateScore = 40,
            CostOfLivingIndex = 72,
            AverageRentUSD = 1800,
            AverageSalaryUSD = 4500,
            OfficialLanguages = new() { "انگلیسی", "فرانسوی" },
            EnglishWidelySpoken = true,
            CitizenshipYears = 3,
            AllowsDualCitizenship = true,
            IranianPopulation = 250000,
            HasIranianCommunity = true,
            HealthcareSystem = "همگانی رایگان",
            UniversalHealthcare = true,
            EducationSystemQuality = "عالی",
            FreeEducation = true,
            Climate = "قاره‌ای سرد و معتدل",
            DistanceFromIranKm = 10000,
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "اکسپرس انتری (Express Entry)",
                    Type = "اقامت دائم",
                    Duration = "دائمی",
                    MinEducation = EducationLevel.BachelorDegree,
                    MinLanguageLevel = LanguageProficiency.Advanced,
                    MinExperienceYears = 1,
                    Requirements = new()
                    {
                        "حداقل مدرک لیسانس",
                        "حداقل ۱ سال سابقه کار مرتبط",
                        "نمره IELTS حداقل ۶ در هر مهارت",
                        "اثبات تمکن مالی",
                        "آزمایشات پزشکی"
                    },
                    Benefits = new()
                    {
                        "اقامت دائم از روز اول",
                        "حق کار در هر نقطه کانادا",
                        "دسترسی به خدمات بهداشتی رایگان",
                        "امکان دریافت تابعیت پس از ۳ سال",
                        "تحصیل رایگان فرزندان"
                    },
                    ProcessingTimeMonths = 6,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای استارتاپ (Start-Up Visa)",
                    Type = "اقامت دائم",
                    Duration = "دائمی",
                    MinEducation = EducationLevel.BachelorDegree,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new()
                    {
                        "ایده نوآورانه و قابل توسعه",
                        "پشتیبانی یکی از سازمان‌های تعیین‌شده",
                        "نمره زبان CLB 5",
                        "تمکن مالی برای استقرار"
                    },
                    Benefits = new()
                    {
                        "اقامت دائم بدون نیاز به سرمایه بالا",
                        "امکان راه‌اندازی کسب‌وکار",
                        "دسترسی به اکوسیستم نوآوری کانادا"
                    },
                    ProcessingTimeMonths = 12,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی",
                    Type = "موقت - منجر به اقامت",
                    Duration = "۲ تا ۴ سال",
                    MinEducation = EducationLevel.HighSchool,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new()
                    {
                        "پذیرش از دانشگاه معتبر",
                        "تمکن مالی برای شهریه و زندگی",
                        "نمره زبان مناسب",
                        "انگیزه‌نامه قوی"
                    },
                    Benefits = new()
                    {
                        "امکان کار پاره‌وقت حین تحصیل",
                        "ویزای کار پس از فارغ‌التحصیلی (PGWP)",
                        "مسیر هموار به اقامت دائم",
                        "تحصیل رایگان فرزندان"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "برنامه‌های استانی (PNP)",
                    Type = "اقامت دائم",
                    Duration = "دائمی",
                    MinEducation = EducationLevel.Diploma,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    MinExperienceYears = 1,
                    Requirements = new()
                    {
                        "پیشنهاد شغلی از کارفرمای استان",
                        "تطابق با مشاغل مورد نیاز استان",
                        "نمره زبان مناسب",
                        "تمایل به زندگی در آن استان"
                    },
                    Benefits = new()
                    {
                        "امتیاز اضافی برای اکسپرس انتری",
                        "اقامت دائم",
                        "فرصت‌های شغلی متنوع"
                    },
                    ProcessingTimeMonths = 18,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                }
            },
            Restrictions = new()
            {
                "آب‌وهوای سرد در زمستان",
                "هزینه زندگی بالا در شهرهای بزرگ",
                "نیاز به یادگیری زبان (انگلیسی یا فرانسوی)"
            }
        },
        new Country
        {
            Name = "Germany",
            NamePersian = "آلمان",
            FlagEmoji = "🇩🇪",
            Continent = "اروپا",
            QualityOfLifeScore = 90,
            SafetyScore = 85,
            HealthcareScore = 92,
            EducationScore = 90,
            EconomicOpportunityScore = 82,
            PoliticalStabilityScore = 90,
            ClimateScore = 55,
            CostOfLivingIndex = 65,
            AverageRentUSD = 1200,
            AverageSalaryUSD = 4200,
            OfficialLanguages = new() { "آلمانی" },
            EnglishWidelySpoken = false,
            CitizenshipYears = 5,
            AllowsDualCitizenship = true,
            IranianPopulation = 50000,
            HasIranianCommunity = true,
            HealthcareSystem = "بیمه اجباری",
            UniversalHealthcare = true,
            EducationSystemQuality = "عالی",
            FreeEducation = true,
            Climate = "معتدل قاره‌ای",
            DistanceFromIranKm = 3500,
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار تخصصی (Fachkräfteeinwanderungsgesetz)",
                    Type = "اقامت موقت - منجر به دائم",
                    Duration = "۱ تا ۴ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    MinExperienceYears = 2,
                    Requirements = new()
                    {
                        "مدرک دانشگاهی معتبر یا فنی‌حرفه‌ای",
                        "پیشنهاد شغلی مرتبط",
                        "مدرک زبان آلمانی B1",
                        "تطابق مدرک با شغل"
                    },
                    Benefits = new()
                    {
                        "اقامت کار تا ۴ سال",
                        "امکان الحاق خانواده",
                        "مسیر به اقامت دائم پس از ۴ سال",
                        "دسترسی به سیستم بهداشتی عالی"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "بلوکارت اتحادیه اروپا (Blaue Karte EU)",
                    Type = "اقامت موقت - منجر به دائم",
                    Duration = "۱ تا ۴ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    MinLanguageLevel = LanguageProficiency.Basic,
                    MinExperienceYears = 2,
                    MinIncomeUSD = 4500,
                    Requirements = new()
                    {
                        "مدرک دانشگاهی",
                        "پیشنهاد شغلی با حقوق حداقلی مشخص",
                        "مدرک زبان آلمانی A1",
                        "شغل در لیست مشاغل مورد نیاز"
                    },
                    Benefits = new()
                    {
                        "اقامت سریع‌تر (۲۱ ماه با B1)",
                        "حرکت آزاد در اتحادیه اروپا",
                        "حقوق بالاتر از میانگین",
                        "الحاق خانواده آسان"
                    },
                    ProcessingTimeMonths = 2,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی",
                    Type = "موقت - منجر به اقامت",
                    Duration = "۲ تا ۳ سال",
                    MinEducation = EducationLevel.HighSchool,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new()
                    {
                        "پذیرش از دانشگاه آلمانی",
                        "تمکن مالی (حساب مسدود ~۱۱,۰۰۰ یورو)",
                        "مدرک زبان آلمانی B2 یا انگلیسی IELTS 6.5",
                        "بیمه درمانی"
                    },
                    Benefits = new()
                    {
                        "تحصیل رایگان در دانشگاه‌های دولتی",
                        "اجازه کار ۱۲۰ روز کامل در سال",
                        "ویزای کار ۱۸ ماهه پس از فارغ‌التحصیلی",
                        "مسیر هموار به اقامت دائم"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای جستجوی کار (Jobseeker Visa)",
                    Type = "موقت",
                    Duration = "۶ ماه",
                    MinEducation = EducationLevel.BachelorDegree,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new()
                    {
                        "مدرک دانشگاهی معتبر",
                        "تمکن مالی برای ۶ ماه",
                        "مدرک زبان آلمانی B1",
                        "رزومه و برنامه جستجوی کار"
                    },
                    Benefits = new()
                    {
                        "امکان جستجوی کار در آلمان",
                        "تبدیل به ویزای کار پس از یافتن شغل",
                        "بدون نیاز به پیشنهاد شغلی اولیه"
                    },
                    ProcessingTimeMonths = 2,
                    LeadsToPR = false,
                    LeadsToCitizenship = false
                }
            },
            Restrictions = new()
            {
                "نیاز به یادگیری زبان آلمانی",
                "فرآیند معادل‌سازی مدارک پیچیده",
                "مالیات بالا"
            }
        },
        new Country
        {
            Name = "Australia",
            NamePersian = "استرالیا",
            FlagEmoji = "🇦🇺",
            Continent = "اقیانوسیه",
            QualityOfLifeScore = 93,
            SafetyScore = 90,
            HealthcareScore = 88,
            EducationScore = 88,
            EconomicOpportunityScore = 83,
            PoliticalStabilityScore = 92,
            ClimateScore = 80,
            CostOfLivingIndex = 78,
            AverageRentUSD = 2000,
            AverageSalaryUSD = 5000,
            OfficialLanguages = new() { "انگلیسی" },
            EnglishWidelySpoken = true,
            CitizenshipYears = 4,
            AllowsDualCitizenship = true,
            IranianPopulation = 60000,
            HasIranianCommunity = true,
            HealthcareSystem = "Medicare (همگانی)",
            UniversalHealthcare = true,
            EducationSystemQuality = "عالی",
            FreeEducation = false,
            Climate = "گرم و معتدل",
            DistanceFromIranKm = 12000,
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای مهارت مستقل (Subclass 189)",
                    Type = "اقامت دائم",
                    Duration = "دائمی",
                    MinEducation = EducationLevel.BachelorDegree,
                    MinLanguageLevel = LanguageProficiency.Advanced,
                    MinExperienceYears = 2,
                    Requirements = new()
                    {
                        "شغل در لیست مشاغل مورد نیاز (SOL)",
                        "ارزیابی مهارت مثبت",
                        "نمره IELTS حداقل ۶ در هر مهارت",
                        "سن زیر ۴۵ سال",
                        "حداقل ۶۵ امتیاز در سیستم امتیازبندی"
                    },
                    Benefits = new()
                    {
                        "اقامت دائم بدون نیاز به اسپانسر",
                        "حق کار و تحصیل در هر نقطه استرالیا",
                        "دسترسی به Medicare",
                        "امکان تابعیت پس از ۴ سال"
                    },
                    ProcessingTimeMonths = 10,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای اسپانسر کارفرما (Subclass 482)",
                    Type = "موقت - منجر به اقامت",
                    Duration = "۲ تا ۴ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    MinExperienceYears = 2,
                    Requirements = new()
                    {
                        "پیشنهاد شغلی از کارفرمای تأییدشده",
                        "حداقل ۲ سال سابقه کار مرتبط",
                        "نمره IELTS حداقل ۵ در هر مهارت",
                        "شغل در لیست مشاغل واجد شرایط"
                    },
                    Benefits = new()
                    {
                        "اقامت موقت با امکان تبدیل به دائم",
                        "امکان الحاق خانواده",
                        "حقوق مناسب",
                        "مسیر به اقامت دائم پس از ۲-۳ سال"
                    },
                    ProcessingTimeMonths = 4,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی (Subclass 500)",
                    Type = "موقت",
                    Duration = "۱ تا ۵ سال",
                    MinEducation = EducationLevel.HighSchool,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new()
                    {
                        "پذیرش از مؤسسه آموزشی معتبر",
                        "تمکن مالی برای شهریه و زندگی",
                        "نمره IELTS مناسب",
                        "بیمه درمانی (OSHC)"
                    },
                    Benefits = new()
                    {
                        "اجازه کار ۴۸ ساعت در دو هفته",
                        "ویزای کار پس از فارغ‌التحصیلی (۲-۴ سال)",
                        "امکان الحاق خانواده",
                        "مسیر به اقامت دائم"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای سرمایه‌گذاری (Subclass 188)",
                    Type = "موقت - منجر به اقامت",
                    Duration = "۴ سال",
                    MinInvestmentUSD = 500000,
                    Requirements = new()
                    {
                        "حداقل سرمایه ۸۰۰,۰۰۰ دلار استرالیا",
                        "سابقه مدیریت کسب‌وکار موفق",
                        "سن زیر ۵۵ سال (با استثنا)",
                        "نمره IELTS حداقل ۵"
                    },
                    Benefits = new()
                    {
                        "اقامت موقت ۴ ساله",
                        "تبدیل به اقامت دائم پس از ۲ سال",
                        "امکان الحاق خانواده",
                        "آزادی عمل در کسب‌وکار"
                    },
                    ProcessingTimeMonths = 12,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                }
            },
            Restrictions = new()
            {
                "فاصله زیاد از ایران",
                "هزینه زندگی بالا",
                "فرآیند ویزای طولانی و رقابتی",
                "حیوانات وحشی و آب‌وهوای گرم"
            }
        },
        new Country
        {
            Name = "Turkey",
            NamePersian = "ترکیه",
            FlagEmoji = "🇹🇷",
            Continent = "اروپا/آسیا",
            QualityOfLifeScore = 65,
            SafetyScore = 55,
            HealthcareScore = 70,
            EducationScore = 60,
            EconomicOpportunityScore = 55,
            PoliticalStabilityScore = 45,
            ClimateScore = 85,
            CostOfLivingIndex = 35,
            AverageRentUSD = 500,
            AverageSalaryUSD = 800,
            OfficialLanguages = new() { "ترکی" },
            EnglishWidelySpoken = false,
            CitizenshipYears = 5,
            AllowsDualCitizenship = true,
            IranianPopulation = 200000,
            HasIranianCommunity = true,
            HealthcareSystem = "بیمه همگانی",
            UniversalHealthcare = true,
            EducationSystemQuality = "متوسط",
            FreeEducation = true,
            Climate = "مدیترانه‌ای",
            DistanceFromIranKm = 500,
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "اقامت از طریق خرید ملک",
                    Type = "اقامت موقت - منجر به تابعیت",
                    Duration = "۱ سال (قابل تمدید)",
                    MinInvestmentUSD = 200000,
                    Requirements = new()
                    {
                        "خرید ملک به ارزش حداقل ۲۰۰,۰۰۰ دلار",
                        "اثبات تمکن مالی",
                        "بیمه درمانی",
                        "عدم سوءپیشینه"
                    },
                    Benefits = new()
                    {
                        "اقامت موقت قابل تمدید",
                        "امکان دریافت تابعیت با سرمایه ۴۰۰,۰۰۰ دلار",
                        "نزدیکی به ایران",
                        "هزینه زندگی پایین",
                        "آب‌وهوای مناسب"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای کار",
                    Type = "اقامت موقت",
                    Duration = "۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new()
                    {
                        "پیشنهاد شغلی از کارفرمای ترک",
                        "مجوز کار",
                        "مدرک زبان ترکی (مزیت)",
                        "عدم سوءپیشینه"
                    },
                    Benefits = new()
                    {
                        "اقامت موقت قابل تمدید",
                        "نزدیکی به ایران",
                        "هزینه زندگی پایین",
                        "فرهنگ نزدیک به ایران"
                    },
                    ProcessingTimeMonths = 2,
                    LeadsToPR = false,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی",
                    Type = "موقت",
                    Duration = "۱ تا ۴ سال",
                    MinEducation = EducationLevel.HighSchool,
                    Requirements = new()
                    {
                        "پذیرش از دانشگاه معتبر",
                        "تمکن مالی",
                        "بیمه درمانی"
                    },
                    Benefits = new()
                    {
                        "شهریه پایین دانشگاه‌ها",
                        "نزدیکی به ایران",
                        "امکان کار پاره‌وقت",
                        "کیفیت زندگی مناسب"
                    },
                    ProcessingTimeMonths = 2,
                    LeadsToPR = false,
                    LeadsToCitizenship = false
                }
            },
            Restrictions = new()
            {
                "بی‌ثباتی اقتصادی و تورم بالا",
                "وضعیت سیاسی ناپایدار",
                "نیاز به یادگیری زبان ترکی",
                "بازار کار محدود برای خارجی‌ها"
            }
        },
        new Country
        {
            Name = "United Arab Emirates",
            NamePersian = "امارات متحده عربی",
            FlagEmoji = "🇦🇪",
            Continent = "آسیا",
            QualityOfLifeScore = 80,
            SafetyScore = 92,
            HealthcareScore = 82,
            EducationScore = 72,
            EconomicOpportunityScore = 80,
            PoliticalStabilityScore = 85,
            ClimateScore = 50,
            CostOfLivingIndex = 70,
            AverageRentUSD = 1500,
            AverageSalaryUSD = 4000,
            OfficialLanguages = new() { "عربی", "انگلیسی" },
            EnglishWidelySpoken = true,
            CitizenshipYears = 20,
            AllowsDualCitizenship = true,
            IranianPopulation = 500000,
            HasIranianCommunity = true,
            HealthcareSystem = "بیمه خصوصی اجباری",
            UniversalHealthcare = false,
            EducationSystemQuality = "خوب",
            FreeEducation = false,
            Climate = "گرم و خشک بیابانی",
            DistanceFromIranKm = 1000,
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای طلایی (Golden Visa)",
                    Type = "اقامت بلندمدت",
                    Duration = "۱۰ سال",
                    MinInvestmentUSD = 550000,
                    Requirements = new()
                    {
                        "سرمایه‌گذاری ۲ میلیون درهم در ملک",
                        "یا ۷۵۰,۰۰۰ درهم در صندوق سرمایه‌گذاری",
                        "یا سپرده ۲ میلیون درهمی",
                        "یا حقوق ماهانه ۳۰,۰۰۰ درهم"
                    },
                    Benefits = new()
                    {
                        "اقامت ۱۰ ساله بدون نیاز به اسپانسر",
                        "امکان الحاق خانواده",
                        "بدون نیاز به ویزای ورود و خروج",
                        "مالیات صفر بر درآمد",
                        "دسترسی به خدمات بهداشتی و آموزشی"
                    },
                    ProcessingTimeMonths = 2,
                    LeadsToPR = true,
                    LeadsToCitizenship = false
                },
                new VisaOption
                {
                    Name = "ویزای کار",
                    Type = "اقامت موقت",
                    Duration = "۲ سال",
                    Requirements = new()
                    {
                        "پیشنهاد شغلی از کارفرمای اماراتی",
                        "مجوز کار",
                        "آزمایشات پزشکی",
                        "بیمه درمانی"
                    },
                    Benefits = new()
                    {
                        "حقوق معاف از مالیات",
                        "امنیت بالا",
                        "نزدیکی به ایران",
                        "جامعه بزرگ ایرانی",
                        "زبان انگلیسی رایج"
                    },
                    ProcessingTimeMonths = 1,
                    LeadsToPR = false,
                    LeadsToCitizenship = false
                },
                new VisaOption
                {
                    Name = "ویزای فریلنسر/خوداشتغال",
                    Type = "اقامت موقت",
                    Duration = "۱ تا ۲ سال",
                    MinIncomeUSD = 3000,
                    Requirements = new()
                    {
                        "مجوز فریلنسری",
                        "اثبات درآمد ماهانه حداقل ۵,۰۰۰ دلار",
                        "بیمه درمانی",
                        "تمکن مالی"
                    },
                    Benefits = new()
                    {
                        "امکان کار آزاد",
                        "مالیات صفر",
                        "نزدیکی به ایران",
                        "زیرساخت مناسب"
                    },
                    ProcessingTimeMonths = 1,
                    LeadsToPR = false,
                    LeadsToCitizenship = false
                }
            },
            Restrictions = new()
            {
                "آب‌وهوای بسیار گرم",
                "عدم امکان تابعیت آسان",
                "قوانین سخت‌گیرانه اجتماعی",
                "هزینه زندگی بالا در دبی"
            }
        },
        new Country
        {
            Name = "Sweden",
            NamePersian = "سوئد",
            FlagEmoji = "🇸🇪",
            Continent = "اروپا",
            QualityOfLifeScore = 91,
            SafetyScore = 82,
            HealthcareScore = 85,
            EducationScore = 88,
            EconomicOpportunityScore = 78,
            PoliticalStabilityScore = 88,
            ClimateScore = 35,
            CostOfLivingIndex = 70,
            AverageRentUSD = 1100,
            AverageSalaryUSD = 3800,
            OfficialLanguages = new() { "سوئدی" },
            EnglishWidelySpoken = true,
            CitizenshipYears = 5,
            AllowsDualCitizenship = true,
            IranianPopulation = 70000,
            HasIranianCommunity = true,
            HealthcareSystem = "همگانی یارانه‌ای",
            UniversalHealthcare = true,
            EducationSystemQuality = "عالی",
            FreeEducation = true,
            Climate = "شمالی سرد",
            DistanceFromIranKm = 3800,
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار",
                    Type = "اقامت موقت - منجر به دائم",
                    Duration = "تا ۲ سال (قابل تمدید)",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new()
                    {
                        "پیشنهاد شغلی از کارفرمای سوئدی",
                        "حقوق حداقل مطابق قرارداد جمعی",
                        "بیمه درمانی",
                        "گذرنامه معتبر"
                    },
                    Benefits = new()
                    {
                        "اقامت کار قابل تمدید",
                        "الحاق خانواده",
                        "مسیر به اقامت دائم پس از ۲ سال",
                        "امکان تابعیت پس از ۵ سال",
                        "تعادل کار و زندگی عالی"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی",
                    Type = "موقت",
                    Duration = "تحصیل + ۶ ماه",
                    MinEducation = EducationLevel.HighSchool,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new()
                    {
                        "پذیرش از دانشگاه سوئدی",
                        "پرداخت شهریه (برای غیر EU)",
                        "تمکن مالی",
                        "بیمه درمانی"
                    },
                    Benefits = new()
                    {
                        "تحصیل به انگلیسی",
                        "ویزای کار ۶ ماهه پس از فارغ‌التحصیلی",
                        "کیفیت بالای آموزش",
                        "محیط چندفرهنگی"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای خوداشتغالی",
                    Type = "اقامت موقت",
                    Duration = "۲ سال",
                    MinInvestmentUSD = 25000,
                    Requirements = new()
                    {
                        "طرح کسب‌وکاری معتبر",
                        "حداقل ۱۰٪ سهام شرکت",
                        "تمکن مالی برای ۲ سال",
                        "سابقه کار مرتبط"
                    },
                    Benefits = new()
                    {
                        "امکان راه‌اندازی کسب‌وکار",
                        "الحاق خانواده",
                        "مسیر به اقامت دائم",
                        "اکوسیستم نوآوری قوی"
                    },
                    ProcessingTimeMonths = 4,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                }
            },
            Restrictions = new()
            {
                "آب‌وهوای سرد و تاریک در زمستان",
                "مالیات بالا",
                "نیاز به یادگیری زبان سوئدی",
                "بحران مسکن در شهرهای بزرگ"
            }
        },
        new Country
        {
            Name = "New Zealand",
            NamePersian = "نیوزیلند",
            FlagEmoji = "🇳🇿",
            Continent = "اقیانوسیه",
            QualityOfLifeScore = 90,
            SafetyScore = 91,
            HealthcareScore = 82,
            EducationScore = 85,
            EconomicOpportunityScore = 72,
            PoliticalStabilityScore = 93,
            ClimateScore = 82,
            CostOfLivingIndex = 65,
            AverageRentUSD = 1400,
            AverageSalaryUSD = 3800,
            OfficialLanguages = new() { "انگلیسی", "مائوری" },
            EnglishWidelySpoken = true,
            CitizenshipYears = 5,
            AllowsDualCitizenship = true,
            IranianPopulation = 5000,
            HasIranianCommunity = false,
            HealthcareSystem = "همگانی",
            UniversalHealthcare = true,
            EducationSystemQuality = "عالی",
            FreeEducation = true,
            Climate = "معتدل اقیانوسی",
            DistanceFromIranKm = 14000,
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای مهارت (Skilled Migrant Category)",
                    Type = "اقامت دائم",
                    Duration = "دائمی",
                    MinEducation = EducationLevel.BachelorDegree,
                    MinLanguageLevel = LanguageProficiency.Advanced,
                    MinExperienceYears = 2,
                    Requirements = new()
                    {
                        "سن زیر ۵۵ سال",
                        "شغل در لیست Long Term Skill Shortage",
                        "نمره IELTS حداقل ۶.۵",
                        "حداقل امتیاز مورد نیاز",
                        "سلامت خوب و عدم سوءپیشینه"
                    },
                    Benefits = new()
                    {
                        "اقامت دائم",
                        "حق کار و تحصیل",
                        "دسترسی به خدمات اجتماعی",
                        "امکان تابعیت پس از ۵ سال",
                        "کیفیت زندگی بسیار بالا"
                    },
                    ProcessingTimeMonths = 12,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی",
                    Type = "موقت",
                    Duration = "تحصیل + ۳ سال",
                    MinEducation = EducationLevel.HighSchool,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new()
                    {
                        "پذیرش از مؤسسه معتبر",
                        "تمکن مالی",
                        "نمره IELTS 5.5+",
                        "بیمه درمانی"
                    },
                    Benefits = new()
                    {
                        "ویزای کار ۱-۳ ساله پس از فارغ‌التحصیلی",
                        "اجازه کار پاره‌وقت حین تحصیل",
                        "محیط طبیعی زیبا",
                        "امنیت بالا"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                }
            },
            Restrictions = new()
            {
                "فاصله بسیار زیاد از ایران",
                "بازار کار کوچک",
                "هزینه زندگی بالا",
                "جمعیت ایرانی بسیار کم"
            }
        },
        new Country
        {
            Name = "Netherlands",
            NamePersian = "هلند",
            FlagEmoji = "🇳🇱",
            Continent = "اروپا",
            QualityOfLifeScore = 89,
            SafetyScore = 84,
            HealthcareScore = 88,
            EducationScore = 87,
            EconomicOpportunityScore = 80,
            PoliticalStabilityScore = 88,
            ClimateScore = 55,
            CostOfLivingIndex = 68,
            AverageRentUSD = 1400,
            AverageSalaryUSD = 4000,
            OfficialLanguages = new() { "هلندی" },
            EnglishWidelySpoken = true,
            CitizenshipYears = 5,
            AllowsDualCitizenship = true,
            IranianPopulation = 40000,
            HasIranianCommunity = true,
            HealthcareSystem = "بیمه خصوصی اجباری",
            UniversalHealthcare = false,
            EducationSystemQuality = "عالی",
            FreeEducation = true,
            Climate = "معتدل اقیانوسی",
            DistanceFromIranKm = 4000,
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار تخصصی (Highly Skilled Migrant)",
                    Type = "اقامت موقت - منجر به دائم",
                    Duration = "تا ۵ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    MinIncomeUSD = 4000,
                    Requirements = new()
                    {
                        "پیشنهاد شغلی از کارفرمای مورد تأیید IND",
                        "حقوق حداقلی مشخص",
                        "مدرک زبان انگلیسی یا هلندی",
                        "مدرک دانشگاهی"
                    },
                    Benefits = new()
                    {
                        "اقامت کار سریع",
                        "تخفیف مالیاتی ۳۰٪ (30% ruling)",
                        "الحاق خانواده",
                        "مسیر به اقامت دائم",
                        "امکان تابعیت پس از ۵ سال"
                    },
                    ProcessingTimeMonths = 2,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای استارتاپ",
                    Type = "اقامت موقت",
                    Duration = "۱ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    Requirements = new()
                    {
                        "ایده نوآورانه",
                        "پشتیبانی یک تسهیل‌گر معتبر",
                        "طرح کسب‌وکاری",
                        "تمکن مالی"
                    },
                    Benefits = new()
                    {
                        "اقامت ۱ ساله برای راه‌اندازی",
                        "دسترسی به اکوسیستم نوآوری",
                        "امکان تبدیل به ویزای خوداشتغال",
                        "محیط کسب‌وکار عالی"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = false,
                    LeadsToCitizenship = false
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی",
                    Type = "موقت",
                    Duration = "تحصیل + ۱ سال",
                    MinEducation = EducationLevel.HighSchool,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    Requirements = new()
                    {
                        "پذیرش از دانشگاه هلندی",
                        "تمکن مالی",
                        "نمره IELTS 6.0+",
                        "بیمه درمانی"
                    },
                    Benefits = new()
                    {
                        "تحصیل به انگلیسی",
                        "ویزای جستجوی کار ۱ ساله",
                        "اجازه کار پاره‌وقت",
                        "کیفیت آموزش بالا"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                }
            },
            Restrictions = new()
            {
                "بحران مسکن شدید",
                "مالیات بالا",
                "نیاز به یادگیری زبان هلندی",
                "هزینه زندگی بالا"
            }
        },
        new Country
        {
            Name = "Portugal",
            NamePersian = "پرتغال",
            FlagEmoji = "🇵🇹",
            Continent = "اروپا",
            QualityOfLifeScore = 78,
            SafetyScore = 80,
            HealthcareScore = 75,
            EducationScore = 70,
            EconomicOpportunityScore = 60,
            PoliticalStabilityScore = 82,
            ClimateScore = 90,
            CostOfLivingIndex = 45,
            AverageRentUSD = 800,
            AverageSalaryUSD = 1800,
            OfficialLanguages = new() { "پرتغالی" },
            EnglishWidelySpoken = false,
            CitizenshipYears = 5,
            AllowsDualCitizenship = true,
            IranianPopulation = 5000,
            HasIranianCommunity = false,
            HealthcareSystem = "همگانی (SNS)",
            UniversalHealthcare = true,
            EducationSystemQuality = "خوب",
            FreeEducation = true,
            Climate = "مدیترانه‌ای",
            DistanceFromIranKm = 5000,
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای D7 (درآمد غیرفعال)",
                    Type = "اقامت موقت - منجر به دائم",
                    Duration = "۲ سال (قابل تمدید)",
                    MinIncomeUSD = 900,
                    Requirements = new()
                    {
                        "درآمد غیرفعال حداقل ۸۲۰ یورو/ماه",
                        "تمکن مالی",
                        "محل اقامت در پرتغال",
                        "بیمه درمانی",
                        "عدم سوءپیشینه"
                    },
                    Benefits = new()
                    {
                        "مسیر به اقامت دائم و تابعیت",
                        "هزینه زندگی پایین",
                        "آب‌وهوای عالی",
                        "مالیات ویژه (NHR) برای ۱۰ سال",
                        "دسترسی به شنگن"
                    },
                    ProcessingTimeMonths = 4,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای طلایی (Golden Visa)",
                    Type = "اقامت موقت - منجر به تابعیت",
                    Duration = "۲ سال (قابل تمدید)",
                    MinInvestmentUSD = 350000,
                    Requirements = new()
                    {
                        "سرمایه‌گذاری ۳۵۰,۰۰۰ یورو در تحقیقات",
                        "یا ۵۰۰,۰۰۰ یورو در صندوق سرمایه‌گذاری",
                        "ایجاد ۱۰ شغل",
                        "حداقل ۷ روز حضور در سال"
                    },
                    Benefits = new()
                    {
                        "اقامت با حداقل حضور",
                        "دسترسی به شنگن",
                        "تابعیت پس از ۵ سال",
                        "مالیات ویژه",
                        "بدون نیاز به اقامت دائم"
                    },
                    ProcessingTimeMonths = 6,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای D2 (خوداشتغال/فریلنسر)",
                    Type = "اقامت موقت",
                    Duration = "۱ سال (قابل تمدید)",
                    MinIncomeUSD = 1500,
                    Requirements = new()
                    {
                        "قرارداد فریلنسری یا طرح کسب‌وکار",
                        "تمکن مالی",
                        "محل اقامت",
                        "بیمه درمانی"
                    },
                    Benefits = new()
                    {
                        "امکان کار آزاد",
                        "مسیر به اقامت دائم",
                        "هزینه زندگی پایین",
                        "آب‌وهوای مدیترانه‌ای"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                }
            },
            Restrictions = new()
            {
                "حقوق پایین نسبت به اروپای غربی",
                "بازار کار محدود",
                "نیاز به یادگیری زبان پرتغالی",
                "بوروکراسی کند"
            }
        },
        new Country
        {
            Name = "United Kingdom",
            NamePersian = "انگلستان",
            FlagEmoji = "🇬🇧",
            Continent = "اروپا",
            QualityOfLifeScore = 85,
            SafetyScore = 78,
            HealthcareScore = 85,
            EducationScore = 90,
            EconomicOpportunityScore = 82,
            PoliticalStabilityScore = 80,
            ClimateScore = 50,
            CostOfLivingIndex = 75,
            AverageRentUSD = 1800,
            AverageSalaryUSD = 4200,
            OfficialLanguages = new() { "انگلیسی" },
            EnglishWidelySpoken = true,
            CitizenshipYears = 5,
            AllowsDualCitizenship = true,
            IranianPopulation = 100000,
            HasIranianCommunity = true,
            HealthcareSystem = "NHS (همگانی)",
            UniversalHealthcare = true,
            EducationSystemQuality = "عالی",
            FreeEducation = true,
            Climate = "اقیانوسی معتدل",
            DistanceFromIranKm = 4500,
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای کار تخصصی (Skilled Worker Visa)",
                    Type = "اقامت موقت - منجر به دائم",
                    Duration = "تا ۵ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    MinLanguageLevel = LanguageProficiency.Intermediate,
                    MinIncomeUSD = 3500,
                    MinExperienceYears = 1,
                    Requirements = new()
                    {
                        "پیشنهاد شغلی از کارفرمای دارای مجوز",
                        "حقوق حداقل ۲۶,۲۰۰ پوند/سال",
                        "نمره IELTS 4.0+",
                        "شغل در سطح RQF 3+",
                        "گواهی اسپانسرشیپ (CoS)"
                    },
                    Benefits = new()
                    {
                        "اقامت تا ۵ سال",
                        "الحاق خانواده",
                        "مسیر به اقامت دائم (ILR)",
                        "دسترسی به NHS",
                        "امکان تابعیت"
                    },
                    ProcessingTimeMonths = 2,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای نخبگان (Global Talent Visa)",
                    Type = "اقامت موقت - منجر به دائم",
                    Duration = "تا ۵ سال",
                    MinEducation = EducationLevel.MasterDegree,
                    Requirements = new()
                    {
                        "تأییدیه از نهاد معتبر (Tech Nation, Arts Council و...)",
                        "سابقه دستاوردهای برجسته",
                        "حداقل ۳ سال سابقه",
                        "توصیه‌نامه از متخصصان"
                    },
                    Benefits = new()
                    {
                        "بدون نیاز به اسپانسر",
                        "آزادی کار و تغییر شغل",
                        "مسیر سریع به اقامت دائم (۳ سال)",
                        "الحاق خانواده",
                        "اعتبار بین‌المللی"
                    },
                    ProcessingTimeMonths = 2,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی",
                    Type = "موقت",
                    Duration = "تحصیل + ۲ سال",
                    MinEducation = EducationLevel.HighSchool,
                    MinLanguageLevel = LanguageProficiency.Advanced,
                    Requirements = new()
                    {
                        "پذیرش از مؤسسه دارای مجوز",
                        "نمره IELTS مناسب",
                        "تمکن مالی",
                        "CAS (تأییدیه پذیرش)"
                    },
                    Benefits = new()
                    {
                        "ویزای کار ۲ ساله پس از فارغ‌التحصیلی (Graduate Route)",
                        "اجازه کار پاره‌وقت",
                        "دانشگاه‌های برتر جهان",
                        "مسیر به ویزای کار"
                    },
                    ProcessingTimeMonths = 2,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای نوآور (Innovator Founder Visa)",
                    Type = "اقامت موقت - منجر به دائم",
                    Duration = "۳ سال",
                    MinInvestmentUSD = 50000,
                    Requirements = new()
                    {
                        "ایده نوآورانه و قابل توسعه",
                        "تأییدیه نهاد معتبر",
                        "طرح کسب‌وکاری",
                        "نمره IELTS 5.5+"
                    },
                    Benefits = new()
                    {
                        "اقامت ۳ ساله",
                        "مسیر سریع به اقامت دائم (۱-۳ سال)",
                        "بدون حداقل سرمایه",
                        "الحاق خانواده"
                    },
                    ProcessingTimeMonths = 2,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                }
            },
            Restrictions = new()
            {
                "هزینه زندگی بالا به‌خصوص در لندن",
                "فرآیند ویزای پیچیده و پرهزینه",
                "آب‌وهوای ابری و بارانی",
                "بازار کار رقابتی"
            }
        },
        new Country
        {
            Name = "United States",
            NamePersian = "ایالات متحده آمریکا",
            FlagEmoji = "🇺🇸",
            Continent = "آمریکای شمالی",
            QualityOfLifeScore = 82,
            SafetyScore = 65,
            HealthcareScore = 70,
            EducationScore = 88,
            EconomicOpportunityScore = 90,
            PoliticalStabilityScore = 72,
            ClimateScore = 75,
            CostOfLivingIndex = 68,
            AverageRentUSD = 1600,
            AverageSalaryUSD = 5500,
            OfficialLanguages = new() { "انگلیسی" },
            EnglishWidelySpoken = true,
            CitizenshipYears = 5,
            AllowsDualCitizenship = true,
            IranianPopulation = 500000,
            HasIranianCommunity = true,
            HealthcareSystem = "بیمه خصوصی",
            UniversalHealthcare = false,
            EducationSystemQuality = "عالی",
            FreeEducation = false,
            Climate = "متنوع - از گرمسیری تا قطبی",
            DistanceFromIranKm = 10500,
            VisaOptions = new()
            {
                new VisaOption
                {
                    Name = "ویزای EB-1 (نخبگان)",
                    Type = "اقامت دائم (Green Card)",
                    Duration = "دائمی",
                    MinEducation = EducationLevel.PhD,
                    MinExperienceYears = 5,
                    Requirements = new()
                    {
                        "دستاوردهای فوق‌العاده در علوم، هنر، آموزش، کسب‌وکار یا ورزش",
                        "مستندات قوی (جوایز، انتشارات، استنادها)",
                        "حداقل ۳ معیار از ۱۰ معیار USCIS",
                        "پیشنهاد شغلی یا خوداسپانسرشیپ"
                    },
                    Benefits = new()
                    {
                        "گرین کارت بدون نیاز به کارفرما",
                        "مسیر مستقیم به تابعیت",
                        "الحاق خانواده",
                        "بدون محدودیت جغرافیایی"
                    },
                    ProcessingTimeMonths = 8,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای EB-2 NIW (منافع ملی)",
                    Type = "اقامت دائم (Green Card)",
                    Duration = "دائمی",
                    MinEducation = EducationLevel.MasterDegree,
                    MinExperienceYears = 3,
                    Requirements = new()
                    {
                        "مدرک فوق‌لیسانس یا بالاتر",
                        "اثبات منافع ملی کار",
                        "توانایی پیشبرد طرح پیشنهادی",
                        "در موقعیتی که منافع آمریکا ایجاب می‌کند"
                    },
                    Benefits = new()
                    {
                        "گرین کارت بدون نیاز به کارفرما",
                        "بدون نیاز به Labor Certification",
                        "الحاق خانواده",
                        "مسیر به تابعیت"
                    },
                    ProcessingTimeMonths = 12,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای H-1B (کار تخصصی)",
                    Type = "موقت - منجر به اقامت",
                    Duration = "تا ۶ سال",
                    MinEducation = EducationLevel.BachelorDegree,
                    MinLanguageLevel = LanguageProficiency.Advanced,
                    Requirements = new()
                    {
                        "پیشنهاد شغلی در رشته تخصصی",
                        "حداقل لیسانس مرتبط",
                        "کارفرمای اسپانسر",
                        "قرعه‌کشی سالانه (رقابت بالا)"
                    },
                    Benefits = new()
                    {
                        "اقامت کار تا ۶ سال",
                        "امکان تبدیل به گرین کارت",
                        "حقوق بالا",
                        "فرصت‌های شغلی متنوع"
                    },
                    ProcessingTimeMonths = 6,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای تحصیلی F-1",
                    Type = "موقت",
                    Duration = "تحصیل + ۳ سال (OPT)",
                    MinEducation = EducationLevel.HighSchool,
                    MinLanguageLevel = LanguageProficiency.Advanced,
                    Requirements = new()
                    {
                        "پذیرش از دانشگاه معتبر",
                        "تمکن مالی کامل",
                        "نمره TOEFL/IELTS بالا",
                        "اثبات قصد بازگشت"
                    },
                    Benefits = new()
                    {
                        "OPT ۳ ساله برای رشته‌های STEM",
                        "فرصت‌های شغلی عالی",
                        "دانشگاه‌های برتر جهان",
                        "شبکه‌سازی قوی"
                    },
                    ProcessingTimeMonths = 3,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                },
                new VisaOption
                {
                    Name = "ویزای EB-5 (سرمایه‌گذاری)",
                    Type = "اقامت دائم (Green Card)",
                    Duration = "دائمی",
                    MinInvestmentUSD = 800000,
                    Requirements = new()
                    {
                        "سرمایه‌گذاری ۸۰۰,۰۰۰ دلار (مناطق هدف) یا ۱,۰۵۰,۰۰۰ دلار",
                        "ایجاد حداقل ۱۰ شغل تمام‌وقت",
                        "اثبات منشأ قانونی سرمایه",
                        "طرح کسب‌وکاری"
                    },
                    Benefits = new()
                    {
                        "گرین کارت برای کل خانواده",
                        "بدون نیاز به کارفرما یا تحصیلات",
                        "آزادی زندگی و کار",
                        "مسیر به تابعیت"
                    },
                    ProcessingTimeMonths = 18,
                    LeadsToPR = true,
                    LeadsToCitizenship = true
                }
            },
            Restrictions = new()
            {
                "فرآیند ویزای بسیار پیچیده و طولانی",
                "هزینه بهداشت و درمان بالا",
                "مسائل امنیتی در برخی مناطق",
                "سیستم مهاجرتی رقابتی",
                "محدودیت‌های خاص برای ایرانیان"
            }
        }
    };
}
