using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("project_update")]
public partial class ProjectUpdate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("progress")]
    public long? Progress { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("project_id")]
    public Guid? ProjectId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("email_cc")]
    public string? EmailCc { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("status")]
    public string? Status { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProjectUpdateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("ProjectUpdates")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("ProjectId")]
    [InverseProperty("ProjectUpdates")]
    public virtual ProjectProject? Project { get; set; }

    [InverseProperty("LastUpdate")]
    public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    [ForeignKey("UserId")]
    [InverseProperty("ProjectUpdateUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProjectUpdateWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
