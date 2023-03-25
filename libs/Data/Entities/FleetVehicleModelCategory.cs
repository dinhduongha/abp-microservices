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

[Table("fleet_vehicle_model_category")]
[Index("Name", Name = "fleet_vehicle_model_category_name_uniq", IsUnique = true)]
public partial class FleetVehicleModelCategory
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("sequence")]
    public long? Sequence { get; set; }

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
    [InverseProperty("FleetVehicleModelCategoryCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<FleetVehicleModel> FleetVehicleModels { get; } = new List<FleetVehicleModel>();

    [InverseProperty("Category")]
    public virtual ICollection<FleetVehicle> FleetVehicles { get; } = new List<FleetVehicle>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("FleetVehicleModelCategoryWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
