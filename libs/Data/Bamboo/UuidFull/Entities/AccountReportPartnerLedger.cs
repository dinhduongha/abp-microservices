using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_report_partner_ledger")]
public partial class AccountReportPartnerLedger
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

    [Column("amount_currency")]
    public bool? AmountCurrency { get; set; }

    [Column("reconciled")]
    public bool? Reconciled { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountReportPartnerLedgers")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountReportPartnerLedgerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountReportPartnerLedgerWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountReportPartnerLedgerId")]
    [InverseProperty("AccountReportPartnerLedgers")]
    public virtual ICollection<AccountJournal> AccountJournals { get; } = new List<AccountJournal>();

    [ForeignKey("AccountReportPartnerLedgerId")]
    [InverseProperty("AccountReportPartnerLedgers")]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();
}
