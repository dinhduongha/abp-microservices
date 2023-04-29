using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

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
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("SpreadsheetDashboardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("SpreadsheetDashboardWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("SpreadsheetDashboardId")]
    [InverseProperty("SpreadsheetDashboards")]
    public virtual ICollection<ResGroup> ResGroups { get; } = new List<ResGroup>();
}
