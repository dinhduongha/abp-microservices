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

[Table("portal_wizard_user")]
public partial class PortalWizardUser
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("wizard_id")]
    public Guid? WizardId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("PortalWizardUserCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("PortalWizardUsers")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("WizardId")]
    [InverseProperty("PortalWizardUsers")]
    public virtual PortalWizard? Wizard { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("PortalWizardUserWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}