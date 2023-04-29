using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("AccountMoveLineId", "AccountAccountTagId")]
[Table("account_account_tag_account_move_line_rel")]
[Index("AccountAccountTagId", "AccountMoveLineId", Name = "account_account_tag_account_m_account_account_tag_id_accoun_idx")]
public partial class AccountAccountTagAccountMoveLineRel
{
    [Key]
    [Column("account_move_line_id")]
    public Guid AccountMoveLineId { get; set; }

    [Key]
    [Column("account_account_tag_id")]
    public long AccountAccountTagId { get; set; }

    [ForeignKey("AccountMoveLineId")]
    [InverseProperty("AccountAccountTagAccountMoveLineRels")]
    public virtual AccountMoveLine AccountMoveLine { get; set; } = null!;
}
