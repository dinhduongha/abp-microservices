using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("sms_template_preview")]
public partial class SmsTemplatePreview
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sms_template_id")]
    public Guid? SmsTemplateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("lang")]
    public string? Lang { get; set; }

    [Column("resource_ref")]
    public string? ResourceRef { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("SmsTemplatePreviewCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("SmsTemplateId")]
    [InverseProperty("SmsTemplatePreviews")]
    public virtual SmsTemplate? SmsTemplate { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SmsTemplatePreviewWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
