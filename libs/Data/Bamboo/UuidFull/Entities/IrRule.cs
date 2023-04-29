using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_rule")]
[Index("ModelId", Name = "ir_rule_model_id_index")]
[Index("Name", Name = "ir_rule_name_index")]
public partial class IrRule
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("model_id")]
    public Guid? ModelId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("domain_force")]
    public string? DomainForce { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("perm_read")]
    public bool? PermRead { get; set; }

    [Column("perm_write")]
    public bool? PermWrite { get; set; }

    [Column("perm_create")]
    public bool? PermCreate { get; set; }

    [Column("perm_unlink")]
    public bool? PermUnlink { get; set; }

    [Column("global")]
    public bool? Global { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrRuleCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ModelId")]
    [InverseProperty("IrRules")]
    public virtual IrModel? Model { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrRuleWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("RuleGroupId")]
    [InverseProperty("RuleGroups")]
    public virtual ICollection<ResGroup> Groups { get; } = new List<ResGroup>();
}
