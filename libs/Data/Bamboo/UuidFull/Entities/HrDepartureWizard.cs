using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("hr_departure_wizard")]
public partial class HrDepartureWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("departure_reason_id")]
    public long? DepartureReasonId { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("departure_date")]
    public DateOnly? DepartureDate { get; set; }

    [Column("departure_description")]
    public string? DepartureDescription { get; set; }

    [Column("archive_private_address")]
    public bool? ArchivePrivateAddress { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("set_date_end")]
    public bool? SetDateEnd { get; set; }

    [Column("release_campany_car")]
    public bool? ReleaseCampanyCar { get; set; }

    [Column("cancel_leaves")]
    public bool? CancelLeaves { get; set; }

    [Column("archive_allocation")]
    public bool? ArchiveAllocation { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("HrDepartureWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("HrDepartureWizards")]
    public virtual HrEmployee? Employee { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("HrDepartureWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
