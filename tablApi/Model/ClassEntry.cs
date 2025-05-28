using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace tablApi.Model;

public class ClassEntry
{
    [Key]
    public int ClassEntry_ID { get; set; }

    public required int Class_ID { get; set; }
    [ForeignKey("Class_ID")]
    public Class? Class { get; set; }

    public required int ClassSchedule_ID { get; set; }
    [ForeignKey("ClassSchedule_ID")]
    public ClassSchedule? ClassSchedule { get; set; }

    public required DateTime Date { get; set; }
    public bool IsDeleted { get; set; } = false;

    public List<Student>? Students { get; set; }
}
