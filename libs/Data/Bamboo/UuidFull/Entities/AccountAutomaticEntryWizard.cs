using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_automatic_entry_wizard")]
public partial class AccountAutomaticEntryWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("destination_account_id")]
    public Guid? DestinationAccountId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("action")]
    public string? Action { get; set; }

    [Column("account_type")]
    public string? AccountType { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("total_amount")]
    public decimal? TotalAmount { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("percentage")]
    public double? Percentage { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountAutomaticEntryWizards")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountAutomaticEntryWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DestinationAccountId")]
    [InverseProperty("AccountAutomaticEntryWizards")]
    public virtual AccountAccount? DestinationAccount { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountAutomaticEntryWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountAutomaticEntryWizardId")]
    [InverseProperty("AccountAutomaticEntryWizards")]
    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();
}
