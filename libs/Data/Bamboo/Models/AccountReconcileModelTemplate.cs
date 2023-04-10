using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountReconcileModelTemplate
{
    public Guid Id { get; set; }

    public Guid? ChartTemplateId { get; set; }

    public long Sequence { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? RuleType { get; set; }

    public string? MatchingOrder { get; set; }

    public string? MatchNature { get; set; }

    public string? MatchAmount { get; set; }

    public string? MatchLabel { get; set; }

    public string? MatchLabelParam { get; set; }

    public string? MatchNote { get; set; }

    public string? MatchNoteParam { get; set; }

    public string? MatchTransactionType { get; set; }

    public string? MatchTransactionTypeParam { get; set; }

    public string? PaymentToleranceType { get; set; }

    public string? DecimalSeparator { get; set; }

    public bool? AutoReconcile { get; set; }

    public bool? ToCheck { get; set; }

    public bool? MatchTextLocationLabel { get; set; }

    public bool? MatchTextLocationNote { get; set; }

    public bool? MatchTextLocationReference { get; set; }

    public bool? MatchSameCurrency { get; set; }

    public bool? AllowPaymentTolerance { get; set; }

    public bool? MatchPartner { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? MatchAmountMin { get; set; }

    public double? MatchAmountMax { get; set; }

    public double? PaymentToleranceParam { get; set; }

    //public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplates { get; } = new List<AccountReconcileModelLineTemplate>();

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    //public virtual ICollection<ResPartnerCategory> ResPartnerCategories { get; } = new List<ResPartnerCategory>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
