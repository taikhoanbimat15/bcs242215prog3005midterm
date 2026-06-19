using EventManagement_BCS242215.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EventManagement_BCS242215.ViewModels;

public class EventListViewModel_BCS242215
{
    public IReadOnlyList<Event_BCS242215> Events { get; set; } = Array.Empty<Event_BCS242215>();

    public IEnumerable<SelectListItem> Categories { get; set; } = Array.Empty<SelectListItem>();

    public string? SearchTerm { get; set; }

    public int? CategoryId { get; set; }

    public DateTime? StartDateFrom { get; set; }

    public DateTime? StartDateTo { get; set; }

    public string SortOrder { get; set; } = "date";
}
