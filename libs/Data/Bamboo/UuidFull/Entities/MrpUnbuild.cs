﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("mrp_unbuild")]
[Index("CompanyId", Name = "mrp_unbuild_company_id_index")]
public partial class MrpUnbuild
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("product_uom_id")]
    public Guid? ProductUomId { get; set; }

    [Column("bom_id")]
    public Guid? BomId { get; set; }

    [Column("mo_id")]
    public Guid? MoId { get; set; }

    [Column("lot_id")]
    public Guid? LotId { get; set; }

    [Column("location_id")]
    public Guid? LocationId { get; set; }

    [Column("location_dest_id")]
    public Guid? LocationDestId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("product_qty")]
    public double? ProductQty { get; set; }

    [ForeignKey("BomId")]
    [InverseProperty("MrpUnbuilds")]
    public virtual MrpBom? Bom { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("MrpUnbuilds")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("MrpUnbuildCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LocationId")]
    [InverseProperty("MrpUnbuildLocations")]
    public virtual StockLocation? Location { get; set; }

    [ForeignKey("LocationDestId")]
    [InverseProperty("MrpUnbuildLocationDests")]
    public virtual StockLocation? LocationDest { get; set; }

    [ForeignKey("LotId")]
    [InverseProperty("MrpUnbuilds")]
    public virtual StockLot? Lot { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("MrpUnbuilds")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("MoId")]
    [InverseProperty("MrpUnbuilds")]
    public virtual MrpProduction? Mo { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("MrpUnbuilds")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductUomId")]
    [InverseProperty("MrpUnbuilds")]
    public virtual UomUom? ProductUom { get; set; }

    [InverseProperty("ConsumeUnbuild")]
    public virtual ICollection<StockMove> StockMoveConsumeUnbuilds { get; } = new List<StockMove>();

    [InverseProperty("Unbuild")]
    public virtual ICollection<StockMove> StockMoveUnbuilds { get; } = new List<StockMove>();

    [InverseProperty("Unbuild")]
    public virtual ICollection<StockWarnInsufficientQtyUnbuild> StockWarnInsufficientQtyUnbuilds { get; } = new List<StockWarnInsufficientQtyUnbuild>();

    [ForeignKey("WriteUid")]
    [InverseProperty("MrpUnbuildWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
