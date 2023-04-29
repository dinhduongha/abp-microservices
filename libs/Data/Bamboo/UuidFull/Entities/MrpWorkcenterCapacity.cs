using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_workcenter_capacity")]
[Index("WorkcenterId", "ProductId", Name = "mrp_workcenter_capacity_unique_product", IsUnique = true)]
public partial class MrpWorkcenterCapacity
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("workcenter_id")]
    public Guid? WorkcenterId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("capacity")]
    public double? Capacity { get; set; }

    [Column("time_start")]
    public double? TimeStart { get; set; }

    [Column("time_stop")]
    public double? TimeStop { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpWorkcenterCapacityCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("MrpWorkcenterCapacities")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("WorkcenterId")]
    [InverseProperty("MrpWorkcenterCapacities")]
    public virtual MrpWorkcenter? Workcenter { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpWorkcenterCapacityWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
