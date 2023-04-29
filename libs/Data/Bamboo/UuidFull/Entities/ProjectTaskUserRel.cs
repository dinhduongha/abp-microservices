using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("project_task_user_rel")]
[Index("TaskId", "UserId", Name = "project_task_user_rel_project_personal_stage_unique", IsUnique = true)]
[Index("TaskId", Name = "project_task_user_rel_task_id_index")]
[Index("UserId", Name = "project_task_user_rel_user_id_index")]
public partial class ProjectTaskUserRel
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("task_id")]
    public Guid? TaskId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("stage_id")]
    public long? StageId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProjectTaskUserRelCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("TaskId")]
    [InverseProperty("ProjectTaskUserRels")]
    public virtual ProjectTask? Task { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("ProjectTaskUserRelUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProjectTaskUserRelWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
