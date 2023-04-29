using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("AccountAccountId", "AccountAccountTagId")]
[Table("account_account_account_tag")]
[Index("AccountAccountTagId", "AccountAccountId", Name = "account_account_account_tag_account_account_tag_id_account__idx")]
public partial class AccountAccountAccountTag
{
    [Key]
    [Column("account_account_id")]
    public Guid AccountAccountId { get; set; }

    [Key]
    [Column("account_account_tag_id")]
    public long AccountAccountTagId { get; set; }

    [ForeignKey("AccountAccountId")]
    [InverseProperty("AccountAccountAccountTags")]
    public virtual AccountAccount AccountAccount { get; set; } = null!;
}
