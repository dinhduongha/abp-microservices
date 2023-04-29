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

[Table("account_reconcile_model_partner_mapping")]
public partial class AccountReconcileModelPartnerMapping
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("model_id")]
    public Guid? ModelId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("payment_ref_regex")]
    public string? PaymentRefRegex { get; set; }

    [Column("narration_regex")]
    public string? NarrationRegex { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("AccountReconcileModelPartnerMappingCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ModelId")]
    //[InverseProperty("AccountReconcileModelPartnerMappings")]
    public virtual AccountReconcileModel? Model { get; set; }

    [ForeignKey("PartnerId")]
    //[InverseProperty("AccountReconcileModelPartnerMappings")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("AccountReconcileModelPartnerMappingWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}