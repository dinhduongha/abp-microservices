using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ProjectTask
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public long Sequence { get; set; }

    public long? StageId { get; set; }

    public Guid? ProjectId { get; set; }

    public Guid? DisplayProjectId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? CompanyId { get; set; }

    public long? Color { get; set; }

    public Guid? DisplayedImageId { get; set; }

    public Guid? ParentId { get; set; }

    public Guid? AncestorId { get; set; }

    public Guid? MilestoneId { get; set; }

    public Guid? RecurrenceId { get; set; }

    public Guid? AnalyticAccountId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? EmailCc { get; set; }

    public string? AccessToken { get; set; }

    public string? Name { get; set; }

    public string? Priority { get; set; }

    public string? KanbanState { get; set; }

    public string? PartnerEmail { get; set; }

    public string? PartnerPhone { get; set; }

    public string? EmailFrom { get; set; }

    public DateOnly? DateDeadline { get; set; }

    public string? TaskProperties { get; set; }

    public string? Description { get; set; }

    public decimal? WorkingHoursOpen { get; set; }

    public decimal? WorkingHoursClose { get; set; }

    public bool? Active { get; set; }

    public bool? IsClosed { get; set; }

    public bool? IsBlocked { get; set; }

    public bool? RecurringTask { get; set; }

    public bool? IsAnalyticAccountIdChanged { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public DateTime? DateEnd { get; set; }

    public DateTime? DateAssign { get; set; }

    public DateTime? DateLastStageUpdate { get; set; }

    public double? RatingLastValue { get; set; }

    public double? PlannedHours { get; set; }

    public double? WorkingDaysOpen { get; set; }

    public double? WorkingDaysClose { get; set; }

    public Guid? SaleOrderId { get; set; }

    public Guid? SaleLineId { get; set; }

    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    public virtual ProjectTask? Ancestor { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProjectProject? DisplayProject { get; set; }

    public virtual IrAttachment? DisplayedImage { get; set; }

    public virtual ICollection<ProjectTask> InverseAncestor { get; } = new List<ProjectTask>();

    public virtual ICollection<ProjectTask> InverseParent { get; } = new List<ProjectTask>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ProjectMilestone? Milestone { get; set; }

    public virtual ProjectTask? Parent { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ProjectProject? Project { get; set; }

    public virtual ICollection<ProjectTagsProjectTaskRel> ProjectTagsProjectTaskRels { get; } = new List<ProjectTagsProjectTaskRel>();

    public virtual ICollection<ProjectTaskUserRel> ProjectTaskUserRels { get; } = new List<ProjectTaskUserRel>();

    public virtual ProjectTaskRecurrence? Recurrence { get; set; }

    public virtual SaleOrderLine? SaleLine { get; set; }

    public virtual SaleOrder? SaleOrder { get; set; }

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ProjectTask> DependsOns { get; } = new List<ProjectTask>();

    public virtual ICollection<ProjectTask> Tasks { get; } = new List<ProjectTask>();
}
