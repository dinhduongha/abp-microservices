using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("payment_transaction")]
[Index("CompanyId", Name = "payment_transaction_company_id_index")]
[Index("Operation", Name = "payment_transaction_operation_index")]
[Index("Reference", Name = "payment_transaction_reference_uniq", IsUnique = true)]
[Index("State", Name = "payment_transaction_state_index")]
public partial class PaymentTransaction
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("provider_id")]
    public Guid? ProviderId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("token_id")]
    public Guid? TokenId { get; set; }

    [Column("source_transaction_id")]
    public Guid? SourceTransactionId { get; set; }

    [Column("callback_model_id")]
    public Guid? CallbackModelId { get; set; }

    [Column("callback_res_id")]
    public Guid? CallbackResId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("partner_state_id")]
    public long? PartnerStateId { get; set; }

    [Column("partner_country_id")]
    public long? PartnerCountryId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("reference")]
    public string? Reference { get; set; }

    [Column("provider_reference")]
    public string? ProviderReference { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("operation")]
    public string? Operation { get; set; }

    [Column("landing_route")]
    public string? LandingRoute { get; set; }

    [Column("callback_method")]
    public string? CallbackMethod { get; set; }

    [Column("callback_hash")]
    public string? CallbackHash { get; set; }

    [Column("partner_name")]
    public string? PartnerName { get; set; }

    [Column("partner_lang")]
    public string? PartnerLang { get; set; }

    [Column("partner_email")]
    public string? PartnerEmail { get; set; }

    [Column("partner_address")]
    public string? PartnerAddress { get; set; }

    [Column("partner_zip")]
    public string? PartnerZip { get; set; }

    [Column("partner_city")]
    public string? PartnerCity { get; set; }

    [Column("partner_phone")]
    public string? PartnerPhone { get; set; }

    [Column("state_message")]
    public string? StateMessage { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("fees")]
    public decimal? Fees { get; set; }

    [Column("is_post_processed")]
    public bool? IsPostProcessed { get; set; }

    [Column("tokenize")]
    public bool? Tokenize { get; set; }

    [Column("callback_is_done")]
    public bool? CallbackIsDone { get; set; }

    [Column("last_state_change", TypeName = "timestamp without time zone")]
    public DateTime? LastStateChange { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("payment_id")]
    public Guid? PaymentId { get; set; }

    [Column("is_donation")]
    public bool? IsDonation { get; set; }

    [InverseProperty("PaymentTransaction")]
    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    [ForeignKey("CallbackModelId")]
    [InverseProperty("PaymentTransactions")]
    public virtual IrModel? CallbackModel { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("PaymentTransactions")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PaymentTransactionCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("SourceTransaction")]
    public virtual ICollection<PaymentTransaction> InverseSourceTransaction { get; } = new List<PaymentTransaction>();

    [ForeignKey("PartnerId")]
    [InverseProperty("PaymentTransactions")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PaymentId")]
    [InverseProperty("PaymentTransactions")]
    public virtual AccountPayment? Payment { get; set; }

    [ForeignKey("ProviderId")]
    [InverseProperty("PaymentTransactions")]
    public virtual PaymentProvider? Provider { get; set; }

    [ForeignKey("SourceTransactionId")]
    [InverseProperty("InverseSourceTransaction")]
    public virtual PaymentTransaction? SourceTransaction { get; set; }

    [ForeignKey("TokenId")]
    [InverseProperty("PaymentTransactions")]
    public virtual PaymentToken? Token { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("PaymentTransactionWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("TransactionId")]
    [InverseProperty("Transactions")]
    public virtual ICollection<AccountMove> Invoices { get; } = new List<AccountMove>();

    [ForeignKey("TransactionId")]
    [InverseProperty("Transactions")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();
}
