using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("note_note")]
public partial class NoteNote
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("date_done")]
    public DateOnly? DateDone { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("memo")]
    public string? Memo { get; set; }

    [Column("open")]
    public bool? Open { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("NoteNotes")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("NoteNoteCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("NoteNavigation")]
    public virtual ICollection<MailActivity> MailActivities { get; } = new List<MailActivity>();

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("NoteNotes")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [InverseProperty("Note")]
    public virtual ICollection<NoteStageRel> NoteStageRels { get; } = new List<NoteStageRel>();

    [ForeignKey("UserId")]
    [InverseProperty("NoteNoteUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("NoteNoteWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("NoteId")]
    [InverseProperty("Notes")]
    public virtual ICollection<NoteTag> Tags { get; } = new List<NoteTag>();
}
