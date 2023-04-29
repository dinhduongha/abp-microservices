using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("maintenance_team")]
public partial class MaintenanceTeam
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("MaintenanceTeams")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MaintenanceTeamCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("MaintenanceTeam")]
    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; } = new List<MaintenanceEquipment>();

    [InverseProperty("MaintenanceTeam")]
    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; } = new List<MaintenanceRequest>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MaintenanceTeamWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("MaintenanceTeamId")]
    [InverseProperty("MaintenanceTeams")]
    public virtual ICollection<ResUser> ResUsers { get; } = new List<ResUser>();
}
