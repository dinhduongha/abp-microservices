using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailComposeMessage
{
    public Guid Id { get; set; }

    public Guid? TemplateId { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? AuthorId { get; set; }

    public Guid? ResId { get; set; }

    public long? SubtypeId { get; set; }

    public long? MailActivityTypeId { get; set; }

    public Guid? MailServerId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Lang { get; set; }

    public string? Subject { get; set; }

    public string? EmailLayoutXmlid { get; set; }

    public string? EmailFrom { get; set; }

    public string? CompositionMode { get; set; }

    public string? Model { get; set; }

    public string? RecordName { get; set; }

    public string? MessageType { get; set; }

    public string? ReplyTo { get; set; }

    public string? Body { get; set; }

    public string? ActiveDomain { get; set; }

    public bool? EmailAddSignature { get; set; }

    public bool? UseActiveDomain { get; set; }

    public bool? IsLog { get; set; }

    public bool? Notify { get; set; }

    public bool? ReplyToForceNew { get; set; }

    public bool? AutoDelete { get; set; }

    public bool? AutoDeleteMessage { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountInvoiceSend> AccountInvoiceSends { get; } = new List<AccountInvoiceSend>();

    public virtual ResPartner? Author { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailActivityType? MailActivityType { get; set; }

    public virtual IrMailServer? MailServer { get; set; }

    public virtual MailMessage? Parent { get; set; }

    public virtual MailMessageSubtype? Subtype { get; set; }

    public virtual MailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<IrAttachment> Attachments { get; } = new List<IrAttachment>();

    //public virtual ICollection<ResPartner> Partners { get; } = new List<ResPartner>();
}
