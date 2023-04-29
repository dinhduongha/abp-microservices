using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_analytic_distribution_model")]
public partial class AccountAnalyticDistributionModel
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("partner_category_id")]
    public long? PartnerCategoryId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("analytic_distribution", TypeName = "jsonb")]
    public string? AnalyticDistribution { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("product_categ_id")]
    public long? ProductCategId { get; set; }

    [Column("account_prefix")]
    public string? AccountPrefix { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountAnalyticDistributionModels")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountAnalyticDistributionModelCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("AccountAnalyticDistributionModels")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("AccountAnalyticDistributionModels")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountAnalyticDistributionModelWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
