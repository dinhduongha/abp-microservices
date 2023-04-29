﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_blacklist_remove")]
public partial class MailBlacklistRemove
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("reason")]
    public string? Reason { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailBlacklistRemoveCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MailBlacklistRemoveWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
