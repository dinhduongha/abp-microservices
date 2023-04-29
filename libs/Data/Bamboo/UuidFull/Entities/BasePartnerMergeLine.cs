using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("base_partner_merge_line")]
public partial class BasePartnerMergeLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("wizard_id")]
    public Guid? WizardId { get; set; }

    [Column("min_id")]
    public Guid? MinId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("aggr_ids")]
    public string? AggrIds { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("CurrentLine")]
    public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizards { get; } = new List<BasePartnerMergeAutomaticWizard>();

    [ForeignKey("CreateUid")]
    [InverseProperty("BasePartnerMergeLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WizardId")]
    [InverseProperty("BasePartnerMergeLines")]
    public virtual BasePartnerMergeAutomaticWizard? Wizard { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("BasePartnerMergeLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
