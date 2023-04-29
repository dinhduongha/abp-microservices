using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("website_configurator_feature")]
public partial class WebsiteConfiguratorFeature
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("page_view_id")]
    public Guid? PageViewId { get; set; }

    [Column("module_id")]
    public Guid? ModuleId { get; set; }

    [Column("menu_sequence")]
    public long? MenuSequence { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("icon")]
    public string? Icon { get; set; }

    [Column("iap_page_code")]
    public string? IapPageCode { get; set; }

    [Column("website_config_preselection")]
    public string? WebsiteConfigPreselection { get; set; }

    [Column("feature_url")]
    public string? FeatureUrl { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("description", TypeName = "jsonb")]
    public string? Description { get; set; }

    [Column("menu_company")]
    public bool? MenuCompany { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("WebsiteConfiguratorFeatureCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("WebsiteConfiguratorFeatures")]
    public virtual IrModuleModule? Module { get; set; }

    [ForeignKey("PageViewId")]
    [InverseProperty("WebsiteConfiguratorFeatures")]
    public virtual IrUiView? PageView { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("WebsiteConfiguratorFeatureWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
