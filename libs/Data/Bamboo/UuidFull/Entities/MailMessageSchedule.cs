using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_message_schedule")]
public partial class MailMessageSchedule
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("mail_message_id")]
    public Guid? MailMessageId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("notification_parameters")]
    public string? NotificationParameters { get; set; }

    [Column("scheduled_datetime", TypeName = "timestamp without time zone")]
    public DateTime? ScheduledDatetime { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailMessageScheduleCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MailMessageId")]
    [InverseProperty("MailMessageSchedules")]
    public virtual MailMessage? MailMessage { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MailMessageScheduleWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
