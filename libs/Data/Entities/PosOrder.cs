using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("pos_order")]
[Index("AccountMove", Name = "pos_order_account_move_index")]
[Index("DateOrder", Name = "pos_order_date_order_index")]
[Index("SessionId", Name = "pos_order_session_id_index")]
public partial class PosOrder: IMultiTenant, IMayHaveCreator, IModificationAuditedObject
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("company_id")]
    public Guid? TenantId { get; set; }

    [Column("pricelist_id")]
    public Guid? PricelistId { get; set; }

    [Column("partner_id")]
    public Guid? PartnerId { get; set; }

    [Column("sequence_number")]
    public long SequenceNumber { get; set; }

    [Column("session_id")]
    public Guid? SessionId { get; set; }

    [Column("account_move")]
    public Guid? AccountMove { get; set; }

    [Column("procurement_group_id")]
    public Guid? ProcurementGroupId { get; set; }

    [Column("nb_print")]
    public long? NbPrint { get; set; }

    [Column("sale_journal")]
    public Guid? SaleJournal { get; set; }

    [Column("fiscal_position_id")]
    public Guid? FiscalPositionId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("access_token")]
    public string? AccessToken { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("pos_reference")]
    public string? PosReference { get; set; }

    [Column("note")]
    public string? Note { get; set; }

    [Column("amount_tax")]
    public decimal? AmountTax { get; set; }

    [Column("amount_total")]
    public decimal? AmountTotal { get; set; }

    [Column("amount_paid")]
    public decimal? AmountPaid { get; set; }

    [Column("amount_return")]
    public decimal? AmountReturn { get; set; }

    [Column("currency_rate")]
    public decimal? CurrencyRate { get; set; }

    [Column("tip_amount")]
    public decimal? TipAmount { get; set; }

    [Column("to_invoice")]
    public bool? ToInvoice { get; set; }

    [Column("to_ship")]
    public bool? ToShip { get; set; }

    [Column("is_tipped")]
    public bool? IsTipped { get; set; }

    [Column("date_order", TypeName = "timestamp without time zone")]
    public DateTime? DateOrder { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [Column("crm_team_id")]
    public Guid? CrmTeamId { get; set; }

    [Column("employee_id")]
    public Guid? EmployeeId { get; set; }

    [Column("cashier")]
    public string? Cashier { get; set; }

    [ForeignKey("AccountMove")]
    [InverseProperty("PosOrders")]
    public virtual AccountMove? AccountMoveNavigation { get; set; }

    [ForeignKey("TenantId")]
    [InverseProperty("PosOrders")]
    public virtual ResCompany? Company { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("PosOrderCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("CrmTeamId")]
    [InverseProperty("PosOrders")]
    public virtual CrmTeam? CrmTeam { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("PosOrders")]
    public virtual HrEmployee? Employee { get; set; }

    [ForeignKey("FiscalPositionId")]
    [InverseProperty("PosOrders")]
    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    [ForeignKey("PartnerId")]
    [InverseProperty("PosOrders")]
    public virtual ResPartner? Partner { get; set; }

    [InverseProperty("Order")]
    [NotMapped]
    public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    [InverseProperty("PosOrder")]
    [NotMapped]
    public virtual ICollection<PosPayment> PosPayments { get; } = new List<PosPayment>();

    [ForeignKey("PricelistId")]
    [InverseProperty("PosOrders")]
    public virtual ProductPricelist? Pricelist { get; set; }

    [ForeignKey("ProcurementGroupId")]
    [InverseProperty("PosOrders")]
    public virtual ProcurementGroup? ProcurementGroup { get; set; }

    [InverseProperty("PosOrder")]
    [NotMapped]
    public virtual ICollection<ProcurementGroup> ProcurementGroups { get; } = new List<ProcurementGroup>();

    [ForeignKey("SaleJournal")]
    [InverseProperty("PosOrders")]
    public virtual AccountJournal? SaleJournalNavigation { get; set; }

    [ForeignKey("SessionId")]
    [InverseProperty("PosOrders")]
    public virtual PosSession? Session { get; set; }

    [InverseProperty("PosOrder")]
    [NotMapped]
    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    [ForeignKey("UserId")]
    [InverseProperty("PosOrderUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("PosOrderWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
