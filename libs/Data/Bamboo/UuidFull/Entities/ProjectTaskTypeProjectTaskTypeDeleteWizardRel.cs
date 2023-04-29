using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ProjectTaskTypeDeleteWizardId", "ProjectTaskTypeId")]
[Table("project_task_type_project_task_type_delete_wizard_rel")]
[Index("ProjectTaskTypeId", "ProjectTaskTypeDeleteWizardId", Name = "project_task_type_project_tas_project_task_type_id_project__idx")]
public partial class ProjectTaskTypeProjectTaskTypeDeleteWizardRel
{
    [Key]
    [Column("project_task_type_delete_wizard_id")]
    public Guid ProjectTaskTypeDeleteWizardId { get; set; }

    [Key]
    [Column("project_task_type_id")]
    public long ProjectTaskTypeId { get; set; }

    [ForeignKey("ProjectTaskTypeDeleteWizardId")]
    [InverseProperty("ProjectTaskTypeProjectTaskTypeDeleteWizardRels")]
    public virtual ProjectTaskTypeDeleteWizard ProjectTaskTypeDeleteWizard { get; set; } = null!;
}
