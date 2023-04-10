using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class DigestDigest
{
    public Guid Id { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Periodicity { get; set; }

    public string? State { get; set; }

    public DateOnly? NextRunDate { get; set; }

    public string? Name { get; set; }

    public bool? KpiResUsersConnected { get; set; }

    public bool? KpiMailMessageTotal { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public bool? KpiAccountTotalRevenue { get; set; }

    public bool? KpiAllSaleTotal { get; set; }

    public bool? KpiPosTotal { get; set; }

    public bool? KpiCrmLeadCreated { get; set; }

    public bool? KpiCrmOpportunitiesWon { get; set; }

    public bool? KpiProjectTaskOpened { get; set; }

    public bool? KpiHrRecruitmentNewColleagues { get; set; }

    public bool? KpiWebsiteSaleTotal { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();
}
