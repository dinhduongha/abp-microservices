using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAssetCategory
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? AccountAnalyticId { get; set; }

    public Guid? AccountAssetId { get; set; }

    public Guid? AccountDepreciationId { get; set; }

    public Guid? AccountDepreciationExpenseId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? CompanyId { get; set; }

    public long? MethodNumber { get; set; }

    public long? MethodPeriod { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Method { get; set; }

    public string? MethodTime { get; set; }

    public string? Type { get; set; }

    public string? DateFirstDepreciation { get; set; }

    public DateOnly? MethodEnd { get; set; }

    public string? AnalyticDistribution { get; set; }

    public bool? Active { get; set; }

    public bool? Prorata { get; set; }

    public bool? OpenAsset { get; set; }

    public bool? GroupEntries { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? MethodProgressFactor { get; set; }

    public virtual AccountAnalyticAccount? AccountAnalytic { get; set; }

    public virtual AccountAccount? AccountAsset { get; set; }

    public virtual ICollection<AccountAssetAsset> AccountAssetAssets { get; } = new List<AccountAssetAsset>();

    public virtual AccountAccount? AccountDepreciation { get; set; }

    public virtual AccountAccount? AccountDepreciationExpense { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
