using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("MrpWorkcenterId", "MrpWorkcenterTagId")]
[Table("mrp_workcenter_mrp_workcenter_tag_rel")]
[Index("MrpWorkcenterTagId", "MrpWorkcenterId", Name = "mrp_workcenter_mrp_workcenter_mrp_workcenter_tag_id_mrp_wor_idx")]
public partial class MrpWorkcenterMrpWorkcenterTagRel
{
    [Key]
    [Column("mrp_workcenter_id")]
    public Guid MrpWorkcenterId { get; set; }

    [Key]
    [Column("mrp_workcenter_tag_id")]
    public long MrpWorkcenterTagId { get; set; }

    [ForeignKey("MrpWorkcenterId")]
    [InverseProperty("MrpWorkcenterMrpWorkcenterTagRels")]
    public virtual MrpWorkcenter MrpWorkcenter { get; set; } = null!;
}
