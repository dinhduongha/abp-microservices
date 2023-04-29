using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("project_project")]
[Index("Date", Name = "project_project_date_index")]
[Index("StageId", Name = "project_project_stage_id_index")]
public partial class ProjectProject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("alias_id")]
    public Guid? AliasId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("analytic_account_id")]
    public Guid? AnalyticAccountId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("stage_id")]
    public long? StageId { get; set; }

    [Column("last_update_id")]
    public Guid? LastUpdateId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("access_token")]
    public string? AccessToken { get; set; }

    [Column("partner_email")]
    public string? PartnerEmail { get; set; }

    [Column("partner_phone")]
    public string? PartnerPhone { get; set; }

    [Column("privacy_visibility")]
    public string? PrivacyVisibility { get; set; }

    [Column("rating_status")]
    public string? RatingStatus { get; set; }

    [Column("rating_status_period")]
    public string? RatingStatusPeriod { get; set; }

    [Column("last_update_status")]
    public string? LastUpdateStatus { get; set; }

    [Column("date_start")]
    public DateOnly? DateStart { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("label_tasks", TypeName = "jsonb")]
    public string? LabelTasks { get; set; }

    [Column("task_properties_definition", TypeName = "jsonb")]
    public string? TaskPropertiesDefinition { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("allow_subtasks")]
    public bool? AllowSubtasks { get; set; }

    [Column("allow_recurring_tasks")]
    public bool? AllowRecurringTasks { get; set; }

    [Column("allow_task_dependencies")]
    public bool? AllowTaskDependencies { get; set; }

    [Column("allow_milestones")]
    public bool? AllowMilestones { get; set; }

    [Column("rating_active")]
    public bool? RatingActive { get; set; }

    [Column("rating_request_deadline", TypeName = "timestamp without time zone")]
    public DateTime? RatingRequestDeadline { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("sale_line_id")]
    public Guid? SaleLineId { get; set; }

    [Column("allow_billable")]
    public bool? AllowBillable { get; set; }

    [ForeignKey("AliasId")]
    [InverseProperty("ProjectProjects")]
    public virtual MailAlias? Alias { get; set; }

    [ForeignKey("AnalyticAccountId")]
    [InverseProperty("ProjectProjects")]
    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("ProjectProjects")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ProjectProjectCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastUpdateId")]
    [InverseProperty("ProjectProjects")]
    public virtual ProjectUpdate? LastUpdate { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("ProjectProjects")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("ProjectProjects")]
    public virtual ResPartner? Partner { get; set; }

    [InverseProperty("Project")]
    public virtual ICollection<ProjectCollaborator> ProjectCollaborators { get; } = new List<ProjectCollaborator>();

    [InverseProperty("Project")]
    public virtual ICollection<ProjectMilestone> ProjectMilestones { get; } = new List<ProjectMilestone>();

    [InverseProperty("ProjectProject")]
    public virtual ICollection<ProjectProjectProjectTagsRel> ProjectProjectProjectTagsRels { get; } = new List<ProjectProjectProjectTagsRel>();

    [InverseProperty("DisplayProject")]
    public virtual ICollection<ProjectTask> ProjectTaskDisplayProjects { get; } = new List<ProjectTask>();

    [InverseProperty("Project")]
    public virtual ICollection<ProjectTask> ProjectTaskProjects { get; } = new List<ProjectTask>();

    [InverseProperty("Project")]
    public virtual ICollection<ProjectTaskTypeRel> ProjectTaskTypeRels { get; } = new List<ProjectTaskTypeRel>();

    [InverseProperty("Project")]
    public virtual ICollection<ProjectUpdate> ProjectUpdates { get; } = new List<ProjectUpdate>();

    [ForeignKey("SaleLineId")]
    [InverseProperty("ProjectProjects")]
    public virtual SaleOrderLine? SaleLine { get; set; }

    [InverseProperty("Project")]
    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; } = new List<SaleOrderLine>();

    [InverseProperty("Project")]
    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    [ForeignKey("UserId")]
    [InverseProperty("ProjectProjectUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ProjectProjectWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProjectProjectId")]
    [InverseProperty("ProjectProjects")]
    public virtual ICollection<ProjectTaskTypeDeleteWizard> ProjectTaskTypeDeleteWizards { get; } = new List<ProjectTaskTypeDeleteWizard>();

    [ForeignKey("ProjectId")]
    [InverseProperty("Projects")]
    public virtual ICollection<ResUser> Users { get; } = new List<ResUser>();
}
