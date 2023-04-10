using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("mail_template_preview")]
public partial class MailTemplatePreview
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mail_template_id")]
    public Guid? MailTemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("resource_ref")]
    public string? ResourceRef { get; set; }

    [Column("lang")]
    public string? Lang { get; set; }

    [Column("error_msg")]
    public string? ErrorMsg { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("MailTemplatePreviewCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MailTemplateId")]
    //[InverseProperty("MailTemplatePreviews")]
    public virtual MailTemplate? MailTemplate { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("MailTemplatePreviewWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
