﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("spreadsheet_dashboard")]
public partial class SpreadsheetDashboard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("dashboard_group_id")]
    public long? DashboardGroupId { get; set; }

    [Column("sequence")]
    public long Sequence { get; set; }

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
    //[InverseProperty("SpreadsheetDashboardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("DashboardGroupId")]
    //[InverseProperty("SpreadsheetDashboards")]
    public virtual SpreadsheetDashboardGroup? DashboardGroup { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("SpreadsheetDashboardWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("SpreadsheetDashboardId")]
    [InverseProperty("SpreadsheetDashboards")]
    [NotMapped]
    public virtual ICollection<ResGroup> ResGroups { get; } = new List<ResGroup>();
}
