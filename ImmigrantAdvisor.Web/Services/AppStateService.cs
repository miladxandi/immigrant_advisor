using ImmigrantAdvisor.Web.Models;

namespace ImmigrantAdvisor.Web.Services;

public class AppStateService
{
    public UserFactors UserFactors { get; set; } = new();
    public List<MigrationPlan> Results { get; set; } = new();
}
