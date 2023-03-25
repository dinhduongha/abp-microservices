using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("mail_message_schedule")]
public partial class MailMessageSchedule
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mail_message_id")]
    public Guid? MailMessageId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("notification_parameters")]
    public string? NotificationParameters { get; set; }

    [Column("scheduled_datetime", TypeName = "timestamp without time zone")]
    public DateTime? ScheduledDatetime { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("MailMessageScheduleCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MailMessageId")]
    [InverseProperty("MailMessageSchedules")]
    public virtual MailMessage? MailMessage { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("MailMessageScheduleWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
