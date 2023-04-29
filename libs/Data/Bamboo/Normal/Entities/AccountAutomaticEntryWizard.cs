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

[Table("account_automatic_entry_wizard")]
public partial class AccountAutomaticEntryWizard: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("destination_account_id")]
    public Guid? DestinationAccountId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("action")]
    public string? Action { get; set; }

    [Column("account_type")]
    public string? AccountType { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("total_amount")]
    public decimal? TotalAmount { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("percentage")]
    public double? Percentage { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("AccountAutomaticEntryWizards")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("AccountAutomaticEntryWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DestinationAccountId")]
    //[InverseProperty("AccountAutomaticEntryWizards")]
    public virtual AccountAccount? DestinationAccount { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("AccountAutomaticEntryWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountAutomaticEntryWizardId")]
    [InverseProperty("AccountAutomaticEntryWizards")]
    [NotMapped]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();
}
