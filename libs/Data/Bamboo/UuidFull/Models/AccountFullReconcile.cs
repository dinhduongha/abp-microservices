using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountFullReconcile
{
    public Guid Id { get; set; }

    public Guid? ExchangeMoveId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountPartialReconcile> AccountPartialReconciles { get; } = new List<AccountPartialReconcile>();

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMove? ExchangeMove { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
