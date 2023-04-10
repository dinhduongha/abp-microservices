﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class CrossoveredBudgetLine
{
    public Guid Id { get; set; }

    public Guid? CrossoveredBudgetId { get; set; }

    public Guid? AnalyticAccountId { get; set; }

    public Guid? GeneralBudgetId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? CrossoveredBudgetState { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateOnly? DateTo { get; set; }

    public DateOnly? PaidDate { get; set; }

    public decimal? PlannedAmount { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual AccountAnalyticAccount? AnalyticAccount { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrossoveredBudget? CrossoveredBudget { get; set; }

    public virtual AccountBudgetPost? GeneralBudget { get; set; }

    public virtual ResUser? WriteU { get; set; }
}