using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_valuation_layer")]
[Index("AccountMoveLineId", Name = "stock_valuation_layer_account_move_line_id_index")]
[Index("ProductId", "RemainingQty", "StockMoveId", "CompanyId", "CreateDate", Name = "stock_valuation_layer_index")]
[Index("StockMoveId", Name = "stock_valuation_layer_stock_move_id_index")]
public partial class StockValuationLayer
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("stock_valuation_layer_id")]
    public Guid? StockValuationLayerId { get; set; }

    [Column("stock_move_id")]
    public Guid? StockMoveId { get; set; }

    [Column("account_move_id")]
    public Guid? AccountMoveId { get; set; }

    [Column("account_move_line_id")]
    public Guid? AccountMoveLineId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("quantity")]
    public decimal? Quantity { get; set; }

    [Column("unit_cost")]
    public decimal? UnitCost { get; set; }

    [Column("value")]
    public decimal? Value { get; set; }

    [Column("remaining_qty")]
    public decimal? RemainingQty { get; set; }

    [Column("remaining_value")]
    public decimal? RemainingValue { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("price_diff_value")]
    public double? PriceDiffValue { get; set; }

    [ForeignKey("AccountMoveId")]
    [InverseProperty("StockValuationLayers")]
    public virtual AccountMove? AccountMove { get; set; }

    [ForeignKey("AccountMoveLineId")]
    [InverseProperty("StockValuationLayers")]
    public virtual AccountMoveLine? AccountMoveLine { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("StockValuationLayers")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockValuationLayerCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("StockValuationLayerNavigation")]
    public virtual ICollection<StockValuationLayer> InverseStockValuationLayerNavigation { get; } = new List<StockValuationLayer>();

    [ForeignKey("ProductId")]
    [InverseProperty("StockValuationLayers")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("StockMoveId")]
    [InverseProperty("StockValuationLayers")]
    public virtual StockMove? StockMove { get; set; }

    [ForeignKey("StockValuationLayerId")]
    [InverseProperty("InverseStockValuationLayerNavigation")]
    public virtual StockValuationLayer? StockValuationLayerNavigation { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockValuationLayerWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
