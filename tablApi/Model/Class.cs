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

    public List<ClassSchedule>? ClassSchedulesList { get; set; }


}
