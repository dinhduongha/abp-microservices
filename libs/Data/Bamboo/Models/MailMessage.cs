using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailMessage
{
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? ResId { get; set; }

    public long? SubtypeId { get; set; }

    public long? MailActivityTypeId { get; set; }

    public Guid? AuthorId { get; set; }

    public Guid? AuthorGuestId { get; set; }

    public Guid? MailServerId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Subject { get; set; }

    public string? Model { get; set; }

    public string? RecordName { get; set; }

    public string? MessageType { get; set; }

    public string? EmailFrom { get; set; }

    public string? MessageId { get; set; }

    public string? ReplyTo { get; set; }

    public string? EmailLayoutXmlid { get; set; }

    public string? Body { get; set; }

    public bool? IsInternal { get; set; }

    public bool? ReplyToForceNew { get; set; }

    public bool? EmailAddSignature { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResPartner? Author { get; set; }

    public virtual MailGuest? AuthorGuest { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<MailMessage> InverseParent { get; } = new List<MailMessage>();

    public virtual MailActivityType? MailActivityType { get; set; }

    //public virtual ICollection<MailChannelMember> MailChannelMemberFetchedMessages { get; } = new List<MailChannelMember>();

    //public virtual ICollection<MailChannelMember> MailChannelMemberSeenMessages { get; } = new List<MailChannelMember>();

    //public virtual ICollection<MailComposeMessage> MailComposeMessages { get; } = new List<MailComposeMessage>();

    //public virtual ICollection<MailLinkPreview> MailLinkPreviews { get; } = new List<MailLinkPreview>();

    //public virtual ICollection<MailMail> MailMails { get; } = new List<MailMail>();

    //public virtual ICollection<MailMessageReaction> MailMessageReactions { get; } = new List<MailMessageReaction>();

    //public virtual ICollection<MailMessageSchedule> MailMessageSchedules { get; } = new List<MailMessageSchedule>();

    //public virtual ICollection<MailNotification> MailNotifications { get; } = new List<MailNotification>();

    //public virtual ICollection<MailResendMessage> MailResendMessages { get; } = new List<MailResendMessage>();

    public virtual IrMailServer? MailServer { get; set; }

    //public virtual ICollection<MailTrackingValue> MailTrackingValues { get; } = new List<MailTrackingValue>();

    public virtual MailMessage? Parent { get; set; }

    //public virtual ICollection<RatingRating> RatingRatings { get; } = new List<RatingRating>();

    //public virtual ICollection<SmsResend> SmsResends { get; } = new List<SmsResend>();

    //public virtual ICollection<SmsSm> SmsSms { get; } = new List<SmsSm>();

    //public virtual ICollection<SnailmailLetterFormatError> SnailmailLetterFormatErrors { get; } = new List<SnailmailLetterFormatError>();

    //public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    public virtual MailMessageSubtype? Subtype { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<IrAttachment> Attachments { get; } = new List<IrAttachment>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    //public virtual ICollection<ResPartner> ResPartnersNavigation { get; } = new List<ResPartner>();
}
