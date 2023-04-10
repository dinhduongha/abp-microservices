using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountGroupTemplate
{
    public Guid Id { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? ChartTemplateId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? CodePrefixStart { get; set; }

    public string? CodePrefixEnd { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<AccountGroupTemplate> InverseParent { get; } = new List<AccountGroupTemplate>();

    public virtual AccountGroupTemplate? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
