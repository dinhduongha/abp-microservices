using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("stock_valuation_layer_revaluation")]
public partial class StockValuationLayerRevaluation
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("account_journal_id")]
    public Guid? AccountJournalId { get; set; }

    [Column("account_id")]
    public Guid? AccountId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("reason")]
    public string? Reason { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("added_value")]
    public decimal? AddedValue { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("StockValuationLayerRevaluations")]
    public virtual AccountAccount? Account { get; set; }

    [ForeignKey("AccountJournalId")]
    [InverseProperty("StockValuationLayerRevaluations")]
    public virtual AccountJournal? AccountJournal { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("StockValuationLayerRevaluations")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("StockValuationLayerRevaluationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("StockValuationLayerRevaluations")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("StockValuationLayerRevaluationWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
