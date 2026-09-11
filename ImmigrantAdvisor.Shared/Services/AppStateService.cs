using ImmigrantAdvisor.Shared.Models;

namespace ImmigrantAdvisor.Shared.Services;

public class AppStateService
{
    public UserFactors UserFactors { get; set; } = new();
    public List<MigrationPlan> Results { get; set; } = new();
}
