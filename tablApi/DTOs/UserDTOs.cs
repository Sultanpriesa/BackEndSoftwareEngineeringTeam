using System.ComponentModel.DataAnnotations;

namespace tablApi.DTOs;

public class UserDTO
{
    public int User_ID { get; set; }
    public required string User_email { get; set; }
    public required string User_type { get; set; }
}

public class CreateUserDTO
{
    [Required]
    [EmailAddress]
    public required string User_email { get; set; }

    [Required]
    public required string User_password { get; set; }

    [Required]
    public required string User_type { get; set; }
}

public class LoginDTO
{
    [Required]
    [EmailAddress]
    public required string User_email { get; set; }

    [Required]
    public required string User_password { get; set; }
} 