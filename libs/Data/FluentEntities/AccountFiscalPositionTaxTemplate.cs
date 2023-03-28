using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountFiscalPositionTaxTemplate
{
    public Guid Id { get; set; }

    public Guid? PositionId { get; set; }

    public Guid? TaxSrcId { get; set; }

    public Guid? TaxDestId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPositionTemplate? Position { get; set; }

    public virtual AccountTaxTemplate? TaxDest { get; set; }

    public virtual AccountTaxTemplate? TaxSrc { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
