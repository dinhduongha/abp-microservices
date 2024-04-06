﻿using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountPartialReconcile
{
    public Guid Id { get; set; }

    public Guid? DebitMoveId { get; set; }

    public Guid? CreditMoveId { get; set; }

    public Guid? FullReconcileId { get; set; }

    public Guid? ExchangeMoveId { get; set; }

    public long? DebitCurrencyId { get; set; }

    public long? CreditCurrencyId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateOnly? MaxDate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? DebitAmountCurrency { get; set; }

    public decimal? CreditAmountCurrency { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMoveLine? CreditMove { get; set; }

    public virtual AccountMoveLine? DebitMove { get; set; }

    public virtual AccountMove? ExchangeMove { get; set; }

    public virtual AccountFullReconcile? FullReconcile { get; set; }

    public virtual ResUser? WriteU { get; set; }
}