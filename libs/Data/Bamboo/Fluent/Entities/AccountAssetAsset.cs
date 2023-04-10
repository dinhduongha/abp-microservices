using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountAssetAsset
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CategoryId { get; set; }

    public Guid? PartnerId { get; set; }

    public long? MethodNumber { get; set; }

    public long? MethodPeriod { get; set; }

    public Guid? InvoiceId { get; set; }

    public Guid? AccountAnalyticId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? State { get; set; }

    public string? Method { get; set; }

    public string? MethodTime { get; set; }

    public string? DateFirstDepreciation { get; set; }

    public DateOnly? Date { get; set; }

    public DateOnly? MethodEnd { get; set; }

    public DateOnly? FirstDepreciationManualDate { get; set; }

    public string? AnalyticDistribution { get; set; }

    public string? Note { get; set; }

    public decimal? Value { get; set; }

    public decimal? SalvageValue { get; set; }

    public bool? Active { get; set; }

    public bool? Prorata { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? MethodProgressFactor { get; set; }

    public virtual AccountAnalyticAccount? AccountAnalytic { get; set; }

    //public virtual ICollection<AccountAssetDepreciationLine> AccountAssetDepreciationLines { get; } = new List<AccountAssetDepreciationLine>();

    public virtual AccountAssetCategory? Category { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountMove? Invoice { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
