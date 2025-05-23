using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tablApi.Model;

public class Class
{
    [Key]
    public int Class_ID { get; set; }

    public required string Class_Name { get; set; }
    public string? Class_Desc { get; set; }
    public int Class_yearLevel { get; set; }

    // Class period
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public int Tutor_ID { get; set; }
    [ForeignKey("Tutor_ID")]
    public Tutor? Tutor { get; set; }

    public string? Room { get; set; }


    // Navigation properties
    public List<Student>? EnrolledStudents { get; set; }
    public List<ClassSchedule>? Schedules { get; set; }
}
