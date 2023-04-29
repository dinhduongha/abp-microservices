using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_fiscal_position_account")]
[Index("PositionId", "AccountSrcId", "AccountDestId", Name = "account_fiscal_position_account_account_src_dest_uniq", IsUnique = true)]
public partial class AccountFiscalPositionAccount
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("position_id")]
    public Guid? PositionId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("account_src_id")]
    public Guid? AccountSrcId { get; set; }

    [Column("account_dest_id")]
    public Guid? AccountDestId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AccountDestId")]
    [InverseProperty("AccountFiscalPositionAccountAccountDests")]
    public virtual AccountAccount? AccountDest { get; set; }

    [ForeignKey("AccountSrcId")]
    [InverseProperty("AccountFiscalPositionAccountAccountSrcs")]
    public virtual AccountAccount? AccountSrc { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountFiscalPositionAccounts")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountFiscalPositionAccountCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PositionId")]
    [InverseProperty("AccountFiscalPositionAccounts")]
    public virtual AccountFiscalPosition? Position { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountFiscalPositionAccountWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
