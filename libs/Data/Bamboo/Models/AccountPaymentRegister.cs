using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountPaymentRegister
{
    public Guid Id { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? PartnerBankId { get; set; }

    public long? SourceCurrencyId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? PaymentMethodLineId { get; set; }

    public Guid? WriteoffAccountId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Communication { get; set; }

    public string? PaymentType { get; set; }

    public string? PartnerType { get; set; }

    public string? PaymentDifferenceHandling { get; set; }

    public string? WriteoffLabel { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? SourceAmount { get; set; }

    public decimal? SourceAmountCurrency { get; set; }

    public bool? GroupPayment { get; set; }

    public bool? CanEditWizard { get; set; }

    public bool? CanGroupPayments { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? PaymentTokenId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartnerBank? PartnerBank { get; set; }

    public virtual AccountPaymentMethodLine? PaymentMethodLine { get; set; }

    public virtual PaymentToken? PaymentToken { get; set; }

    public virtual ResCurrency? SourceCurrency { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual AccountAccount? WriteoffAccount { get; set; }

    //public virtual ICollection<AccountMoveLine> Lines { get; } = new List<AccountMoveLine>();
}
