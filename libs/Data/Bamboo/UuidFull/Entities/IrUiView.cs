using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_ui_view")]
[Index("InheritId", Name = "ir_ui_view_inherit_id_index")]
[Index("Model", Name = "ir_ui_view_model_index")]
[Index("Model", "InheritId", Name = "ir_ui_view_model_type_inherit_id")]
public partial class IrUiView
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("priority")]
    public long? Priority { get; set; }

    [Column("inherit_id")]
    public Guid? InheritId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("model")]
    public string? Model { get; set; }

    [Column("key")]
    public string? Key { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("arch_fs")]
    public string? ArchFs { get; set; }

    [Column("field_parent")]
    public string? FieldParent { get; set; }

    [Column("mode")]
    public string? Mode { get; set; }

    [Column("arch_db", TypeName = "jsonb")]
    public string? ArchDb { get; set; }

    [Column("arch_prev")]
    public string? ArchPrev { get; set; }

    [Column("arch_updated")]
    public bool? ArchUpdated { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("customize_show")]
    public bool? CustomizeShow { get; set; }

    [Column("website_id")]
    public Guid? WebsiteId { get; set; }

    [Column("theme_template_id")]
    public long? ThemeTemplateId { get; set; }

    [Column("website_meta_og_img")]
    public string? WebsiteMetaOgImg { get; set; }

    [Column("visibility")]
    public string? Visibility { get; set; }

    [Column("visibility_password")]
    public string? VisibilityPassword { get; set; }

    [Column("website_meta_title", TypeName = "jsonb")]
    public string? WebsiteMetaTitle { get; set; }

    [Column("website_meta_description", TypeName = "jsonb")]
    public string? WebsiteMetaDescription { get; set; }

    [Column("website_meta_keywords", TypeName = "jsonb")]
    public string? WebsiteMetaKeywords { get; set; }

    [Column("seo_name", TypeName = "jsonb")]
    public string? SeoName { get; set; }

    [Column("track")]
    public bool? Track { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrUiViewCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("InheritId")]
    [InverseProperty("InverseInherit")]
    public virtual IrUiView? Inherit { get; set; }

    [InverseProperty("Inherit")]
    public virtual ICollection<IrUiView> InverseInherit { get; } = new List<IrUiView>();

    [InverseProperty("SearchView")]
    public virtual ICollection<IrActWindow> IrActWindowSearchViews { get; } = new List<IrActWindow>();

    [InverseProperty("View")]
    public virtual ICollection<IrActWindow> IrActWindowViews { get; } = new List<IrActWindow>();

    [InverseProperty("View")]
    public virtual ICollection<IrActWindowView> IrActWindowViewsNavigation { get; } = new List<IrActWindowView>();

    [InverseProperty("Ref")]
    public virtual ICollection<IrUiViewCustom> IrUiViewCustoms { get; } = new List<IrUiViewCustom>();

    [InverseProperty("ExpressCheckoutFormView")]
    public virtual ICollection<PaymentProvider> PaymentProviderExpressCheckoutFormViews { get; } = new List<PaymentProvider>();

    [InverseProperty("InlineFormView")]
    public virtual ICollection<PaymentProvider> PaymentProviderInlineFormViews { get; } = new List<PaymentProvider>();

    [InverseProperty("RedirectFormView")]
    public virtual ICollection<PaymentProvider> PaymentProviderRedirectFormViews { get; } = new List<PaymentProvider>();

    [InverseProperty("TokenInlineFormView")]
    public virtual ICollection<PaymentProvider> PaymentProviderTokenInlineFormViews { get; } = new List<PaymentProvider>();

    [InverseProperty("View")]
    public virtual ICollection<ReportLayout> ReportLayouts { get; } = new List<ReportLayout>();

    [InverseProperty("ExternalReportLayout")]
    public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    [InverseProperty("AddressView")]
    public virtual ICollection<ResCountry> ResCountries { get; } = new List<ResCountry>();

    [InverseProperty("CompareView")]
    public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardCompareViews { get; } = new List<ResetViewArchWizard>();

    [InverseProperty("View")]
    public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardViews { get; } = new List<ResetViewArchWizard>();

    [ForeignKey("WebsiteId")]
    [InverseProperty("IrUiViews")]
    public virtual Website? Website { get; set; }

    [InverseProperty("PageView")]
    public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatures { get; } = new List<WebsiteConfiguratorFeature>();

    [InverseProperty("View")]
    public virtual ICollection<WebsitePage> WebsitePages { get; } = new List<WebsitePage>();

    [ForeignKey("WriteUid")]
    [InverseProperty("IrUiViewWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ViewId")]
    [InverseProperty("Views")]
    public virtual ICollection<ResGroup> Groups { get; } = new List<ResGroup>();
}
