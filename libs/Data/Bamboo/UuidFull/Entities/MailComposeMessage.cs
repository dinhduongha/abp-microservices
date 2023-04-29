using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_compose_message")]
public partial class MailComposeMessage
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("template_id")]
    public Guid? TemplateId { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("author_id")]
    public Guid? AuthorId { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("subtype_id")]
    public long? SubtypeId { get; set; }

    [Column("mail_activity_type_id")]
    public long? MailActivityTypeId { get; set; }

    [Column("mail_server_id")]
    public Guid? MailServerId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("lang")]
    public string? Lang { get; set; }

    [Column("subject")]
    public string? Subject { get; set; }

    [Column("email_layout_xmlid")]
    public string? EmailLayoutXmlid { get; set; }

    [Column("email_from")]
    public string? EmailFrom { get; set; }

    [Column("composition_mode")]
    public string? CompositionMode { get; set; }

    [Column("model")]
    public string? Model { get; set; }

    [Column("record_name")]
    public string? RecordName { get; set; }

    [Column("message_type")]
    public string? MessageType { get; set; }

    [Column("reply_to")]
    public string? ReplyTo { get; set; }

    [Column("body")]
    public string? Body { get; set; }

    [Column("active_domain")]
    public string? ActiveDomain { get; set; }

    [Column("email_add_signature")]
    public bool? EmailAddSignature { get; set; }

    [Column("use_active_domain")]
    public bool? UseActiveDomain { get; set; }

    [Column("is_log")]
    public bool? IsLog { get; set; }

    [Column("notify")]
    public bool? Notify { get; set; }

    [Column("reply_to_force_new")]
    public bool? ReplyToForceNew { get; set; }

    [Column("auto_delete")]
    public bool? AutoDelete { get; set; }

    [Column("auto_delete_message")]
    public bool? AutoDeleteMessage { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("Composer")]
    public virtual ICollection<AccountInvoiceSend> AccountInvoiceSends { get; } = new List<AccountInvoiceSend>();

    [ForeignKey("AuthorId")]
    [InverseProperty("MailComposeMessages")]
    public virtual ResPartner? Author { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailComposeMessageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MailServerId")]
    [InverseProperty("MailComposeMessages")]
    public virtual IrMailServer? MailServer { get; set; }

    [ForeignKey("ParentId")]
    [InverseProperty("MailComposeMessages")]
    public virtual MailMessage? Parent { get; set; }

    [ForeignKey("TemplateId")]
    [InverseProperty("MailComposeMessages")]
    public virtual MailTemplate? Template { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MailComposeMessageWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("WizardId")]
    [InverseProperty("Wizards")]
    public virtual ICollection<IrAttachment> Attachments { get; } = new List<IrAttachment>();

    [ForeignKey("WizardId")]
    [InverseProperty("Wizards")]
    public virtual ICollection<ResPartner> Partners { get; } = new List<ResPartner>();
}
