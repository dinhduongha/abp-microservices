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

[Table("ir_filters")]
[Index("ModelId", "UserId", "ActionId", "Name", Name = "ir_filters_name_model_uid_unique", IsUnique = true)]
public partial class IrFilter
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("action_id")]
    public Guid? ActionId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("model_id")]
    public string? ModelId { get; set; }

    [Column("domain")]
    public string? Domain { get; set; }

    [Column("context")]
    public string? Context { get; set; }

    [Column("sort")]
    public string? Sort { get; set; }

    [Column("is_default")]
    public bool? IsDefault { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("IrFilterCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("IrFilterUsers")]
    public virtual ResUser? User { get; set; }

    [InverseProperty("Filter")]
    public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilters { get; } = new List<WebsiteSnippetFilter>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("IrFilterWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
