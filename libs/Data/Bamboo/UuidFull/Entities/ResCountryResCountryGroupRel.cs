using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ResCountryId", "ResCountryGroupId")]
[Table("res_country_res_country_group_rel")]
[Index("ResCountryGroupId", "ResCountryId", Name = "res_country_res_country_group_res_country_group_id_res_coun_idx")]
public partial class ResCountryResCountryGroupRel
{
    [Key]
    [Column("res_country_id")]
    public long ResCountryId { get; set; }

    [Key]
    [Column("res_country_group_id")]
    public long ResCountryGroupId { get; set; }
}
