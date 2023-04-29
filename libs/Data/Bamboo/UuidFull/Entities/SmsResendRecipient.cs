using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("sms_resend_recipient")]
public partial class SmsResendRecipient
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sms_resend_id")]
    public Guid? SmsResendId { get; set; }

    [Column("notification_id")]
    public Guid? NotificationId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("partner_name")]
    public string? PartnerName { get; set; }

    [Column("sms_number")]
    public string? SmsNumber { get; set; }

    [Column("resend")]
    public bool? Resend { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("SmsResendRecipientCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("NotificationId")]
    [InverseProperty("SmsResendRecipients")]
    public virtual MailNotification? Notification { get; set; }

    [ForeignKey("SmsResendId")]
    [InverseProperty("SmsResendRecipients")]
    public virtual SmsResend? SmsResend { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SmsResendRecipientWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
