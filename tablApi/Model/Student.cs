using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace tablApi.Model;

public class Student
{
    [Key]
    public int Student_ID { get; set; }

    public required string Student_firstName { get; set; }
    public required string Student_LastName { get; set; }

    public int User_ID { get; set; }
    [ForeignKey("User_ID")]
    public User? User { get; set; }

    // Navigation properties
    public ICollection<Class> EnrolledClasses { get; set; } = new List<Class>();
    public ICollection<ClassEntry> ClassEntries { get; set; } = new List<ClassEntry>();
}
