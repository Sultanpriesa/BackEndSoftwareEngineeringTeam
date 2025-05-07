using System;
using System.ComponentModel.DataAnnotations;

namespace tablApi.Model;

public class Course
{
    [Key]
    public int Course_ID { get; set; }
    public required string Course_Name { get; set; }
    public required string Course_Desc { get; set; }

    public List<Class>? Classes { get; set; }
}
