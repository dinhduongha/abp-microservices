using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ResConfigSettingsId", "PosCategoryId")]
[Table("pos_category_res_config_settings_rel")]
[Index("PosCategoryId", "ResConfigSettingsId", Name = "pos_category_res_config_setti_pos_category_id_res_config_se_idx")]
public partial class PosCategoryResConfigSettingsRel
{
    [Key]
    [Column("res_config_settings_id")]
    public Guid ResConfigSettingsId { get; set; }

    [Key]
    [Column("pos_category_id")]
    public long PosCategoryId { get; set; }

    [ForeignKey("ResConfigSettingsId")]
    [InverseProperty("PosCategoryResConfigSettingsRels")]
    public virtual ResConfigSetting ResConfigSettings { get; set; } = null!;
}
