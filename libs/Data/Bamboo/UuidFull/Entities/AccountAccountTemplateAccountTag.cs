using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("AccountAccountTemplateId", "AccountAccountTagId")]
[Table("account_account_template_account_tag")]
[Index("AccountAccountTagId", "AccountAccountTemplateId", Name = "account_account_template_acco_account_account_tag_id_accoun_idx")]
public partial class AccountAccountTemplateAccountTag
{
    [Key]
    [Column("account_account_template_id")]
    public Guid AccountAccountTemplateId { get; set; }

    [Key]
    [Column("account_account_tag_id")]
    public long AccountAccountTagId { get; set; }

    [ForeignKey("AccountAccountTemplateId")]
    [InverseProperty("AccountAccountTemplateAccountTags")]
    public virtual AccountAccountTemplate AccountAccountTemplate { get; set; } = null!;
}
