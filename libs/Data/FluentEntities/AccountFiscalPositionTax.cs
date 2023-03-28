using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountFiscalPositionTax
{
    public Guid Id { get; set; }

    public Guid? PositionId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? TaxSrcId { get; set; }

    public Guid? TaxDestId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPosition? Position { get; set; }

    public virtual AccountTax? TaxDest { get; set; }

    public virtual AccountTax? TaxSrc { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
