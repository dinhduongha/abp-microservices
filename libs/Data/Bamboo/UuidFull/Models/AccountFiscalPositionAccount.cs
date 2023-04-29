using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountFiscalPositionAccount
{
    public Guid Id { get; set; }

    public Guid? PositionId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? AccountSrcId { get; set; }

    public Guid? AccountDestId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual AccountAccount? AccountDest { get; set; }

    public virtual AccountAccount? AccountSrc { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPosition? Position { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
