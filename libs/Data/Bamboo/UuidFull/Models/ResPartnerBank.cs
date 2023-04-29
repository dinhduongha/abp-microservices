using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResPartnerBank
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? BankId { get; set; }

    public long Sequence { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? AccNumber { get; set; }

    public string? SanitizedAccNumber { get; set; }

    public string? AccHolderName { get; set; }

    public bool? Active { get; set; }

    public bool? AllowOutPayment { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPayment> AccountPayments { get; } = new List<AccountPayment>();

    public virtual ICollection<AccountSetupBankManualConfig> AccountSetupBankManualConfigs { get; } = new List<AccountSetupBankManualConfig>();

    public virtual ResBank? Bank { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
