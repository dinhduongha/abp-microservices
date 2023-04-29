using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_template_preview")]
public partial class MailTemplatePreview
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mail_template_id")]
    public Guid? MailTemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("resource_ref")]
    public string? ResourceRef { get; set; }

    [Column("lang")]
    public string? Lang { get; set; }

    [Column("error_msg")]
    public string? ErrorMsg { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailTemplatePreviewCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MailTemplateId")]
    [InverseProperty("MailTemplatePreviews")]
    public virtual MailTemplate? MailTemplate { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MailTemplatePreviewWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
