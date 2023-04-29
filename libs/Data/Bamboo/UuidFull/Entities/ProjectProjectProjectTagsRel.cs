using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ProjectProjectId", "ProjectTagsId")]
[Table("project_project_project_tags_rel")]
[Index("ProjectTagsId", "ProjectProjectId", Name = "project_project_project_tags__project_tags_id_project_proje_idx")]
public partial class ProjectProjectProjectTagsRel
{
    [Key]
    [Column("project_project_id")]
    public Guid ProjectProjectId { get; set; }

    [Key]
    [Column("project_tags_id")]
    public long ProjectTagsId { get; set; }

    [ForeignKey("ProjectProjectId")]
    [InverseProperty("ProjectProjectProjectTagsRels")]
    public virtual ProjectProject ProjectProject { get; set; } = null!;
}
