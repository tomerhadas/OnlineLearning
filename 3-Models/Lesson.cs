using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform;

public class Lesson
{

    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid CourseId { get; set; }

    [ForeignKey(nameof(CourseId))]
    public Course Course { get; set; } = null!;

    [Required]
    [StringLength(50)]
    public string Title { get; set; } = null!;

    // We store the full video URL from YouTube/Vimeo
    [Required]
    [StringLength(200)]
    public string VideoUrl { get; set; } = null!;

}
