using Microsoft.AspNetCore.Components;
namespace SmSideBarExample.Components;

public record SideBarItem(
    string ViewName,
    string Icon);

public partial class SideBarComponent : ComponentBase
{
    private int? _currentActiveIndex;
    int? CurrentActiveIndex => _currentActiveIndex;

    [Parameter]
    public IReadOnlyList<SideBarItem> Items { get; set; } = [];

    private Task ActiveItemAsync(SideBarItem item, int index)
    {
        _currentActiveIndex = index;
        return Task.CompletedTask;
    }
}