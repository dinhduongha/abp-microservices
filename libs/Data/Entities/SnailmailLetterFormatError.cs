﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("snailmail_letter_format_error")]
public partial class SnailmailLetterFormatError
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_id")]
    public Guid? MessageId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("snailmail_cover")]
    public bool? SnailmailCover { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("SnailmailLetterFormatErrorCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MessageId")]
    [InverseProperty("SnailmailLetterFormatErrors")]
    public virtual MailMessage? Message { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("SnailmailLetterFormatErrorWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}