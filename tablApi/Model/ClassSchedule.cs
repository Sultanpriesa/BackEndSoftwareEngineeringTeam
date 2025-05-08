using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tablApi.Model;

public class ClassSchedule
{
    [Key]
    public int Schedule_ID { get; set; }

    public int Class_ID { get; set; }
    [ForeignKey("Class_ID")]
    public Class? Class{ get; set; }


    public int Student_ID { get; set; }
    [ForeignKey("Student_ID")]
    public Student? Student { get; set; }

    public DateTime Date { get; set; }
    public TimeSpan Time { get; set; }

    public List<Student>? Students{ get; set; }
}
