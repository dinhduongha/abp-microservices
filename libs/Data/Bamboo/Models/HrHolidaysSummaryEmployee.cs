using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrHolidaysSummaryEmployee
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? HolidayType { get; set; }

    public DateOnly? DateFrom { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<HrEmployee> Emps { get; } = new List<HrEmployee>();
}
