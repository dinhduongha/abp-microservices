using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_asset_asset")]
public partial class AccountAssetAsset
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("message_main_attachment_id")]
    public Guid? MessageMainAttachmentId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("category_id")]
    public Guid? CategoryId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("method_number")]
    public long? MethodNumber { get; set; }

    [Column("method_period")]
    public long? MethodPeriod { get; set; }

    [Column("invoice_id")]
    public Guid? InvoiceId { get; set; }

    [Column("account_analytic_id")]
    public Guid? AccountAnalyticId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("method")]
    public string? Method { get; set; }

    [Column("method_time")]
    public string? MethodTime { get; set; }

    [Column("date_first_depreciation")]
    public string? DateFirstDepreciation { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("method_end")]
    public DateOnly? MethodEnd { get; set; }

    [Column("first_depreciation_manual_date")]
    public DateOnly? FirstDepreciationManualDate { get; set; }

    [Column("analytic_distribution", TypeName = "jsonb")]
    public string? AnalyticDistribution { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("value")]
    public decimal? Value { get; set; }

    [Column("salvage_value")]
    public decimal? SalvageValue { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("prorata")]
    public bool? Prorata { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("method_progress_factor")]
    public double? MethodProgressFactor { get; set; }

    [ForeignKey("AccountAnalyticId")]
    [InverseProperty("AccountAssetAssets")]
    public virtual AccountAnalyticAccount? AccountAnalytic { get; set; }

    [InverseProperty("Asset")]
    public virtual ICollection<AccountAssetDepreciationLine> AccountAssetDepreciationLines { get; } = new List<AccountAssetDepreciationLine>();

    [ForeignKey("CategoryId")]
    [InverseProperty("AccountAssetAssets")]
    public virtual AccountAssetCategory? Category { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountAssetAssets")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountAssetAssetCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("AccountAssetAssets")]
    public virtual AccountMove? Invoice { get; set; }

    [ForeignKey("MessageMainAttachmentId")]
    [InverseProperty("AccountAssetAssets")]
    public virtual IrAttachment? MessageMainAttachment { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("AccountAssetAssets")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountAssetAssetWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
