using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("digest_digest")]
public partial class DigestDigest
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("periodicity")]
    public string? Periodicity { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("next_run_date")]
    public DateOnly? NextRunDate { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("kpi_res_users_connected")]
    public bool? KpiResUsersConnected { get; set; }

    [Column("kpi_mail_message_total")]
    public bool? KpiMailMessageTotal { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("kpi_account_total_revenue")]
    public bool? KpiAccountTotalRevenue { get; set; }

    [Column("kpi_all_sale_total")]
    public bool? KpiAllSaleTotal { get; set; }

    [Column("kpi_pos_total")]
    public bool? KpiPosTotal { get; set; }

    [Column("kpi_crm_lead_created")]
    public bool? KpiCrmLeadCreated { get; set; }

    [Column("kpi_crm_opportunities_won")]
    public bool? KpiCrmOpportunitiesWon { get; set; }

    [Column("kpi_project_task_opened")]
    public bool? KpiProjectTaskOpened { get; set; }

    [Column("kpi_hr_recruitment_new_colleagues")]
    public bool? KpiHrRecruitmentNewColleagues { get; set; }

    [Column("kpi_website_sale_total")]
    public bool? KpiWebsiteSaleTotal { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("DigestDigests")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("DigestDigestCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Digest")]
    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

    [ForeignKey("WriteUid")]
    [InverseProperty("DigestDigestWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("DigestDigestId")]
    [InverseProperty("DigestDigests")]
    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();
}
