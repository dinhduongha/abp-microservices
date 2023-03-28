using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class Website
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? TenantId { get; set; }

    public long? DefaultLangId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ThemeId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Domain { get; set; }

    public string? SocialTwitter { get; set; }

    public string? SocialFacebook { get; set; }

    public string? SocialGithub { get; set; }

    public string? SocialLinkedin { get; set; }

    public string? SocialYoutube { get; set; }

    public string? SocialInstagram { get; set; }

    public string? GoogleAnalyticsKey { get; set; }

    public string? GoogleSearchConsole { get; set; }

    public string? GoogleMapsApiKey { get; set; }

    public string? PlausibleSharedKey { get; set; }

    public string? PlausibleSite { get; set; }

    public string? CdnUrl { get; set; }

    public string? HomepageUrl { get; set; }

    public string? AuthSignupUninvited { get; set; }

    public string? CdnFilters { get; set; }

    public string? CustomCodeHead { get; set; }

    public string? CustomCodeFooter { get; set; }

    public string? RobotsTxt { get; set; }

    public bool? AutoRedirectLang { get; set; }

    public bool? CookiesBar { get; set; }

    public bool? ConfiguratorDone { get; set; }

    public bool? HasSocialDefaultImage { get; set; }

    public bool? CdnActivated { get; set; }

    public bool? SpecificUserAccount { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public Guid? CrmDefaultTeamId { get; set; }

    public Guid? CrmDefaultUserId { get; set; }

    public Guid? SalespersonId { get; set; }

    public Guid? SalesteamId { get; set; }

    public Guid? CartRecoveryMailTemplateId { get; set; }

    public long? ShopPpg { get; set; }

    public long? ShopPpr { get; set; }

    public long? ProductPageGridColumns { get; set; }

    public string? ShopDefaultSort { get; set; }

    public string? AddToCartAction { get; set; }

    public string? AccountOnCheckout { get; set; }

    public string? ProductPageImageLayout { get; set; }

    public string? ProductPageImageWidth { get; set; }

    public string? ProductPageImageSpacing { get; set; }

    public string? PreventZeroPriceSaleText { get; set; }

    public string? ContactUsButtonUrl { get; set; }

    public bool? SendAbandonedCartEmail { get; set; }

    public bool? PreventZeroPriceSale { get; set; }

    public bool? EnabledPortalReorderButton { get; set; }

    public double? CartAbandonedDelay { get; set; }

    public Guid? WarehouseId { get; set; }

    //public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual MailTemplate? CartRecoveryMailTemplate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? CrmDefaultTeam { get; set; }

    public virtual ResUser? CrmDefaultUser { get; set; }

    public virtual ResLang? DefaultLang { get; set; }

    //public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    //public virtual ICollection<IrAsset> IrAssets { get; } = new List<IrAsset>();

    //public virtual ICollection<IrAttachment> IrAttachments { get; } = new List<IrAttachment>();

    //public virtual ICollection<IrUiView> IrUiViews { get; } = new List<IrUiView>();

    //public virtual ICollection<PaymentProvider> PaymentProviders { get; } = new List<PaymentProvider>();

    //public virtual ICollection<ProductPricelist> ProductPricelists { get; } = new List<ProductPricelist>();

    //public virtual ICollection<ProductPublicCategory> ProductPublicCategories { get; } = new List<ProductPublicCategory>();

    //public virtual ICollection<ProductTag> ProductTags { get; } = new List<ProductTag>();

    //public virtual ICollection<ProductTemplate> ProductTemplates { get; } = new List<ProductTemplate>();

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    //public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    //public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();

    //public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? Salesperson { get; set; }

    public virtual CrmTeam? Salesteam { get; set; }

    //public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    public virtual IrModuleModule? Theme { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual StockWarehouse? Warehouse { get; set; }

    //public virtual ICollection<WebsiteMenu> WebsiteMenus { get; } = new List<WebsiteMenu>();

    //public virtual ICollection<WebsitePage> WebsitePages { get; } = new List<WebsitePage>();

    //public virtual ICollection<WebsiteRewrite> WebsiteRewrites { get; } = new List<WebsiteRewrite>();

    //public virtual ICollection<WebsiteSaleExtraField> WebsiteSaleExtraFields { get; } = new List<WebsiteSaleExtraField>();

    //public virtual ICollection<WebsiteSnippetFilter> WebsiteSnippetFilters { get; } = new List<WebsiteSnippetFilter>();

    //public virtual ICollection<WebsiteVisitor> WebsiteVisitors { get; } = new List<WebsiteVisitor>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<BaseLanguageInstall> BaseLanguageInstalls { get; } = new List<BaseLanguageInstall>();

    //public virtual ICollection<ResLang> Langs { get; } = new List<ResLang>();
}
