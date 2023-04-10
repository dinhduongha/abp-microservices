using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class HrDepartureWizard
{
    public Guid Id { get; set; }

    public long? DepartureReasonId { get; set; }

    public Guid? EmployeeId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public DateOnly? DepartureDate { get; set; }

    public string? DepartureDescription { get; set; }

    public bool? ArchivePrivateAddress { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public bool? SetDateEnd { get; set; }

    public bool? CancelLeaves { get; set; }

    public bool? ArchiveAllocation { get; set; }

    public bool? ReleaseCampanyCar { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartureReason? DepartureReason { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
