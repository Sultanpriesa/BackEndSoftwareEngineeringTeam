using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tablApi.Model;

public class Tutor
{
    [Key]
    public int Tutor_ID { get; set; }
    public required string Tutor_firstName { get; set; }
    public required string Tutor_LastName { get; set; }

    public int User_ID { get; set; }
    [ForeignKey("User_ID")]
    public User? User{ get; set; }

    public List<Class>? ClassList { get; set; }
}
