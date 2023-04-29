using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("reset_view_arch_wizard")]
public partial class ResetViewArchWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("view_id")]
    public Guid? ViewId { get; set; }

    [Column("compare_view_id")]
    public Guid? CompareViewId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("reset_mode")]
    public string? ResetMode { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompareViewId")]
    [InverseProperty("ResetViewArchWizardCompareViews")]
    public virtual IrUiView? CompareView { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResetViewArchWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ViewId")]
    [InverseProperty("ResetViewArchWizardViews")]
    public virtual IrUiView? View { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ResetViewArchWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
