using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountFiscalPositionAccount
{
    public Guid Id { get; set; }

    public Guid? PositionId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? AccountSrcId { get; set; }

    public Guid? AccountDestId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual AccountAccount? AccountDest { get; set; }

    public virtual AccountAccount? AccountSrc { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPosition? Position { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
