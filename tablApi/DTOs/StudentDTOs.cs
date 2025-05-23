using System.ComponentModel.DataAnnotations;

namespace tablApi.DTOs;

public class StudentDTO
{
    public int Student_ID { get; set; }
    public required string Student_firstName { get; set; }
    public required string Student_LastName { get; set; }
    public int Student_yearLevel { get; set; }
    public int User_ID { get; set; }
    public required string User_email { get; set; }
    public List<CourseDTO>? EnrolledCourse { get; set; }
}

