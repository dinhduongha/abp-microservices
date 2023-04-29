using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("AccountTaxRepartitionLineTemplateId", "AccountAccountTagId")]
[Table("account_tax_repartition_financial_tags")]
[Index("AccountAccountTagId", "AccountTaxRepartitionLineTemplateId", Name = "account_tax_repartition_finan_account_account_tag_id_accoun_idx")]
public partial class AccountTaxRepartitionFinancialTag
{
    [Key]
    [Column("account_tax_repartition_line_template_id")]
    public Guid AccountTaxRepartitionLineTemplateId { get; set; }

    [Key]
    [Column("account_account_tag_id")]
    public long AccountAccountTagId { get; set; }

    [ForeignKey("AccountTaxRepartitionLineTemplateId")]
    [InverseProperty("AccountTaxRepartitionFinancialTags")]
    public virtual AccountTaxRepartitionLineTemplate AccountTaxRepartitionLineTemplate { get; set; } = null!;
}
