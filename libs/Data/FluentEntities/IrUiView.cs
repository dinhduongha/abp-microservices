using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class IrUiView
{
    public Guid Id { get; set; }

    public long? Priority { get; set; }

    public Guid? InheritId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Model { get; set; }

    public string? Key { get; set; }

    public string? Type { get; set; }

    public string? ArchFs { get; set; }

    public string? FieldParent { get; set; }

    public string? Mode { get; set; }

    public string? ArchDb { get; set; }

    public string? ArchPrev { get; set; }

    public bool? ArchUpdated { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public bool? CustomizeShow { get; set; }

    public Guid? WebsiteId { get; set; }

    public long? ThemeTemplateId { get; set; }

    public string? WebsiteMetaOgImg { get; set; }

    public string? Visibility { get; set; }

    public string? VisibilityPassword { get; set; }

    public string? WebsiteMetaTitle { get; set; }

    public string? WebsiteMetaDescription { get; set; }

    public string? WebsiteMetaKeywords { get; set; }

    public string? SeoName { get; set; }

    public bool? Track { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? Inherit { get; set; }

    //public virtual ICollection<IrUiView> InverseInherit { get; } = new List<IrUiView>();

    //public virtual ICollection<IrActWindow> IrActWindowSearchViews { get; } = new List<IrActWindow>();

    //public virtual ICollection<IrActWindow> IrActWindowViews { get; } = new List<IrActWindow>();

    //public virtual ICollection<IrActWindowView> IrActWindowViewsNavigation { get; } = new List<IrActWindowView>();

    //public virtual ICollection<IrUiViewCustom> IrUiViewCustoms { get; } = new List<IrUiViewCustom>();

    //public virtual ICollection<PaymentProvider> PaymentProviderExpressCheckoutFormViews { get; } = new List<PaymentProvider>();

    //public virtual ICollection<PaymentProvider> PaymentProviderInlineFormViews { get; } = new List<PaymentProvider>();

    //public virtual ICollection<PaymentProvider> PaymentProviderRedirectFormViews { get; } = new List<PaymentProvider>();

    //public virtual ICollection<PaymentProvider> PaymentProviderTokenInlineFormViews { get; } = new List<PaymentProvider>();

    //public virtual ICollection<ReportLayout> ReportLayouts { get; } = new List<ReportLayout>();

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    //public virtual ICollection<ResCountry> ResCountries { get; } = new List<ResCountry>();

    //public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardCompareViews { get; } = new List<ResetViewArchWizard>();

    //public virtual ICollection<ResetViewArchWizard> ResetViewArchWizardViews { get; } = new List<ResetViewArchWizard>();

    public virtual ThemeIrUiView? ThemeTemplate { get; set; }

    public virtual Website? Website { get; set; }

    //public virtual ICollection<WebsiteConfiguratorFeature> WebsiteConfiguratorFeatures { get; } = new List<WebsiteConfiguratorFeature>();

    //public virtual ICollection<WebsitePage> WebsitePages { get; } = new List<WebsitePage>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResGroup> Groups { get; } = new List<ResGroup>();
}
