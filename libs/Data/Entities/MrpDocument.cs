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

[Table("mrp_document")]
public partial class MrpDocument
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("ir_attachment_id")]
    public Guid? IrAttachmentId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("priority")]
    public string? Priority { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("MrpDocumentCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("IrAttachmentId")]
    //[InverseProperty("MrpDocuments")]
    public virtual IrAttachment? IrAttachment { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("MrpDocumentWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
