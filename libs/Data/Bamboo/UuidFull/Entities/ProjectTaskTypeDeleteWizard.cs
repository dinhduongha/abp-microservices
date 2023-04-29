using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("project_task_type_delete_wizard")]
public partial class ProjectTaskTypeDeleteWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProjectTaskTypeDeleteWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("ProjectTaskTypeDeleteWizard")]
    public virtual ICollection<ProjectTaskTypeProjectTaskTypeDeleteWizardRel> ProjectTaskTypeProjectTaskTypeDeleteWizardRels { get; } = new List<ProjectTaskTypeProjectTaskTypeDeleteWizardRel>();

    [ForeignKey("WriteUid")]
    [InverseProperty("ProjectTaskTypeDeleteWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProjectTaskTypeDeleteWizardId")]
    [InverseProperty("ProjectTaskTypeDeleteWizards")]
    public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();
}
