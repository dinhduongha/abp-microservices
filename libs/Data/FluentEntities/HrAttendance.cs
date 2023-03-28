using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrAttendance
{
    public Guid Id { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateTime? CheckIn { get; set; }

    public DateTime? CheckOut { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? WorkedHours { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    //public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    public virtual ResUser? WriteU { get; set; }
}
