using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFProj.Core.Entities;

[Table("users")]
public class User
{
    [Key]
    [Column("id")]
    public int UserId { get; set; }
    [Column("username")]
    public required string Username { get; set; }

    [Column("first_name")]
    public string? FirstName { get; set; }

    [Column("last_name")]
    public string? LastName { get; set; }
    [Column("password")]
    public required string Password { get; set; }
    [Column("email")]
    public required string Email { get; set; }

    [ForeignKey("role_id")]
    [Column("role_id")]
    [Required]
    public required Role Role { get; set; }

    public List<Project>? AssignedProjects { get; set; }
}