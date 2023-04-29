using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectProject
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? AliasId { get; set; }

    public long Sequence { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? AnalyticAccountId { get; set; }

    public long? Color { get; set; }

    public Guid? UserId { get; set; }

    public long? StageId { get; set; }

    public Guid? LastUpdateId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? AccessToken { get; set; }

    public string? PartnerEmail { get; set; }

    public string? PartnerPhone { get; set; }

    public string? PrivacyVisibility { get; set; }

    public string? RatingStatus { get; set; }

    public string? RatingStatusPeriod { get; set; }

    public string? LastUpdateStatus { get; set; }

    public DateOnly? DateStart { get; set; }

    public DateOnly? Date { get; set; }

    public string? Name { get; set; }

    public string? LabelTasks { get; set; }

    public string? TaskPropertiesDefinition { get; set; }

    public string? Description { get; set; }

    public bool? Active { get; set; }

    public bool? AllowSubtasks { get; set; }

    public bool? AllowRecurringTasks { get; set; }

    public bool? AllowTaskDependencies { get; set; }

    public bool? AllowMilestones { get; set; }

    public bool? RatingActive { get; set; }

    public DateTime? RatingRequestDeadline { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? SaleLineId { get; set; }

    public bool? AllowBillable { get; set; }

    public virtual MailAlias? Alias { get; set; }

    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProjectUpdate? LastUpdate { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ICollection<ProjectCollaborator> ProjectCollaborators { get; } = new List<ProjectCollaborator>();

    public virtual ICollection<ProjectMilestone> ProjectMilestones { get; } = new List<ProjectMilestone>();

    public virtual ICollection<ProjectProjectProjectTagsRel> ProjectProjectProjectTagsRels { get; } = new List<ProjectProjectProjectTagsRel>();

    public virtual ICollection<ProjectTask> ProjectTaskDisplayProjects { get; } = new List<ProjectTask>();

    public virtual ICollection<ProjectTask> ProjectTaskProjects { get; } = new List<ProjectTask>();

    public virtual ICollection<ProjectTaskTypeRel> ProjectTaskTypeRels { get; } = new List<ProjectTaskTypeRel>();

    public virtual ICollection<ProjectUpdate> ProjectUpdates { get; } = new List<ProjectUpdate>();

    public virtual SaleOrderLine? SaleLine { get; set; }

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProjectTaskTypeDeleteWizard> ProjectTaskTypeDeleteWizards { get; } = new List<ProjectTaskTypeDeleteWizard>();

    public virtual ICollection<ResUser> Users { get; } = new List<ResUser>();
}
