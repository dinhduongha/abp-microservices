using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("lunch_topping")]
public partial class LunchTopping
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("supplier_id")]
    public Guid? SupplierId { get; set; }

    [Column("topping_category")]
    public Guid? ToppingCategory { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("price")]
    public decimal? Price { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("LunchToppings")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("LunchToppingCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("SupplierId")]
    [InverseProperty("LunchToppings")]
    public virtual LunchSupplier? Supplier { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("LunchToppingWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ToppingId")]
    [InverseProperty("Toppings")]
    public virtual ICollection<LunchOrder> Orders { get; } = new List<LunchOrder>();
}
