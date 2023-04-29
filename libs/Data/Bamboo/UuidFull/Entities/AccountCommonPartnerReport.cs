using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_common_partner_report")]
public partial class AccountCommonPartnerReport
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

    [Column("target_move")]
    public string? TargetMove { get; set; }

    [Column("result_selection")]
    public string? ResultSelection { get; set; }

    [Column("date_from")]
    public DateOnly? DateFrom { get; set; }

    [Column("date_to")]
    public DateOnly? DateTo { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountCommonPartnerReports")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountCommonPartnerReportCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountCommonPartnerReportWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountCommonPartnerReportId")]
    [InverseProperty("AccountCommonPartnerReports")]
    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    [ForeignKey("AccountCommonPartnerReportId")]
    [InverseProperty("AccountCommonPartnerReports")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
