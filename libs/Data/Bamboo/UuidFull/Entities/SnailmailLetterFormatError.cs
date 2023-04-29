using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("snailmail_letter_format_error")]
public partial class SnailmailLetterFormatError
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_id")]
    public Guid? MessageId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("snailmail_cover")]
    public bool? SnailmailCover { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("SnailmailLetterFormatErrorCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MessageId")]
    [InverseProperty("SnailmailLetterFormatErrors")]
    public virtual MailMessage? Message { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SnailmailLetterFormatErrorWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
