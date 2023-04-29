using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class IrModuleModule
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Website { get; set; }

    public string? Summary { get; set; }

    public string? Name { get; set; }

    public string? Author { get; set; }

    public string? Icon { get; set; }

    public string? State { get; set; }

    public string? LatestVersion { get; set; }

    public string? Shortdesc { get; set; }

    public Guid? CategoryId { get; set; }

    public string? Description { get; set; }

    public bool? Application { get; set; }

    public bool? Demo { get; set; }

    public bool? Web { get; set; }

    public string? License { get; set; }

    public long Sequence { get; set; }

    public bool? AutoInstall { get; set; }

    public bool? ToBuy { get; set; }

    public string? Maintainer { get; set; }

    public string? PublishedVersion { get; set; }

    public string? Url { get; set; }

    public string? Contributors { get; set; }

    public string? MenusByModule { get; set; }

    public string? ReportsByModule { get; set; }

    public string? ViewsByModule { get; set; }

    public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequests { get; } = new List<BaseModuleInstallRequest>();

    public virtual ICollection<BaseModuleInstallReview> BaseModuleInstallReviews { get; } = new List<BaseModuleInstallReview>();

    public virtual ICollection<BaseModuleUninstall> BaseModuleUninstalls { get; } = new List<BaseModuleUninstall>();

    public virtual IrModuleCategory? Category { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrDemoFailure> IrDemoFailures { get; } = new List<IrDemoFailure>();

    public virtual ICollection<IrModelConstraint> IrModelConstraints { get; } = new List<IrModelConstraint>();

    public virtual ICollection<IrModelRelation> IrModelRelations { get; } = new List<IrModelRelation>();

    public virtual ICollection<IrModuleModuleDependency> IrModuleModuleDependencies { get; } = new List<IrModuleModuleDependency>();

    public virtual ICollection<IrModuleModuleExclusion> IrModuleModuleExclusions { get; } = new List<IrModuleModuleExclusion>();

    public virtual ICollection<PaymentProvider> PaymentProviders { get; } = new List<PaymentProvider>();

    public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatures { get; } = new List<WebsiteConfiguratorFeature>();

    public virtual ICollection<Website> Websites { get; } = new List<Website>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<BaseLanguageExport> Wizs { get; } = new List<BaseLanguageExport>();
}
