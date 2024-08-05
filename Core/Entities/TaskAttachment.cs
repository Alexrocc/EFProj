using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFProj.Core.Entities;

[Table("task_attachments")]
public class TaskAttachment
{
    [Key]
    [Column("id")]
    public int TaskAttachmentId { get; set; }

    [Column("file_name")]
    public required string FileName { get; set; }

    [Column("file_data")]
    public required string FileData { get; set; }

    [Column("tasks_id")]
    public int TaskId { get; set; }
}