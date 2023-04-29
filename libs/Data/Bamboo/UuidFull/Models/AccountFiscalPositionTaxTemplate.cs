using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountFiscalPositionTaxTemplate
{
    public Guid Id { get; set; }

    public Guid? PositionId { get; set; }

    public Guid? TaxSrcId { get; set; }

    public Guid? TaxDestId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPositionTemplate? Position { get; set; }

    public virtual AccountTaxTemplate? TaxDest { get; set; }

    public virtual AccountTaxTemplate? TaxSrc { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
