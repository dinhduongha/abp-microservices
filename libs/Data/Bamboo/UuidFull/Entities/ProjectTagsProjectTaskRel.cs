using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ProjectTaskId", "ProjectTagsId")]
[Table("project_tags_project_task_rel")]
[Index("ProjectTagsId", "ProjectTaskId", Name = "project_tags_project_task_rel_project_tags_id_project_task__idx")]
public partial class ProjectTagsProjectTaskRel
{
    [Key]
    [Column("project_task_id")]
    public Guid ProjectTaskId { get; set; }

    [Key]
    [Column("project_tags_id")]
    public long ProjectTagsId { get; set; }

    [ForeignKey("ProjectTaskId")]
    [InverseProperty("ProjectTagsProjectTaskRels")]
    public virtual ProjectTask ProjectTask { get; set; } = null!;
}
