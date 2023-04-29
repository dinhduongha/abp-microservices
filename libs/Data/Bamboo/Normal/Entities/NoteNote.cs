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

[Table("note_note")]
public partial class NoteNote: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("date_done")]
    public DateOnly? DateDone { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("memo")]
    public string? Memo { get; set; }

    [Column("open")]
    public bool? Open { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("NoteNotes")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("NoteNoteCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    //[InverseProperty("NoteNotes")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("UserId")]
    //[InverseProperty("NoteNoteUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("NoteNoteWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("NoteNavigation")]
    [NotMapped]
    public virtual ICollection<MailActivity> MailActivities { get; } = new List<MailActivity>();

    [ForeignKey("NoteId")]
    [InverseProperty("Notes")]
    [NotMapped]
    public virtual ICollection<NoteStage> Stages { get; } = new List<NoteStage>();

    [ForeignKey("NoteId")]
    [InverseProperty("Notes")]
    [NotMapped]
    public virtual ICollection<NoteTag> Tags { get; } = new List<NoteTag>();
}
