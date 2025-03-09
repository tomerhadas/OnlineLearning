using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineLearningPlatform;

public class User
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Required]
    [StringLength(255)]
    public string Email { get; set; } = null!;

    // We'll store the password as a hashed string
    // so no need for extremely large length, but ensure we have enough space for a hash.
    [Required]
    [StringLength(30)]
    public string Password { get; set; } = null!;

    // Navigation properties
    public ICollection<Enrollment> Enrollments { get; set; } = null!;
    public ICollection<Progress> ProgressRecords { get; set; } = null!;
}