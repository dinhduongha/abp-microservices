using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("iap_account")]
public partial class IapAccount
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("service_name")]
    public string? ServiceName { get; set; }

    [Column("account_token")]
    public string? AccountToken { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IapAccountCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IapAccountWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("IapAccountId")]
    [InverseProperty("IapAccounts")]
    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();
}
