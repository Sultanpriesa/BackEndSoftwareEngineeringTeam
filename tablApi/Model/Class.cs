using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tablApi.Model;

public class Class
{
    [Key]
    public int Class_ID { get; set; }

    public required string Class_name { get; set; }
    public string? Class_desc { get; set; }
    public int Class_yearLevel { get; set; }

    public int Course_ID { get; set; }
    [ForeignKey("Course_ID")]
    public Course? Course { get; set; }

    public int Tutor_ID { get; set; }
    [ForeignKey("Tutor_ID")]
    public Tutor? Tutor { get; set; }

    // Schedule information
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public string? Room { get; set; }

    // Class period
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    // Navigation properties
    public List<ClassSchedule>? Schedules { get; set; }
    public List<Student>? EnrolledStudents { get; set; }
}
