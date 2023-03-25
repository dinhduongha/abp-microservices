using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("fleet_vehicle_model_brand")]
public partial class FleetVehicleModelBrand
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("model_count")]
    public long? ModelCount { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("FleetVehicleModelBrandCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Brand")]
    public virtual ICollection<FleetVehicleModel> FleetVehicleModels { get; } = new List<FleetVehicleModel>();

    [InverseProperty("Brand")]
    public virtual ICollection<FleetVehicle> FleetVehicles { get; } = new List<FleetVehicle>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("FleetVehicleModelBrandWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
