using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tablApi.Model;

public class Student
{
    [Key]
    public int Student_ID { get; set; }
    public required string Student_firstName { get; set; }
    public required string Student_LastName { get; set; }

    public int? student_yearLevel { get; set; }

    public int User_ID { get; set; }
    [ForeignKey("User_ID")]
    public User? User{ get; set; }

    public List<ClassSchedule>? ClassSchedulesList{ get; set; }

}
