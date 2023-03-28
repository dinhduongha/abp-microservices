using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MailAlias
{
    public Guid Id { get; set; }

    public Guid? AliasModelId { get; set; }

    public Guid? AliasUserId { get; set; }

    public Guid? AliasForceThreadId { get; set; }

    public Guid? AliasParentModelId { get; set; }

    public Guid? AliasParentThreadId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? AliasName { get; set; }

    public string? AliasContact { get; set; }

    public string? AliasBouncedContent { get; set; }

    public string? AliasDefaults { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    public virtual IrModel? AliasModel { get; set; }

    public virtual IrModel? AliasParentModel { get; set; }

    public virtual ResUser? AliasUser { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmTeam> CrmTeams { get; } = new List<CrmTeam>();

    //public virtual ICollection<HrJob> HrJobs { get; } = new List<HrJob>();

    //public virtual ICollection<HrRecruitmentSource> HrRecruitmentSources { get; } = new List<HrRecruitmentSource>();

    //public virtual ICollection<MaintenanceEquipmentCategory> MaintenanceEquipmentCategories { get; } = new List<MaintenanceEquipmentCategory>();

    //public virtual ICollection<ProjectProject> ProjectProjects { get; } = new List<ProjectProject>();

    public virtual ResUser? WriteU { get; set; }
}
