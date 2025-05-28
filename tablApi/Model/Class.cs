using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace tablApi.Model;

public class Class
{
    [Key]
    public int Class_ID { get; set; }

    public required string Class_Name { get; set; }
    public required string Class_Desc { get; set; }

    // Class period
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }

    public required string Room { get; set; }

    public required int Tutor_ID { get; set; }
    [ForeignKey("Tutor_ID")]
    public Tutor? Tutor { get; set; }

    // Navigation properties
    public List<Student>? EnrolledStudents { get; set; }
    public List<ClassSchedule>? Schedules { get; set; }
}
