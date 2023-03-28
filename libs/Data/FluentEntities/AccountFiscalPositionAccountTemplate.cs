using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountFiscalPositionAccountTemplate
{
    public Guid Id { get; set; }

    public Guid? PositionId { get; set; }

    public Guid? AccountSrcId { get; set; }

    public Guid? AccountDestId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual AccountAccountTemplate? AccountDest { get; set; }

    public virtual AccountAccountTemplate? AccountSrc { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPositionTemplate? Position { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
