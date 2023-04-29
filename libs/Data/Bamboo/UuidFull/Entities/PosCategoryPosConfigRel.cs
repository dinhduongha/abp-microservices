using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("PosConfigId", "PosCategoryId")]
[Table("pos_category_pos_config_rel")]
[Index("PosCategoryId", "PosConfigId", Name = "pos_category_pos_config_rel_pos_category_id_pos_config_id_idx")]
public partial class PosCategoryPosConfigRel
{
    [Key]
    [Column("pos_config_id")]
    public Guid PosConfigId { get; set; }

    [Key]
    [Column("pos_category_id")]
    public long PosCategoryId { get; set; }

    [ForeignKey("PosConfigId")]
    [InverseProperty("PosCategoryPosConfigRels")]
    public virtual PosConfig PosConfig { get; set; } = null!;
}
