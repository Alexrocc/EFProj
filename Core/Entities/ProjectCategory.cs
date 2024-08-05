using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFProj.Core.Entities;

[Table("project_categories")]
public class ProjectCategory
{
    [Key]
    [Column("id")]
    public int TaskAttachmentId { get; set; }
    [Column("name")]
    public string? CategoryName { get; set; }
}