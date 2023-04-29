using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("maintenance_equipment_category")]
public partial class MaintenanceEquipmentCategory
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("alias_id")]
    public Guid? AliasId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("technician_user_id")]
    public Guid? TechnicianUserId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("note", TypeName = "jsonb")]
    public string? Note { get; set; }

    [Column("fold")]
    public bool? Fold { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AliasId")]
    [InverseProperty("MaintenanceEquipmentCategories")]
    public virtual MailAlias? Alias { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("MaintenanceEquipmentCategories")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MaintenanceEquipmentCategoryCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("MaintenanceEquipmentCategories")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("TechnicianUserId")]
    [InverseProperty("MaintenanceEquipmentCategoryTechnicianUsers")]
    public virtual ResUser? TechnicianUser { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MaintenanceEquipmentCategoryWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
