using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseManager.Models;

public class Teacher
{
    public int Id { get; set; }
    [Required]
    [StringLength(20)]
    public string FirstName { get; set; } = String.Empty;

    [StringLength(30)]
    public string LastName { get; set; } = String.Empty;

    [StringLength(30)]
    public string EducationalTitle { get; set; } = String.Empty;

    [StringLength(50)]
    public string EmailAddress { get; set; } = String.Empty;

    public ICollection<Course> Course { get; set; }

    [NotMapped]
    public string FullName { get {  return FirstName[0] + ". " + LastName; } }
}
