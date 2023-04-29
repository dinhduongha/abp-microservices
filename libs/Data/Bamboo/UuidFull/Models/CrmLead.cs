using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class CrmLead
{
    public Guid Id { get; set; }

    public Guid? CampaignId { get; set; }

    public Guid? SourceId { get; set; }

    public Guid? MediumId { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long? MessageBounce { get; set; }

    public Guid? UserId { get; set; }

    public Guid? TeamId { get; set; }

    public Guid? CompanyId { get; set; }

    public long? StageId { get; set; }

    public long? Color { get; set; }

    public Guid? RecurringPlan { get; set; }

    public Guid? PartnerId { get; set; }

    public long? Title { get; set; }

    public long? LangId { get; set; }

    public long? StateId { get; set; }

    public long? CountryId { get; set; }

    public long? LostReasonId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? PhoneSanitized { get; set; }

    public string? EmailNormalized { get; set; }

    public string? EmailCc { get; set; }

    public string? Name { get; set; }

    public string? Referred { get; set; }

    public string? Type { get; set; }

    public string? Priority { get; set; }

    public string? ContactName { get; set; }

    public string? PartnerName { get; set; }

    public string? Function { get; set; }

    public string? EmailFrom { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? PhoneState { get; set; }

    public string? EmailState { get; set; }

    public string? Website { get; set; }

    public string? Street { get; set; }

    public string? Street2 { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public DateOnly? DateDeadline { get; set; }

    public string? LeadProperties { get; set; }

    public string? Description { get; set; }

    public decimal? ExpectedRevenue { get; set; }

    public decimal? ProratedRevenue { get; set; }

    public decimal? RecurringRevenue { get; set; }

    public decimal? RecurringRevenueMonthly { get; set; }

    public decimal? RecurringRevenueMonthlyProrated { get; set; }

    public bool? Active { get; set; }

    public DateTime? DateClosed { get; set; }

    public DateTime? DateActionLast { get; set; }

    public DateTime? DateOpen { get; set; }

    public DateTime? DateLastStageUpdate { get; set; }

    public DateTime? DateConversion { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? DayOpen { get; set; }

    public double? DayClose { get; set; }

    public double? Probability { get; set; }

    public double? AutomatedProbability { get; set; }

    public string? RevealId { get; set; }

    public bool? IapEnrichDone { get; set; }

    public Guid? LeadMiningRequestId { get; set; }

    public virtual ICollection<CalendarEvent> CalendarEvents { get; } = new List<CalendarEvent>();

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMassesNavigation { get; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartners { get; } = new List<CrmLead2opportunityPartner>();

    public virtual ICollection<CrmQuotationPartner> CrmQuotationPartners { get; } = new List<CrmQuotationPartner>();

    public virtual ICollection<CrmTagRel> CrmTagRels { get; } = new List<CrmTagRel>();

    public virtual CrmIapLeadMiningRequest? LeadMiningRequest { get; set; }

    public virtual UtmMedium? Medium { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual CrmRecurringPlan? RecurringPlanNavigation { get; set; }

    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual UtmSource? Source { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses { get; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses1 { get; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartnersNavigation { get; } = new List<CrmLead2opportunityPartner>();

    public virtual ICollection<CrmMergeOpportunity> Merges { get; } = new List<CrmMergeOpportunity>();

    public virtual ICollection<WebsiteVisitor> WebsiteVisitors { get; } = new List<WebsiteVisitor>();
}
