using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_analytic_line")]
[Index("AccountId", Name = "account_analytic_line_account_id_index")]
[Index("Date", Name = "account_analytic_line_date_index")]
[Index("MoveLineId", Name = "account_analytic_line_move_line_id_index")]
[Index("UserId", Name = "account_analytic_line_user_id_index")]
public partial class AccountAnalyticLine
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("product_uom_id")]
    public Guid? ProductUomId { get; set; }

    [Column("account_id")]
    public Guid? AccountId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("company_id")]
    public Guid? CompanyId { get; set; }

    [Column("currency_id")]
    public long? CurrencyId { get; set; }

    [Column("plan_id")]
    public Guid? PlanId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("category")]
    public string? Category { get; set; }

    [Column("date")]
    public DateOnly? Date { get; set; }

    [Column("amount")]
    public decimal? Amount { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("unit_amount")]
    public double? UnitAmount { get; set; }

    [Column("product_id")]
    public Guid? ProductId { get; set; }

    [Column("general_account_id")]
    public Guid? GeneralAccountId { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("move_line_id")]
    public Guid? MoveLineId { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("ref")]
    public string? Ref { get; set; }

    [Column("so_line")]
    public Guid? SoLine { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("AccountAnalyticLines")]
    public virtual AccountAnalyticAccount? Account { get; set; }

    [ForeignKey("CompanyId")]
    [InverseProperty("AccountAnalyticLines")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountAnalyticLineCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("GeneralAccountId")]
    [InverseProperty("AccountAnalyticLines")]
    public virtual AccountAccount? GeneralAccount { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("AccountAnalyticLines")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("MoveLineId")]
    [InverseProperty("AccountAnalyticLines")]
    public virtual AccountMoveLine? MoveLine { get; set; }

    [InverseProperty("MoAnalyticAccountLine")]
    public virtual ICollection<MrpWorkorder> MrpWorkorderMoAnalyticAccountLines { get; } = new List<MrpWorkorder>();

    [InverseProperty("WcAnalyticAccountLine")]
    public virtual ICollection<MrpWorkorder> MrpWorkorderWcAnalyticAccountLines { get; } = new List<MrpWorkorder>();

    [ForeignKey("PartnerId")]
    [InverseProperty("AccountAnalyticLines")]
    public virtual ResPartner? Partner { get; set; }

    [ForeignKey("PlanId")]
    [InverseProperty("AccountAnalyticLines")]
    public virtual AccountAnalyticPlan? Plan { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("AccountAnalyticLines")]
    public virtual ProductProduct? Product { get; set; }

    [ForeignKey("ProductUomId")]
    [InverseProperty("AccountAnalyticLines")]
    public virtual UomUom? ProductUom { get; set; }

    [ForeignKey("SoLine")]
    [InverseProperty("AccountAnalyticLines")]
    public virtual SaleOrderLine? SoLineNavigation { get; set; }

    [InverseProperty("AnalyticAccountLine")]
    public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    [ForeignKey("UserId")]
    [InverseProperty("AccountAnalyticLineUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountAnalyticLineWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
