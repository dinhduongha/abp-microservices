using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAnalyticDistributionModel
{
    public Guid Id { get; set; }

    public Guid? PartnerId { get; set; }

    public long? PartnerCategoryId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? AnalyticDistribution { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? ProductId { get; set; }

    public long? ProductCategId { get; set; }

    public string? AccountPrefix { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
