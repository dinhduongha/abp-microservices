using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_workcenter")]
[Index("CompanyId", Name = "mrp_workcenter_company_id_index")]
[Index("ResourceCalendarId", Name = "mrp_workcenter_resource_calendar_id_index")]
[Index("ResourceId", Name = "mrp_workcenter_resource_id_index")]
public partial class MrpWorkcenter
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("resource_id")]
    public Guid? ResourceId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("resource_calendar_id")]
    public Guid? ResourceCalendarId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

    [Column("color")]
    public long? Color { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("working_state")]
    public string? WorkingState { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("time_efficiency")]
    public double? TimeEfficiency { get; set; }

    [Column("default_capacity")]
    public double? DefaultCapacity { get; set; }

    [Column("costs_hour")]
    public double? CostsHour { get; set; }

    [Column("time_start")]
    public double? TimeStart { get; set; }

    [Column("time_stop")]
    public double? TimeStop { get; set; }

    [Column("oee_target")]
    public double? OeeTarget { get; set; }

    [Column("costs_hour_account_id")]
    public Guid? CostsHourAccountId { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("MrpWorkcenters")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CostsHourAccountId")]
    [InverseProperty("MrpWorkcenters")]
    public virtual AccountAnalyticAccount? CostsHourAccount { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpWorkcenterCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Workcenter")]
    public virtual ICollection<MrpRoutingWorkcenter> MrpRoutingWorkcenters { get; } = new List<MrpRoutingWorkcenter>();

    [InverseProperty("Workcenter")]
    public virtual ICollection<MrpWorkcenterCapacity> MrpWorkcenterCapacities { get; } = new List<MrpWorkcenterCapacity>();

    [InverseProperty("MrpWorkcenter")]
    public virtual ICollection<MrpWorkcenterMrpWorkcenterTagRel> MrpWorkcenterMrpWorkcenterTagRels { get; } = new List<MrpWorkcenterMrpWorkcenterTagRel>();

    [InverseProperty("Workcenter")]
    public virtual ICollection<MrpWorkcenterProductivity> MrpWorkcenterProductivities { get; } = new List<MrpWorkcenterProductivity>();

    [InverseProperty("Workcenter")]
    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; } = new List<MrpWorkorder>();

    [ForeignKey("ResourceId")]
    [InverseProperty("MrpWorkcenters")]
    public virtual ResourceResource? Resource { get; set; }

    [ForeignKey("ResourceCalendarId")]
    [InverseProperty("MrpWorkcenters")]
    public virtual ResourceCalendar? ResourceCalendar { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpWorkcenterWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("WorkcenterId")]
    [InverseProperty("Workcenters")]
    public virtual ICollection<MrpWorkcenter> AlternativeWorkcenters { get; } = new List<MrpWorkcenter>();

    [ForeignKey("AlternativeWorkcenterId")]
    [InverseProperty("AlternativeWorkcenters")]
    public virtual ICollection<MrpWorkcenter> Workcenters { get; } = new List<MrpWorkcenter>();
}
