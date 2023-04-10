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

[Table("privacy_lookup_wizard_line")]
public partial class PrivacyLookupWizardLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("wizard_id")]
    public Guid? WizardId { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("res_model_id")]
    public Guid? ResModelId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("res_name")]
    public string? ResName { get; set; }

    [Column("res_model")]
    public string? ResModel { get; set; }

    [Column("execution_details")]
    public string? ExecutionDetails { get; set; }

    [Column("has_active")]
    public bool? HasActive { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [Column("is_unlinked")]
    public bool? IsUnlinked { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("PrivacyLookupWizardLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ResModelId")]
    //[InverseProperty("PrivacyLookupWizardLines")]
    public virtual IrModel? ResModelNavigation { get; set; }

    [ForeignKey("WizardId")]
    //[InverseProperty("PrivacyLookupWizardLines")]
    public virtual PrivacyLookupWizard? Wizard { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("PrivacyLookupWizardLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}