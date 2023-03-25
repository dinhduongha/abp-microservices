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

[Table("mail_activity_type")]
[Index("CreationTime", Name = "mail_activity_type_create_uid_index")]
public partial class MailActivityType
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("sequence", TypeName = "bigserial")]
    public long Sequence { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("delay_count")]
    public long? DelayCount { get; set; }

    [Column("triggered_next_type_id")]
    public long? TriggeredNextTypeId { get; set; }

    [Column("default_user_id")]
    public Guid? DefaultUserId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("delay_unit")]
    public string? DelayUnit { get; set; }

    [Column("delay_from")]
    public string? DelayFrom { get; set; }

    [Column("icon")]
    public string? Icon { get; set; }

    [Column("decoration_type")]
    public string? DecorationType { get; set; }

    [Column("res_model")]
    public string? ResModel { get; set; }

    [Column("chaining_type")]
    public string? ChainingType { get; set; }

    [Column("category")]
    public string? Category { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("summary", TypeName = "jsonb")]
    public string? Summary { get; set; }

    [Column("default_note", TypeName = "jsonb")]
    public string? DefaultNote { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("SaleActivityType")]
    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    [ForeignKey("CreatorId")]
    [InverseProperty("MailActivityTypeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DefaultUserId")]
    [InverseProperty("MailActivityTypeDefaultUsers")]
    public virtual ResUser? DefaultUser { get; set; }

    [InverseProperty("ActivityType")]
    public virtual ICollection<HrPlanActivityType> HrPlanActivityTypes { get; } = new List<HrPlanActivityType>();

    [InverseProperty("TriggeredNextType")]
    public virtual ICollection<MailActivityType> InverseTriggeredNextType { get; } = new List<MailActivityType>();

    [InverseProperty("ActivityType")]
    public virtual ICollection<IrActServer> IrActServers { get; } = new List<IrActServer>();

    [InverseProperty("ActivityType")]
    public virtual ICollection<MailActivity> MailActivityActivityTypes { get; } = new List<MailActivity>();

    [InverseProperty("PreviousActivityType")]
    public virtual ICollection<MailActivity> MailActivityPreviousActivityTypes { get; } = new List<MailActivity>();

    [InverseProperty("RecommendedActivityType")]
    public virtual ICollection<MailActivity> MailActivityRecommendedActivityTypes { get; } = new List<MailActivity>();

    [InverseProperty("MailActivityType")]
    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; } = new List<MailComposeMessage>();

    [InverseProperty("MailActivityType")]
    public virtual ICollection<MailMessage> MailMessages { get; } = new List<MailMessage>();

    [ForeignKey("TriggeredNextTypeId")]
    [InverseProperty("InverseTriggeredNextType")]
    public virtual MailActivityType? TriggeredNextType { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("MailActivityTypeWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("RecommendedId")]
    [InverseProperty("Recommendeds")]
    public virtual ICollection<MailActivityType> Activities { get; } = new List<MailActivityType>();

    [ForeignKey("MailActivityTypeId")]
    [InverseProperty("MailActivityTypes")]
    public virtual ICollection<MailTemplate> MailTemplates { get; } = new List<MailTemplate>();

    [ForeignKey("ActivityId")]
    [InverseProperty("Activities")]
    public virtual ICollection<MailActivityType> Recommendeds { get; } = new List<MailActivityType>();
}
