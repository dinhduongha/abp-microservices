using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

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
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("call_at", TypeName = "timestamp without time zone")]
    public DateTime? CallAt { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrCronTriggerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CronId")]
    [InverseProperty("IrCronTriggers")]
    public virtual IrCron? Cron { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrCronTriggerWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
