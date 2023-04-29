using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class DigestDigest
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Periodicity { get; set; }

    public string? State { get; set; }

    public DateOnly? NextRunDate { get; set; }

    public string? Name { get; set; }

    public bool? KpiResUsersConnected { get; set; }

    public bool? KpiMailMessageTotal { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

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

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();
}
