using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_workcenter_productivity_loss")]
public partial class MrpWorkcenterProductivityLoss
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("loss_id")]
    public long? LossId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("loss_type")]
    public string? LossType { get; set; }

    [Column("manual")]
    public bool? Manual { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpWorkcenterProductivityLossCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Loss")]
    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; } = new List<MrpWorkcenterProductivity>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpWorkcenterProductivityLossWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
