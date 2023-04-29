using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("ProductTemplateId", "AccountAccountTagId")]
[Table("account_account_tag_product_template_rel")]
[Index("AccountAccountTagId", "ProductTemplateId", Name = "account_account_tag_product_t_account_account_tag_id_produc_idx")]
public partial class AccountAccountTagProductTemplateRel
{
    [Key]
    [Column("product_template_id")]
    public Guid ProductTemplateId { get; set; }

    [Key]
    [Column("account_account_tag_id")]
    public long AccountAccountTagId { get; set; }

    [ForeignKey("ProductTemplateId")]
    [InverseProperty("AccountAccountTagProductTemplateRels")]
    public virtual ProductTemplate ProductTemplate { get; set; } = null!;
}
