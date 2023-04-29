using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("CategoryId", "PartnerId")]
[Table("res_partner_res_partner_category_rel")]
[Index("PartnerId", "CategoryId", Name = "res_partner_res_partner_category_rel_partner_id_category_id_idx")]
public partial class ResPartnerResPartnerCategoryRel
{
    [Key]
    [Column("category_id")]
    public long CategoryId { get; set; }

    [Key]
    [Column("partner_id")]
    public Guid PartnerId { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("ResPartnerResPartnerCategoryRels")]
    public virtual ResPartner Partner { get; set; } = null!;
}
