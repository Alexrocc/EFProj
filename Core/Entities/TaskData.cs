using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFProj.Core.Entities;

[Table("tasks")]
public class TaskData
{
    [Key]
    [Column("id")]
    public int TaskId { get; set; }
    [Column("title")]
    public required string TaskTitle { get; set; }
    [Column("description")]
    public string? Description { get; set; }
    [Column("status")]
    public string? Status { get; set; }
    [Column("priority")]
    public string? Priority { get; set; }

    [Column("due_date")]
    public DateTime DueDate { get; set; }

    [Column("projects_id")]
    public int ProjectId { get; set; }

    [Column("users_id")]
    public int UserId { get; set; }

}