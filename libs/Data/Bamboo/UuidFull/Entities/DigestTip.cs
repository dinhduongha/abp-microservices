using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

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
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("tip_description", TypeName = "jsonb")]
    public string? TipDescription { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("DigestTipCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("GroupId")]
    [InverseProperty("DigestTips")]
    public virtual ResGroup? Group { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("DigestTipWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("DigestTipId")]
    [InverseProperty("DigestTips")]
    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();
}
