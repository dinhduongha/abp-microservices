using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountFiscalPositionTax
{
    public Guid Id { get; set; }

    public Guid? PositionId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? TaxSrcId { get; set; }

    public Guid? TaxDestId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPosition? Position { get; set; }

    public virtual AccountTax? TaxDest { get; set; }

    public virtual AccountTax? TaxSrc { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
