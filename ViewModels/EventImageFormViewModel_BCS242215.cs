using System.ComponentModel.DataAnnotations;

namespace EventManagement_BCS242215.ViewModels;

public class EventImageFormViewModel_BCS242215
{
    public int EventId { get; set; }

    public string EventName { get; set; } = string.Empty;

    [Required(ErrorMessage = "ImageUrl không được để trống.")]
    [StringLength(1000)]
    [Display(Name = "Image URL")]
    public string ImageUrl { get; set; } = string.Empty;

    public bool IsThumbnail { get; set; }
}
