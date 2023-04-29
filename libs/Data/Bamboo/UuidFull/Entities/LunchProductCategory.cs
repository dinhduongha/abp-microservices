using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("lunch_product_category")]
public partial class LunchProductCategory
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("LunchProductCategories")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("LunchProductCategoryCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<LunchOrder> LunchOrders { get; } = new List<LunchOrder>();

    [InverseProperty("Category")]
    public virtual ICollection<LunchProduct> LunchProducts { get; } = new List<LunchProduct>();

    [ForeignKey("WriteUid")]
    [InverseProperty("LunchProductCategoryWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
