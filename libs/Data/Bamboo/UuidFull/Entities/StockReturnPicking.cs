﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_return_picking")]
public partial class StockReturnPicking
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("picking_id")]
    public Guid? PickingId { get; set; }

    [Column("original_location_id")]
    public Guid? OriginalLocationId { get; set; }

    [Column("parent_location_id")]
    public Guid? ParentLocationId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("move_dest_exists")]
    public bool? MoveDestExists { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockReturnPickingCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LocationId")]
    [InverseProperty("StockReturnPickingLocations")]
    public virtual StockLocation? Location { get; set; }

    [ForeignKey("OriginalLocationId")]
    [InverseProperty("StockReturnPickingOriginalLocations")]
    public virtual StockLocation? OriginalLocation { get; set; }

    [ForeignKey("ParentLocationId")]
    [InverseProperty("StockReturnPickingParentLocations")]
    public virtual StockLocation? ParentLocation { get; set; }

    [ForeignKey("PickingId")]
    [InverseProperty("StockReturnPickings")]
    public virtual StockPicking? Picking { get; set; }

    [InverseProperty("Wizard")]
    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; } = new List<StockReturnPickingLine>();

    [ForeignKey("WriteUid")]
    [InverseProperty("StockReturnPickingWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
