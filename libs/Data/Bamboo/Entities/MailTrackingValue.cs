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

[Table("mail_tracking_value")]
[Index("Field", Name = "mail_tracking_value_field_index")]
[Index("MailMessageId", Name = "mail_tracking_value_mail_message_id_index")]
public partial class MailTrackingValue
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("field")]
    public Guid? Field { get; set; }

    [Column("old_value_integer")]
    public long? OldValueInteger { get; set; }

    [Column("new_value_integer")]
    public long? NewValueInteger { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("mail_message_id")]
    public Guid? MailMessageId { get; set; }

    [Column("tracking_sequence")]
    public long? TrackingSequence { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("field_desc")]
    public string? FieldDesc { get; set; }

    [Column("field_type")]
    public string? FieldType { get; set; }

    [Column("old_value_char")]
    public string? OldValueChar { get; set; }

    [Column("new_value_char")]
    public string? NewValueChar { get; set; }

    [Column("old_value_text")]
    public string? OldValueText { get; set; }

    [Column("new_value_text")]
    public string? NewValueText { get; set; }

    [Column("old_value_datetime", TypeName = "timestamp without time zone")]
    public DateTime? OldValueDatetime { get; set; }

    [Column("new_value_datetime", TypeName = "timestamp without time zone")]
    public DateTime? NewValueDatetime { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("old_value_float")]
    public double? OldValueFloat { get; set; }

    [Column("old_value_monetary")]
    public double? OldValueMonetary { get; set; }

    [Column("new_value_float")]
    public double? NewValueFloat { get; set; }

    [Column("new_value_monetary")]
    public double? NewValueMonetary { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("MailTrackingValueCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    //[InverseProperty("MailTrackingValues")]
    public virtual ResCurrency? Currency { get; set; }

    [ForeignKey("Field")]
    //[InverseProperty("MailTrackingValues")]
    public virtual IrModelField? FieldNavigation { get; set; }

    [ForeignKey("MailMessageId")]
    //[InverseProperty("MailTrackingValues")]
    public virtual MailMessage? MailMessage { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("MailTrackingValueWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
