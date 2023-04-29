using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("PricelistId", "ResCountryGroupId")]
[Table("res_country_group_pricelist_rel")]
[Index("ResCountryGroupId", "PricelistId", Name = "res_country_group_pricelist_r_res_country_group_id_pricelis_idx")]
public partial class ResCountryGroupPricelistRel
{
    [Key]
    [Column("pricelist_id")]
    public Guid PricelistId { get; set; }

    [Key]
    [Column("res_country_group_id")]
    public long ResCountryGroupId { get; set; }

    [ForeignKey("PricelistId")]
    [InverseProperty("ResCountryGroupPricelistRels")]
    public virtual ProductPricelist Pricelist { get; set; } = null!;
}
