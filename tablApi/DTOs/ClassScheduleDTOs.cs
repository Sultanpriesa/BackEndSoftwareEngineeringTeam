using System.ComponentModel.DataAnnotations;

namespace tablApi.DTOs;

public class ClassScheduleDTO
{
    public int Schedule_ID { get; set; }
    public int Course_ID { get; set; }
    public required string Course_name { get; set; }
    public required string Day_of_week { get; set; }
    public required TimeSpan Start_time { get; set; }
    public required TimeSpan End_time { get; set; }
    public required string Room { get; set; }
}


public class DeleteClassScheduleDTO
{
    [Required]
    public required int Schedule_ID { get; set; }
} 
