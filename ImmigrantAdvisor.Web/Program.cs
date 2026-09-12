using ImmigrantAdvisor.Shared.Models;
using ImmigrantAdvisor.Shared.Services;
using ImmigrantAdvisor.Web.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://+:{port}");

builder.Services.AddMudServices();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<ImmigrationAdvisorService>();
builder.Services.AddScoped<AppStateService>();

builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.All;
    options.KnownIPNetworks.Clear();
    options.KnownProxies.Clear();
});

var app = builder.Build();
app.UseForwardedHeaders();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseAntiforgery();
app.UseStaticFiles();

// Calculate endpoint - receives form POST and redirects to results
app.MapPost("/calculate", async (HttpContext ctx) =>
{
    var form = await ctx.Request.ReadFormAsync();
    var f = new UserFactors();

    if (int.TryParse(form["Age"], out var age)) f.Age = age;
    if (Enum.TryParse<Gender>(form["Gender"], out var g)) f.Gender = g;
    if (Enum.TryParse<MaritalStatus>(form["MaritalStatus"], out var ms)) f.MaritalStatus = ms;
    if (int.TryParse(form["NumberOfChildren"], out var nc)) f.NumberOfChildren = nc;
    f.SpouseWorking = form["SpouseWorking"] == "true";
    if (Enum.TryParse<EducationLevel>(form["Education"], out var ed)) f.Education = ed;
    f.FieldOfStudy = form["FieldOfStudy"].ToString() ?? "";
    if (Enum.TryParse<LanguageProficiency>(form["EnglishLevel"], out var el)) f.EnglishLevel = el;
    if (Enum.TryParse<LanguageProficiency>(form["FrenchLevel"], out var fl)) f.FrenchLevel = fl;
    if (Enum.TryParse<LanguageProficiency>(form["GermanLevel"], out var gl)) f.GermanLevel = gl;
    f.Occupation = form["Occupation"].ToString() ?? "";
    if (int.TryParse(form["YearsOfExperience"], out var ye)) f.YearsOfExperience = ye;
    if (Enum.TryParse<EmploymentType>(form["CurrentEmployment"], out var et)) f.CurrentEmployment = et;
    if (decimal.TryParse(form["AnnualIncomeUSD"], out var ai)) f.AnnualIncomeUSD = ai;
    if (decimal.TryParse(form["NetWorthUSD"], out var nw)) f.NetWorthUSD = nw;
    if (decimal.TryParse(form["AnnualSavingsUSD"], out var asv)) f.AnnualSavingsUSD = asv;
    f.HasInvestmentProperty = form["HasInvestmentProperty"].Contains("true");
    f.HasBusinessOwnership = form["HasBusinessOwnership"].Contains("true");
    if (Enum.TryParse<PhysicalHealthStatus>(form["PhysicalHealth"], out var ph)) f.PhysicalHealth = ph;
    if (Enum.TryParse<MentalHealthStatus>(form["MentalHealth"], out var mh)) f.MentalHealth = mh;
    if (Enum.TryParse<StressToleranceLevel>(form["StressTolerance"], out var st)) f.StressTolerance = st;
    if (Enum.TryParse<AdaptabilityLevel>(form["Adaptability"], out var ad)) f.Adaptability = ad;
    f.HasChronicDisease = form["HasChronicDisease"].Contains("true");
    f.NeedsSpecializedHealthcare = form["NeedsSpecializedHealthcare"].Contains("true");
    if (Enum.TryParse<CulturalPreference>(form["CulturalPreference"], out var cp)) f.CulturalPreference = cp;
    if (Enum.TryParse<ReligionPreference>(form["ReligionPreference"], out var rp)) f.ReligionPreference = rp;
    if (Enum.TryParse<ImportanceOfPoliticalStability>(form["ImportanceOfPoliticalStability"], out var ips)) f.ImportanceOfPoliticalStability = ips;
    if (Enum.TryParse<CommunityIntegrationPreference>(form["CommunityPreference"], out var cip)) f.CommunityPreference = cip;
    f.HasRelativesAbroad = form["HasRelativesAbroad"].Contains("true");
    f.RelativesCountries = form["RelativesCountries"].ToString() ?? "";
    if (Enum.TryParse<MigrationTimeline>(form["PreferredTimeline"], out var pt)) f.PreferredTimeline = pt;
    if (Enum.TryParse<ClimatePreference>(form["ClimatePreference"], out var clp)) f.ClimatePreference = clp;
    if (Enum.TryParse<UrbanRuralPreference>(form["UrbanRuralPreference"], out var urp)) f.UrbanRuralPreference = urp;
    if (Enum.TryParse<DistanceFromIranPreference>(form["DistancePreference"], out var dp)) f.DistancePreference = dp;
    f.SeekingCitizenship = form["SeekingCitizenship"].Contains("true");
    f.ChildrenEducationImportant = form["ChildrenEducationImportant"].Contains("true");
    if (Enum.TryParse<AgeGroup>(form["EldestChildAge"], out var ag)) f.EldestChildAge = ag;

    // Parse goals
    foreach (var gv in form["Goals"])
    {
        if (Enum.TryParse<MigrationGoal>(gv, out var goal)) f.Goals.Add(goal);
    }

    var advisor = new ImmigrationAdvisorService();
    var results = advisor.GetRecommendations(f);

    ResultsDataHolder.LatestFactors = f;
    ResultsDataHolder.LatestResults = results;

    ctx.Response.Redirect("/results");
});

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

// Simple holder for form POST results
public static class ResultsDataHolder
{
    public static UserFactors? LatestFactors { get; set; }
    public static List<MigrationPlan>? LatestResults { get; set; }
}
