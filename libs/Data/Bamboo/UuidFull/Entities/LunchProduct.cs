using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("lunch_product")]
public partial class LunchProduct
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("category_id")]
    public Guid? CategoryId { get; set; }

    [Column("supplier_id")]
    public Guid? SupplierId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("new_until")]
    public DateOnly? NewUntil { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("description", TypeName = "jsonb")]
    public string? Description { get; set; }

    [Column("price")]
    public decimal? Price { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("LunchProducts")]
    public virtual LunchProductCategory? Category { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("LunchProducts")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("LunchProductCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    [ForeignKey("SupplierId")]
    [InverseProperty("LunchProducts")]
    public virtual LunchSupplier? Supplier { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("LunchProductWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("Products")]
    public virtual ICollection<ResUser> Users { get; } = new List<ResUser>();
}
