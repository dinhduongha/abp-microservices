using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("AccountReconcileModelTemplateId", "ResPartnerCategoryId")]
[Table("account_reconcile_model_template_res_partner_category_rel")]
[Index("ResPartnerCategoryId", "AccountReconcileModelTemplateId", Name = "account_reconcile_model_templ_res_partner_category_id_accou_idx")]
public partial class AccountReconcileModelTemplateResPartnerCategoryRel
{
    [Key]
    [Column("account_reconcile_model_template_id")]
    public Guid AccountReconcileModelTemplateId { get; set; }

    [Key]
    [Column("res_partner_category_id")]
    public long ResPartnerCategoryId { get; set; }

    [ForeignKey("AccountReconcileModelTemplateId")]
    [InverseProperty("AccountReconcileModelTemplateResPartnerCategoryRels")]
    public virtual AccountReconcileModelTemplate AccountReconcileModelTemplate { get; set; } = null!;
}
