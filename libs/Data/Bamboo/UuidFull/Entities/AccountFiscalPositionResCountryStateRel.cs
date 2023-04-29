using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("AccountFiscalPositionId", "ResCountryStateId")]
[Table("account_fiscal_position_res_country_state_rel")]
[Index("ResCountryStateId", "AccountFiscalPositionId", Name = "account_fiscal_position_res_c_res_country_state_id_account__idx")]
public partial class AccountFiscalPositionResCountryStateRel
{
    [Key]
    [Column("account_fiscal_position_id")]
    public Guid AccountFiscalPositionId { get; set; }

    [Key]
    [Column("res_country_state_id")]
    public long ResCountryStateId { get; set; }

    [ForeignKey("AccountFiscalPositionId")]
    [InverseProperty("AccountFiscalPositionResCountryStateRels")]
    public virtual AccountFiscalPosition AccountFiscalPosition { get; set; } = null!;
}
