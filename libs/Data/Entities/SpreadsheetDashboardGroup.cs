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

[Table("spreadsheet_dashboard_group")]
public partial class SpreadsheetDashboardGroup
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("sequence", TypeName = "bigserial")]
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
    [InverseProperty("SpreadsheetDashboardGroupCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("DashboardGroup")]
    [NotMapped]
    public virtual ICollection<SpreadsheetDashboard> SpreadsheetDashboards { get; } = new List<SpreadsheetDashboard>();

    [ForeignKey("LastModifierId")]
    [InverseProperty("SpreadsheetDashboardGroupWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}