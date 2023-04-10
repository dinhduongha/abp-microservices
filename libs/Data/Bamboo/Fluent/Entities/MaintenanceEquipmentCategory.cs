using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class MaintenanceEquipmentCategory
{
    public long Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? AliasId { get; set; }

    public Guid? TenantId { get; set; }

    public Guid? TechnicianUserId { get; set; }

    public long? Color { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public bool? Fold { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual MailAlias? Alias { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; } = new List<MaintenanceEquipment>();

    //public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; } = new List<MaintenanceRequest>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? TechnicianUser { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
