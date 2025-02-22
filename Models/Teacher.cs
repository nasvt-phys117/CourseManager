﻿using System.ComponentModel.DataAnnotations;
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

    [StringLength(30)]
    public string? EducationalTitle { get; set; }

    [StringLength(50)]
    public string? EmailAddress { get; set; }

    public ICollection<Course>? Course { get; set; }

    [NotMapped]
    public string FullName { get {  return FirstName[0] + ". " + LastName; } }
}
