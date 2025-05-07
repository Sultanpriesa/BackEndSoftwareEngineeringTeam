using System;
using System.ComponentModel.DataAnnotations;



namespace tablApi.Model;

public class User
{
    [Key]
    public int User_ID { get; set; }

    public required string User_password { get; set; }
    public required string User_email { get; set; }
    public required string User_type { get; set; }

    public Tutor? Tutor { get; set; }
    public Student? Student { get; set; }


}
