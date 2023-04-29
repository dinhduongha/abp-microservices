﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_module_module")]
[Index("CategoryId", Name = "ir_module_module_category_id_index")]
[Index("Name", Name = "ir_module_module_name_uniq", IsUnique = true)]
[Index("State", Name = "ir_module_module_state_index")]
public partial class IrModuleModule
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("website")]
    public string? Website { get; set; }

    [Column("summary", TypeName = "jsonb")]
    public string? Summary { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("author")]
    public string? Author { get; set; }

    [Column("icon")]
    public string? Icon { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("latest_version")]
    public string? LatestVersion { get; set; }

    [Column("shortdesc", TypeName = "jsonb")]
    public string? Shortdesc { get; set; }

    [Column("category_id")]
    public Guid? CategoryId { get; set; }

    [Column("description", TypeName = "jsonb")]
    public string? Description { get; set; }

    [Column("application")]
    public bool? Application { get; set; }

    [Column("demo")]
    public bool? Demo { get; set; }

    [Column("web")]
    public bool? Web { get; set; }

    [Column("license")]
    public string? License { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("auto_install")]
    public bool? AutoInstall { get; set; }

    [Column("to_buy")]
    public bool? ToBuy { get; set; }

    [Column("maintainer")]
    public string? Maintainer { get; set; }

    [Column("published_version")]
    public string? PublishedVersion { get; set; }

    [Column("url")]
    public string? Url { get; set; }

    [Column("contributors")]
    public string? Contributors { get; set; }

    [Column("menus_by_module")]
    public string? MenusByModule { get; set; }

    [Column("reports_by_module")]
    public string? ReportsByModule { get; set; }

    [Column("views_by_module")]
    public string? ViewsByModule { get; set; }

    [InverseProperty("Module")]
    public virtual ICollection<BaseModuleInstallRequest> BaseModuleInstallRequests { get; } = new List<BaseModuleInstallRequest>();

    [InverseProperty("Module")]
    public virtual ICollection<BaseModuleInstallReview> BaseModuleInstallReviews { get; } = new List<BaseModuleInstallReview>();

    [InverseProperty("Module")]
    public virtual ICollection<BaseModuleUninstall> BaseModuleUninstalls { get; } = new List<BaseModuleUninstall>();

    [ForeignKey("CategoryId")]
    [InverseProperty("IrModuleModules")]
    public virtual IrModuleCategory? Category { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrModuleModuleCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Module")]
    public virtual ICollection<IrDemoFailure> IrDemoFailures { get; } = new List<IrDemoFailure>();

    [InverseProperty("ModuleNavigation")]
    public virtual ICollection<IrModelConstraint> IrModelConstraints { get; } = new List<IrModelConstraint>();

    [InverseProperty("ModuleNavigation")]
    public virtual ICollection<IrModelRelation> IrModelRelations { get; } = new List<IrModelRelation>();

    [InverseProperty("Module")]
    public virtual ICollection<IrModuleModuleDependency> IrModuleModuleDependencies { get; } = new List<IrModuleModuleDependency>();

    [InverseProperty("Module")]
    public virtual ICollection<IrModuleModuleExclusion> IrModuleModuleExclusions { get; } = new List<IrModuleModuleExclusion>();

    [InverseProperty("Module")]
    public virtual ICollection<PaymentProvider> PaymentProviders { get; } = new List<PaymentProvider>();

    [InverseProperty("Module")]
    public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatures { get; } = new List<WebsiteConfiguratorFeature>();

    [InverseProperty("Theme")]
    public virtual ICollection<Website> Websites { get; } = new List<Website>();

    [ForeignKey("WriteUid")]
    [InverseProperty("IrModuleModuleWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("Modules")]
    public virtual ICollection<BaseLanguageExport> Wizs { get; } = new List<BaseLanguageExport>();
}
