using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseManager.Models;

public class Teacher
{
    public int Id { get; set; }
    [Required]
    [StringLength(20)]
    public string FirstName { get; set; }

    [StringLength(30)]
    public string LastName { get; set; }

    
    public int? CourseId { get; set; }
    public Course Course { get; set; }
}
