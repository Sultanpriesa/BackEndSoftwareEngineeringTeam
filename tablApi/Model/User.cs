using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace tablApi.Model;

public class User
{
    [Key]
    public int User_ID { get; set; }

    public required string User_password { get; set; }
    public required string User_email { get; set; }
    public required string User_type { get; set; }  // "Admin", "Tutor", "Student"

    // Navigation properties
    public Student? Student { get; set; }
    public Tutor? Tutor { get; set; }
}
