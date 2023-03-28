using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResPartnerCategory
{
    public long Id { get; set; }

    public long? Color { get; set; }

    public long? ParentId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? ParentPath { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; } = new List<AccountAnalyticDistributionModel>();

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ResPartnerCategory> InverseParent { get; } = new List<ResPartnerCategory>();

    public virtual ResPartnerCategory? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; } = new List<AccountReconcileModelTemplate>();

    //public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; } = new List<AccountReconcileModel>();

    //public virtual ICollection<ResPartner> Partners { get; } = new List<ResPartner>();
}
