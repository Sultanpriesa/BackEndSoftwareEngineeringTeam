using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace tablApi.Model;

public class ClassSchedule
{
    [Key]
    public int Schedule_ID { get; set; }
    public required DayOfWeek DayOfWeek { get; set; }
    public required TimeSpan StartTime { get; set; }
    public required TimeSpan EndTime { get; set; }

    public int Class_ID { get; set; }
    [ForeignKey("Class_ID")]
    public Class? Class { get; set; }

    // Navigation properties
    public List<ClassEntry>? ClassEntries { get; set; }
}
