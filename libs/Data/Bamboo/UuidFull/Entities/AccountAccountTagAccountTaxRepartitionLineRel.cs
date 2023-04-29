using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("AccountTaxRepartitionLineId", "AccountAccountTagId")]
[Table("account_account_tag_account_tax_repartition_line_rel")]
[Index("AccountAccountTagId", "AccountTaxRepartitionLineId", Name = "account_account_tag_account_t_account_account_tag_id_accoun_idx")]
public partial class AccountAccountTagAccountTaxRepartitionLineRel
{
    [Key]
    [Column("account_tax_repartition_line_id")]
    public Guid AccountTaxRepartitionLineId { get; set; }

    [Key]
    [Column("account_account_tag_id")]
    public long AccountAccountTagId { get; set; }

    [ForeignKey("AccountTaxRepartitionLineId")]
    [InverseProperty("AccountAccountTagAccountTaxRepartitionLineRels")]
    public virtual AccountTaxRepartitionLine AccountTaxRepartitionLine { get; set; } = null!;
}
