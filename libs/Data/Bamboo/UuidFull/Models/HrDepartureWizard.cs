using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class HrDepartureWizard
{
    public Guid Id { get; set; }

    public long? DepartureReasonId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public DateOnly? DepartureDate { get; set; }

    public string? DepartureDescription { get; set; }

    public bool? ArchivePrivateAddress { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public bool? SetDateEnd { get; set; }

    public bool? ReleaseCampanyCar { get; set; }

    public bool? CancelLeaves { get; set; }

    public bool? ArchiveAllocation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
