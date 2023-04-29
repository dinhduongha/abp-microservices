using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PaymentTransaction
{
    public Guid Id { get; set; }

    public Guid? ProviderId { get; set; }

    public Guid? CompanyId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? TokenId { get; set; }

    public Guid? SourceTransactionId { get; set; }

    public Guid? CallbackModelId { get; set; }

    public Guid? CallbackResId { get; set; }

    public Guid? PartnerId { get; set; }

    public long? PartnerStateId { get; set; }

    public long? PartnerCountryId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Reference { get; set; }

    public string? ProviderReference { get; set; }

    public string? State { get; set; }

    public string? Operation { get; set; }

    public string? LandingRoute { get; set; }

    public string? CallbackMethod { get; set; }

    public string? CallbackHash { get; set; }

    public string? PartnerName { get; set; }

    public string? PartnerLang { get; set; }

    public string? PartnerEmail { get; set; }

    public string? PartnerAddress { get; set; }

    public string? PartnerZip { get; set; }

    public string? PartnerCity { get; set; }

    public string? PartnerPhone { get; set; }

    public string? StateMessage { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Fees { get; set; }

    public bool? IsPostProcessed { get; set; }

    public bool? Tokenize { get; set; }

    public bool? CallbackIsDone { get; set; }

    public DateTime? LastStateChange { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? PaymentId { get; set; }

    public bool? IsDonation { get; set; }

    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    public virtual IrModel? CallbackModel { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PaymentTransaction> InverseSourceTransaction { get; } = new List<PaymentTransaction>();

    public virtual ResPartner? Partner { get; set; }

    public virtual AccountPayment? Payment { get; set; }

    public virtual PaymentProvider? Provider { get; set; }

    public virtual PaymentTransaction? SourceTransaction { get; set; }

    public virtual PaymentToken? Token { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMove> Invoices { get; } = new List<AccountMove>();

    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();
}
