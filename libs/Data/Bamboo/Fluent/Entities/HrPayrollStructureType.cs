using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrPayrollStructureType
{
    public long Id { get; set; }

    public Guid? DefaultResourceCalendarId { get; set; }

    public long? CountryId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResourceCalendar? DefaultResourceCalendar { get; set; }

    //public virtual ICollection<HrContract> HrContracts { get; } = new List<HrContract>();

    public virtual ResUser? WriteU { get; set; }
}
