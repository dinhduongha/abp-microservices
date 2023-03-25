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

[Table("digest_tip")]
public partial class DigestTip
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("group_id")]
    public Guid? GroupId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("tip_description", TypeName = "jsonb")]
    public string? TipDescription { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("DigestTipCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("DigestTips")]
    public virtual ResGroup? Group { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("DigestTipWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("DigestTipId")]
    [InverseProperty("DigestTips")]
    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();
}
