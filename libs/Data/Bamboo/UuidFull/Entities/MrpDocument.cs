using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_document")]
public partial class MrpDocument
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("ir_attachment_id")]
    public Guid? IrAttachmentId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("priority")]
    public string? Priority { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpDocumentCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("IrAttachmentId")]
    [InverseProperty("MrpDocuments")]
    public virtual IrAttachment? IrAttachment { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpDocumentWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
