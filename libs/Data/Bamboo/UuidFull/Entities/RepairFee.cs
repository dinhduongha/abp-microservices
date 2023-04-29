﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("repair_fee")]
[Index("CompanyId", Name = "repair_fee_company_id_index")]
[Index("Name", Name = "repair_fee_name_index")]
[Index("RepairId", Name = "repair_fee_repair_id_index")]
public partial class RepairFee
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("repair_id")]
    public Guid? RepairId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_uom")]
    public Guid? ProductUom { get; set; }

    [Column("invoice_line_id")]
    public Guid? InvoiceLineId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("product_uom_qty")]
    public decimal? ProductUomQty { get; set; }

    [Column("price_unit")]
    public decimal? PriceUnit { get; set; }

    [Column("price_subtotal")]
    public decimal? PriceSubtotal { get; set; }

    [Column("price_total")]
    public decimal? PriceTotal { get; set; }

    [Column("invoiced")]
    public bool? Invoiced { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("RepairFees")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("RepairFeeCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("InvoiceLineId")]
    [InverseProperty("RepairFees")]
    public virtual AccountMoveLine? InvoiceLine { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("RepairFees")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductUom")]
    [InverseProperty("RepairFees")]
    public virtual UomUom? ProductUomNavigation { get; set; }

    [ForeignKey("RepairId")]
    [InverseProperty("RepairFees")]
    public virtual RepairOrder? Repair { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("RepairFeeWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("RepairFeeLineId")]
    [InverseProperty("RepairFeeLines")]
    public virtual ICollection<AccountTax> Taxes { get; } = new List<AccountTax>();
}
