using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("AccountReconcileModelId", "ResPartnerCategoryId")]
[Table("account_reconcile_model_res_partner_category_rel")]
[Index("ResPartnerCategoryId", "AccountReconcileModelId", Name = "account_reconcile_model_res_p_res_partner_category_id_accou_idx")]
public partial class AccountReconcileModelResPartnerCategoryRel
{
    [Key]
    [Column("account_reconcile_model_id")]
    public Guid AccountReconcileModelId { get; set; }

    [Key]
    [Column("res_partner_category_id")]
    public long ResPartnerCategoryId { get; set; }

    [ForeignKey("AccountReconcileModelId")]
    [InverseProperty("AccountReconcileModelResPartnerCategoryRels")]
    public virtual AccountReconcileModel AccountReconcileModel { get; set; } = null!;
}
