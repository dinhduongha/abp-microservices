using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("TypeId", "ProjectId")]
[Table("project_task_type_rel")]
[Index("ProjectId", "TypeId", Name = "project_task_type_rel_project_id_type_id_idx")]
public partial class ProjectTaskTypeRel
{
    [Key]
    [Column("type_id")]
    public long TypeId { get; set; }

    [Key]
    [Column("project_id")]
    public Guid ProjectId { get; set; }

    [ForeignKey("ProjectId")]
    [InverseProperty("ProjectTaskTypeRels")]
    public virtual ProjectProject Project { get; set; } = null!;
}
