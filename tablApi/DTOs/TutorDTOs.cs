using System.ComponentModel.DataAnnotations;

namespace tablApi.DTOs;

public class TutorDTO
{
    public int Tutor_ID { get; set; }
    public required string Tutor_firstName { get; set; }
    public required string Tutor_LastName { get; set; }
    public int User_ID { get; set; }
    public required string User_email { get; set; }
    public List<CourseDTO>? TeachingClasses { get; set; }
}
