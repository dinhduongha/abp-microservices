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

[Table("account_payment_register")]
public partial class AccountPaymentRegister: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("partner_bank_id")]
    public Guid? PartnerBankId { get; set; }

    [Column("source_currency_id")]
    public long? SourceCurrencyId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("payment_method_line_id")]
    public Guid? PaymentMethodLineId { get; set; }

    [Column("writeoff_account_id")]
    public Guid? WriteoffAccountId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("communication")]
    public string? Communication { get; set; }

    [Column("payment_type")]
    public string? PaymentType { get; set; }

    [Column("partner_type")]
    public string? PartnerType { get; set; }

    [Column("payment_difference_handling")]
    public string? PaymentDifferenceHandling { get; set; }

    [Column("writeoff_label")]
    public string? WriteoffLabel { get; set; }

    [Column("payment_date")]
    public DateOnly? PaymentDate { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("source_amount")]
    public decimal? SourceAmount { get; set; }

    [Column("source_amount_currency")]
    public decimal? SourceAmountCurrency { get; set; }

    [Column("group_payment")]
    public bool? GroupPayment { get; set; }

    [Column("can_edit_wizard")]
    public bool? CanEditWizard { get; set; }

    [Column("can_group_payments")]
    public bool? CanGroupPayments { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("payment_token_id")]
    public Guid? PaymentTokenId { get; set; }

    [ForeignKey("TenantId")]
    //[InverseProperty("AccountPaymentRegisters")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("AccountPaymentRegisterCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CurrencyId")]
    //[InverseProperty("AccountPaymentRegisterCurrencies")]
    public virtual ResCurrency? Currency { get; set; }

    [ForeignKey("JournalId")]
    //[InverseProperty("AccountPaymentRegisters")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("PartnerId")]
    //[InverseProperty("AccountPaymentRegisters")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PartnerBankId")]
    //[InverseProperty("AccountPaymentRegisters")]
    public virtual ResPartnerBank? PartnerBank { get; set; }

    [ForeignKey("PaymentMethodLineId")]
    //[InverseProperty("AccountPaymentRegisters")]
    public virtual AccountPaymentMethodLine? PaymentMethodLine { get; set; }

    [ForeignKey("PaymentTokenId")]
    //[InverseProperty("AccountPaymentRegisters")]
    public virtual PaymentToken? PaymentToken { get; set; }

    [ForeignKey("SourceCurrencyId")]
    //[InverseProperty("AccountPaymentRegisterSourceCurrencies")]
    public virtual ResCurrency? SourceCurrency { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("AccountPaymentRegisterWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("WriteoffAccountId")]
    //[InverseProperty("AccountPaymentRegisters")]
    public virtual AccountAccount? WriteoffAccount { get; set; }

    [ForeignKey("WizardId")]
    [InverseProperty("Wizards")]
    [NotMapped]
    public virtual ICollection<AccountMoveLine> Lines { get; } = new List<AccountMoveLine>();
}
