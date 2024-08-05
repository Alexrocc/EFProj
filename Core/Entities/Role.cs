
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFProj.Core.Entities;

[Table("roles")]
public class Role
{
    [Key]
    [Column("id")]
    public required int RoleId { get; set; }

    [Column("name")]
    public required string RoleName { get; set; }
}