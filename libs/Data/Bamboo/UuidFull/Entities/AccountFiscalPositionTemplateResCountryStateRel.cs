using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("AccountFiscalPositionTemplateId", "ResCountryStateId")]
[Table("account_fiscal_position_template_res_country_state_rel")]
[Index("ResCountryStateId", "AccountFiscalPositionTemplateId", Name = "account_fiscal_position_templ_res_country_state_id_account__idx")]
public partial class AccountFiscalPositionTemplateResCountryStateRel
{
    [Key]
    [Column("account_fiscal_position_template_id")]
    public Guid AccountFiscalPositionTemplateId { get; set; }

    [Key]
    [Column("res_country_state_id")]
    public long ResCountryStateId { get; set; }

    [ForeignKey("AccountFiscalPositionTemplateId")]
    [InverseProperty("AccountFiscalPositionTemplateResCountryStateRels")]
    public virtual AccountFiscalPositionTemplate AccountFiscalPositionTemplate { get; set; } = null!;
}
