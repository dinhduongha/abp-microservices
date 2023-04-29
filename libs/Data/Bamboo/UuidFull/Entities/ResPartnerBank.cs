using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("res_partner_bank")]
[Index("PartnerId", Name = "res_partner_bank_partner_id_index")]
[Index("SanitizedAccNumber", "PartnerId", Name = "res_partner_bank_unique_number", IsUnique = true)]
public partial class ResPartnerBank
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("bank_id")]
    public Guid? BankId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("acc_number")]
    public string? AccNumber { get; set; }

    [Column("sanitized_acc_number")]
    public string? SanitizedAccNumber { get; set; }

    [Column("acc_holder_name")]
    public string? AccHolderName { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("allow_out_payment")]
    public bool? AllowOutPayment { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [InverseProperty("BankAccount")]
    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    [InverseProperty("PartnerBank")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    [InverseProperty("PartnerBank")]
    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    [InverseProperty("PartnerBank")]
    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    [InverseProperty("ResPartnerBank")]
    public virtual ICollection<AccountSetupBankManualConfig> AccountSetupBankManualConfigs { get; } = new List<AccountSetupBankManualConfig>();

    [ForeignKey("BankId")]
    [InverseProperty("ResPartnerBanks")]
    public virtual ResBank? Bank { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ResPartnerBanks")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResPartnerBankCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("BankAccount")]
    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("ResPartnerBanks")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("ResPartnerBanks")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ResPartnerBankWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
