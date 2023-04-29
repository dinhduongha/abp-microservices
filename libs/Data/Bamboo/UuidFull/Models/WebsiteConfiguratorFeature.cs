using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class WebsiteConfiguratorFeature
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? PageViewId { get; set; }

    public Guid? ModuleId { get; set; }

    public long? MenuSequence { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Icon { get; set; }

    public string? IapPageCode { get; set; }

    public string? WebsiteConfigPreselection { get; set; }

    public string? FeatureUrl { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public bool? MenuCompany { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModuleModule? Module { get; set; }

    public virtual IrUiView? PageView { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
