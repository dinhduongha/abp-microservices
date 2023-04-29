using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountAutomaticEntryWizard
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? DestinationAccountId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Action { get; set; }

    public string? AccountType { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? TotalAmount { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? Percentage { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountAccount? DestinationAccount { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();
}
