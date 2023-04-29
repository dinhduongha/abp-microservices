using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_message")]
[Index("AuthorId", Name = "mail_message_author_id_index")]
[Index("MailActivityTypeId", Name = "mail_message_mail_activity_type_id_index")]
[Index("MessageId", Name = "mail_message_message_id_index")]
[Index("Model", "ResId", "Id", Name = "mail_message_model_res_id_id_idx")]
[Index("Model", "ResId", Name = "mail_message_model_res_id_idx")]
[Index("SubtypeId", Name = "mail_message_subtype_id_index")]
public partial class MailMessage
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("subtype_id")]
    public long? SubtypeId { get; set; }

    [Column("mail_activity_type_id")]
    public long? MailActivityTypeId { get; set; }

    [Column("author_id")]
    public Guid? AuthorId { get; set; }

    [Column("author_guest_id")]
    public Guid? AuthorGuestId { get; set; }

    [Column("mail_server_id")]
    public Guid? MailServerId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("subject")]
    public string? Subject { get; set; }

    [Column("model")]
    public string? Model { get; set; }

    [Column("record_name")]
    public string? RecordName { get; set; }

    [Column("message_type")]
    public string? MessageType { get; set; }

    [Column("email_from")]
    public string? EmailFrom { get; set; }

    [Column("message_id")]
    public string? MessageId { get; set; }

    [Column("reply_to")]
    public string? ReplyTo { get; set; }

    [Column("email_layout_xmlid")]
    public string? EmailLayoutXmlid { get; set; }

    [Column("body")]
    public string? Body { get; set; }

    [Column("is_internal")]
    public bool? IsInternal { get; set; }

    [Column("reply_to_force_new")]
    public bool? ReplyToForceNew { get; set; }

    [Column("email_add_signature")]
    public bool? EmailAddSignature { get; set; }

    [Column("date", TypeName = "timestamp without time zone")]
    public DateTime? Date { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AuthorId")]
    [InverseProperty("MailMessages")]
    public virtual ResPartner? Author { get; set; }

    [ForeignKey("AuthorGuestId")]
    [InverseProperty("MailMessages")]
    public virtual MailGuest? AuthorGuest { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailMessageCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<MailMessage> InverseParent { get; } = new List<MailMessage>();

    [InverseProperty("FetchedMessage")]
    public virtual ICollection<MailChannelMember> MailChannelMemberFetchedMessages { get; } = new List<MailChannelMember>();

    [InverseProperty("SeenMessage")]
    public virtual ICollection<MailChannelMember> MailChannelMemberSeenMessages { get; } = new List<MailChannelMember>();

    [InverseProperty("Parent")]
    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; } = new List<MailComposeMessage>();

    [InverseProperty("Message")]
    public virtual ICollection<MailLinkPreview> MailLinkPreviews { get; } = new List<MailLinkPreview>();

    [InverseProperty("MailMessage")]
    public virtual ICollection<MailMail> MailMails { get; } = new List<MailMail>();

    [InverseProperty("Message")]
    public virtual ICollection<MailMessageReaction> MailMessageReactions { get; } = new List<MailMessageReaction>();

    [InverseProperty("MailMessage")]
    public virtual ICollection<MailMessageSchedule> MailMessageSchedules { get; } = new List<MailMessageSchedule>();

    [InverseProperty("MailMessage")]
    public virtual ICollection<MailNotification> MailNotifications { get; } = new List<MailNotification>();

    [InverseProperty("MailMessage")]
    public virtual ICollection<MailResendMessage> MailResendMessages { get; } = new List<MailResendMessage>();

    [ForeignKey("MailServerId")]
    [InverseProperty("MailMessages")]
    public virtual IrMailServer? MailServer { get; set; }

    [InverseProperty("MailMessage")]
    public virtual ICollection<MailTrackingValue> MailTrackingValues { get; } = new List<MailTrackingValue>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual MailMessage? Parent { get; set; }

    [InverseProperty("Message")]
    public virtual ICollection<RatingRating> RatingRatings { get; } = new List<RatingRating>();

    [InverseProperty("MailMessage")]
    public virtual ICollection<SmsResend> SmsResends { get; } = new List<SmsResend>();

    [InverseProperty("MailMessage")]
    public virtual ICollection<SmsSm> SmsSms { get; } = new List<SmsSm>();

    [InverseProperty("Message")]
    public virtual ICollection<SnailmailLetterFormatError> SnailmailLetterFormatErrors { get; } = new List<SnailmailLetterFormatError>();

    [InverseProperty("Message")]
    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MailMessageWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MessageId")]
    [InverseProperty("Messages")]
    public virtual ICollection<IrAttachment> Attachments { get; } = new List<IrAttachment>();

    [ForeignKey("MailMessageId")]
    [InverseProperty("MailMessagesNavigation")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    [ForeignKey("MailMessageId")]
    [InverseProperty("MailMessages1")]
    public virtual ICollection<ResPartner> ResPartnersNavigation { get; } = new List<ResPartner>();
}
