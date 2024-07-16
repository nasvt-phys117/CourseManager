using System.ComponentModel.DataAnnotations;

namespace CourseManager.Models;

public class Course
{
    public int Id { get; set; }

    [Required]
    [StringLength(30)]
    public string Name { get; set; }

    [StringLength(300, ErrorMessage = "Description can't be more than 300 characters.")]
    [Display(Name = "Course Description")]
    public string Description { get; set; }

    [Required]
    [StringLength(30)]
    public string Subject { get; set; }

    public Teacher Instructor { get; set; }

    public ICollection<Student> Students { get; }
}
