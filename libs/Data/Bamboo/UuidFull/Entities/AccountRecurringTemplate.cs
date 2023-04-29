using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_recurring_template")]
public partial class AccountRecurringTemplate
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("recurring_interval")]
    public long? RecurringInterval { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("recurring_period")]
    public string? RecurringPeriod { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("journal_state")]
    public string? JournalState { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountRecurringTemplates")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountRecurringTemplateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("AccountRecurringTemplates")]
    public virtual AccountJournal? Journal { get; set; }

    [InverseProperty("Template")]
    public virtual ICollection<RecurringPayment> RecurringPayments { get; } = new List<RecurringPayment>();

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountRecurringTemplateWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
