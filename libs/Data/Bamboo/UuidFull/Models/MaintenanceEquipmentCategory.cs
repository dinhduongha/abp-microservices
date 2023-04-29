using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class MaintenanceEquipmentCategory
{
    public Guid Id { get; set; }

    public Guid? MessageMainAttachmentId { get; set; }

    public Guid? AliasId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? TechnicianUserId { get; set; }

    public long? Color { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? Note { get; set; }

    public bool? Fold { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual MailAlias? Alias { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? TechnicianUser { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
