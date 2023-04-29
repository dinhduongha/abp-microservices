using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ChangeLockDate
{
    public Guid Id { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateOnly? PeriodLockDate { get; set; }

    public DateOnly? FiscalyearLockDate { get; set; }

    public DateOnly? TaxLockDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
