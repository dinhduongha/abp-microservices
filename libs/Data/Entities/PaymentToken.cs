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

[Table("payment_token")]
[Index("TenantId", Name = "payment_token_company_id_index")]
public partial class PaymentToken: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("provider_id")]
    public Guid? ProviderId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("payment_details")]
    public string? PaymentDetails { get; set; }

    [Column("provider_ref")]
    public string? ProviderRef { get; set; }

    [Column("verified")]
    public bool? Verified { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [InverseProperty("PaymentToken")]
    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    [InverseProperty("PaymentToken")]
    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    [ForeignKey("TenantId")]
    [InverseProperty("PaymentTokens")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("PaymentTokenCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("PaymentTokens")]
    public virtual ResPartner? Partner { get; set; }

    [InverseProperty("Token")]
    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    [ForeignKey("ProviderId")]
    [InverseProperty("PaymentTokens")]
    public virtual PaymentProvider? Provider { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("PaymentTokenWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
