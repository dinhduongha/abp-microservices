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
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("partner_name")]
    public string? PartnerName { get; set; }

    [Column("sms_number")]
    public string? SmsNumber { get; set; }

    [Column("resend")]
    public bool? Resend { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("SmsResendRecipientCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("NotificationId")]
    //[InverseProperty("SmsResendRecipients")]
    public virtual MailNotification? Notification { get; set; }

    [ForeignKey("SmsResendId")]
    //[InverseProperty("SmsResendRecipients")]
    public virtual SmsResend? SmsResend { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("SmsResendRecipientWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}