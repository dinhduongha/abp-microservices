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

[Table("sms_sms")]
[Index("MailMessageId", Name = "sms_sms_mail_message_id_index")]
public partial class SmsSm
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("mail_message_id")]
    public Guid? MailMessageId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("number")]
    public string? Number { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("failure_type")]
    public string? FailureType { get; set; }

    [Column("body")]
    public string? Body { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("SmsSmCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MailMessageId")]
    //[InverseProperty("SmsSms")]
    public virtual MailMessage? MailMessage { get; set; }

    [ForeignKey("PartnerId")]
    //[InverseProperty("SmsSms")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("SmsSmWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Sms")]
    [NotMapped]
    public virtual ICollection<MailNotification> MailNotifications { get; } = new List<MailNotification>();

}
