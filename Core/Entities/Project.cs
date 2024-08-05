using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFProj.Core.Entities;

[Table("projects")]
public class Project
{
    [Key]
    [Column("id")]
    public int ProjectId { get; set; }
    [Column("name")]
    public required string ProjName { get; set; }
    [Column("description")]
    public string? ProjDescription { get; set; }
    [Column("start_date")]
    public DateTime StartDate { get; set; }
    [Column("end_date")]
    public DateTime EndDate { get; set; }
    [Column("project_categories_id")]
    public int ProjCatId { get; set; }
    [Column("users_manager_id")]
    public int ManagerId { get; set; }
}