using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class FleetVehicleLogService
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid VehicleId { get; set; }

    public Guid? ManagerId { get; set; }

    public Guid? OdometerId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? PurchaserId { get; set; }

    public Guid? VendorId { get; set; }

    public long ServiceTypeId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Description { get; set; }

    public string? InvRef { get; set; }

    public string? State { get; set; }

    public DateOnly? Date { get; set; }

    public string? Notes { get; set; }

    public decimal? Amount { get; set; }

    public bool? Active { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? PurchaserEmployeeId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? Manager { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual FleetVehicleOdometer? Odometer { get; set; }

    public virtual ResPartner? Purchaser { get; set; }

    public virtual HrEmployee? PurchaserEmployee { get; set; }

    public virtual FleetVehicle Vehicle { get; set; } = null!;

    public virtual ResPartner? Vendor { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
