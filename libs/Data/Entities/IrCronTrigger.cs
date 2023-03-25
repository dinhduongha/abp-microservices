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

[Table("ir_cron_trigger")]
[Index("CronId", Name = "ir_cron_trigger_cron_id_index")]
public partial class IrCronTrigger
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("cron_id")]
    public Guid? CronId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("call_at", TypeName = "timestamp without time zone")]
    public DateTime? CallAt { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("IrCronTriggerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CronId")]
    [InverseProperty("IrCronTriggers")]
    public virtual IrCron? Cron { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("IrCronTriggerWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
