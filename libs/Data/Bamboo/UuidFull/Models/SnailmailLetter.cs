using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class SnailmailLetter
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ResId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? ReportTemplate { get; set; }

    public Guid? AttachmentId { get; set; }

    public Guid? MessageId { get; set; }

    public long? StateId { get; set; }

    public long? CountryId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Model { get; set; }

    public string? State { get; set; }

    public string? ErrorCode { get; set; }

    public string? InfoMsg { get; set; }

    public string? Street { get; set; }

    public string? Street2 { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public bool? Color { get; set; }

    public bool? Cover { get; set; }

    public bool? Duplex { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual IrAttachment? Attachment { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailNotification> MailNotifications { get; } = new List<MailNotification>();

    public virtual MailMessage? Message { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual IrActReportXml? ReportTemplateNavigation { get; set; }

    public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFields { get; } = new List<SnailmailLetterMissingRequiredField>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
