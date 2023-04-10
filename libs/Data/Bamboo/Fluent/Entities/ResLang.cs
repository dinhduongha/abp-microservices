using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResLang
{
    public long Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? IsoCode { get; set; }

    public string? UrlCode { get; set; }

    public string? Direction { get; set; }

    public string? DateFormat { get; set; }

    public string? TimeFormat { get; set; }

    public string? WeekStart { get; set; }

    public string? Grouping { get; set; }

    public string? DecimalPoint { get; set; }

    public string? ThousandsSep { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    //public virtual ICollection<WebsiteVisitor> WebsiteVisitors { get; } = new List<WebsiteVisitor>();

    //public virtual ICollection<Website> Websites { get; } = new List<Website>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<BaseLanguageInstall> LanguageWizards { get; } = new List<BaseLanguageInstall>();

    //public virtual ICollection<Website> WebsitesNavigation { get; } = new List<Website>();
}
