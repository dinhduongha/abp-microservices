using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountFullReconcile
{
    public Guid Id { get; set; }

    public Guid? ExchangeMoveId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountMoveLine> AccountMoveLines { get; } = new List<AccountMoveLine>();

    //public virtual ICollection<AccountPartialReconcile> AccountPartialReconciles { get; } = new List<AccountPartialReconcile>();

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMove? ExchangeMove { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
