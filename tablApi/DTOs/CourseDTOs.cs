using System.ComponentModel.DataAnnotations;

namespace tablApi.DTOs;

public class CourseDTO
{
    public int Course_ID { get; set; }
    public required string Course_name { get; set; }
    public required string Course_description { get; set; }
   
    public int Tutor_ID { get; set; }
    public required string Tutor_name { get; set; }
    public List<ClassScheduleDTO>? Schedules { get; set; }
}
