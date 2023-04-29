using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("fleet_vehicle_log_contract")]
[Index("UserId", Name = "fleet_vehicle_log_contract_user_id_index")]
public partial class FleetVehicleLogContract
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("vehicle_id")]
    public Guid? VehicleId { get; set; }

    [Column("cost_subtype_id")]
    public long? CostSubtypeId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("insurer_id")]
    public Guid? InsurerId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("ins_ref")]
    public string? InsRef { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("cost_frequency")]
    public string? CostFrequency { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("start_date")]
    public DateOnly? StartDate { get; set; }

    [Column("expiration_date")]
    public DateOnly? ExpirationDate { get; set; }

    [Column("notes")]
    public string? Notes { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("cost_generated")]
    public decimal? CostGenerated { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("FleetVehicleLogContracts")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("FleetVehicleLogContractCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("FleetVehicleLogContract")]
    public virtual ICollection<FleetServiceTypeFleetVehicleLogContractRel> FleetServiceTypeFleetVehicleLogContractRels { get; } = new List<FleetServiceTypeFleetVehicleLogContractRel>();

    [ForeignKey("InsurerId")]
    [InverseProperty("FleetVehicleLogContracts")]
    public virtual ResPartner? Insurer { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("FleetVehicleLogContracts")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("FleetVehicleLogContractUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("VehicleId")]
    [InverseProperty("FleetVehicleLogContracts")]
    public virtual FleetVehicle? Vehicle { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("FleetVehicleLogContractWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
