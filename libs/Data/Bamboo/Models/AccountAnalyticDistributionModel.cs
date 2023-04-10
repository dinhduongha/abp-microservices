using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountAnalyticDistributionModel
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public long? PartnerCategoryId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? AnalyticDistribution { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? ProductId { get; set; }

    public long? ProductCategId { get; set; }

    public string? AccountPrefix { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartnerCategory? PartnerCategory { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductCategory? ProductCateg { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
