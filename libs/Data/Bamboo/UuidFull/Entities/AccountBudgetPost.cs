using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_budget_post")]
public partial class AccountBudgetPost
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

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountBudgetPosts")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountBudgetPostCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("GeneralBudget")]
    public virtual ICollection<CrossoveredBudgetLine> CrossoveredBudgetLines { get; } = new List<CrossoveredBudgetLine>();

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountBudgetPostWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("BudgetId")]
    [InverseProperty("Budgets")]
    public virtual ICollection<AccountAccount> Accounts { get; } = new List<AccountAccount>();
}
