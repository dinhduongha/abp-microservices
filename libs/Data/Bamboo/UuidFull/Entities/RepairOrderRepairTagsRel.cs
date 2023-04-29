using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("RepairOrderId", "RepairTagsId")]
[Table("repair_order_repair_tags_rel")]
[Index("RepairTagsId", "RepairOrderId", Name = "repair_order_repair_tags_rel_repair_tags_id_repair_order_id_idx")]
public partial class RepairOrderRepairTagsRel
{
    [Key]
    [Column("repair_order_id")]
    public Guid RepairOrderId { get; set; }

    [Key]
    [Column("repair_tags_id")]
    public long RepairTagsId { get; set; }

    [ForeignKey("RepairOrderId")]
    [InverseProperty("RepairOrderRepairTagsRels")]
    public virtual RepairOrder RepairOrder { get; set; } = null!;
}
