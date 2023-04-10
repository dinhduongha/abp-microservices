using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("account_group")]
[Index("ParentId", Name = "account_group_parent_id_index")]
[Index("ParentPath", Name = "account_group_parent_path_index")]
public partial class AccountGroup: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("parent_id")]
    public Guid? ParentId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("parent_path")]
    public string? ParentPath { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("code_prefix_start")]
    public string? CodePrefixStart { get; set; }

    [Column("code_prefix_end")]
    public string? CodePrefixEnd { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("AccountGroups")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("AccountGroupCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ParentId")]
    //[InverseProperty("InverseParent")]
    public virtual AccountGroup? Parent { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("AccountGroupWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [InverseProperty("Group")]
    [NotMapped]
    public virtual ICollection<AccountAccount> AccountAccounts { get; } = new List<AccountAccount>();

    [InverseProperty("Parent")]
    [NotMapped]
    public virtual ICollection<AccountGroup> InverseParent { get; } = new List<AccountGroup>();


}
