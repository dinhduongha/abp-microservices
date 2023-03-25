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

[Table("payment_link_wizard")]
public partial class PaymentLinkWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("res_id")]
    public Guid? ResId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("res_model")]
    public string? ResModel { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("payment_provider_selection")]
    public string? PaymentProviderSelection { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("amount_max")]
    public decimal? AmountMax { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("PaymentLinkWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    [InverseProperty("PaymentLinkWizards")]
    public virtual ResCurrency? Currency { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("PaymentLinkWizards")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("PaymentLinkWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
