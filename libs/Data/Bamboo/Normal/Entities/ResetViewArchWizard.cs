﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

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
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("reset_mode")]
    public string? ResetMode { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CompareViewId")]
    //[InverseProperty("ResetViewArchWizardCompareViews")]
    public virtual IrUiView? CompareView { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("ResetViewArchWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ViewId")]
    //[InverseProperty("ResetViewArchWizardViews")]
    public virtual IrUiView? View { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("ResetViewArchWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
