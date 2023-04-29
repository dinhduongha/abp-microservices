﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mail_alias")]
[Index("AliasName", Name = "mail_alias_alias_unique", IsUnique = true)]
public partial class MailAlias
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("alias_model_id")]
    public Guid? AliasModelId { get; set; }

    [Column("alias_user_id")]
    public Guid? AliasUserId { get; set; }

    [Column("alias_force_thread_id")]
    public Guid? AliasForceThreadId { get; set; }

    [Column("alias_parent_model_id")]
    public Guid? AliasParentModelId { get; set; }

    [Column("alias_parent_thread_id")]
    public Guid? AliasParentThreadId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("alias_name")]
    public string? AliasName { get; set; }

    [Column("alias_contact")]
    public string? AliasContact { get; set; }

    [Column("alias_bounced_content", TypeName = "jsonb")]
    public string? AliasBouncedContent { get; set; }

    [Column("alias_defaults")]
    public string? AliasDefaults { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [InverseProperty("Alias")]
    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    [ForeignKey("AliasModelId")]
    [InverseProperty("MailAliasAliasModels")]
    public virtual IrModel? AliasModel { get; set; }

    [ForeignKey("AliasParentModelId")]
    [InverseProperty("MailAliasAliasParentModels")]
    public virtual IrModel? AliasParentModel { get; set; }

    [ForeignKey("AliasUserId")]
    [InverseProperty("MailAliasAliasUsers")]
    public virtual ResUser? AliasUser { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MailAliasCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Alias")]
    public virtual ICollection<CrmTeam> CrmTeams { get; } = new List<CrmTeam>();

    [InverseProperty("Alias")]
    public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    [InverseProperty("Alias")]
    public virtual ICollection<HrRecruitmentSource> HrRecruitmentSources { get; } = new List<HrRecruitmentSource>();

    [InverseProperty("Alias")]
    public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategories { get; } = new List<MaintenanceEquipmentCategory>();

    [InverseProperty("Alias")]
    public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MailAliasWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
