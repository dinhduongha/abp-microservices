using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_edi_document")]
[Index("EdiFormatId", "MoveId", Name = "account_edi_document_unique_edi_document_by_move_by_format", IsUnique = true)]
public partial class AccountEdiDocument
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("move_id")]
    public Guid? MoveId { get; set; }

    [Column("edi_format_id")]
    public long? EdiFormatId { get; set; }

    [Column("attachment_id")]
    public Guid? AttachmentId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("blocking_level")]
    public string? BlockingLevel { get; set; }

    [Column("error")]
    public string? Error { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AttachmentId")]
    [InverseProperty("AccountEdiDocuments")]
    public virtual IrAttachment? Attachment { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountEdiDocumentCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MoveId")]
    [InverseProperty("AccountEdiDocuments")]
    public virtual AccountMove? Move { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountEdiDocumentWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
