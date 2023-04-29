using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PosOrder
{
    public Guid Id { get; set; }

    public Guid? UserId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? PricelistId { get; set; }

    public Guid? PartnerId { get; set; }

    public long SequenceNumber { get; set; }

    public Guid? SessionId { get; set; }

    public Guid? AccountMove { get; set; }

    public Guid? ProcurementGroupId { get; set; }

    public long? NbPrint { get; set; }

    public Guid? SaleJournal { get; set; }

    public Guid? FiscalPositionId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? AccessToken { get; set; }

    public string? Name { get; set; }

    public string? State { get; set; }

    public string? PosReference { get; set; }

    public string? Note { get; set; }

    public decimal? AmountTax { get; set; }

    public decimal? AmountTotal { get; set; }

    public decimal? AmountPaid { get; set; }

    public decimal? AmountReturn { get; set; }

    public decimal? CurrencyRate { get; set; }

    public decimal? TipAmount { get; set; }

    public bool? ToInvoice { get; set; }

    public bool? ToShip { get; set; }

    public bool? IsTipped { get; set; }

    public DateTime? DateOrder { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public Guid? CrmTeamId { get; set; }

    public Guid? EmployeeId { get; set; }

    public string? Cashier { get; set; }

    public virtual AccountMove? AccountMoveNavigation { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? CrmTeam { get; set; }

    public virtual HrEmployee? Employee { get; set; }

    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ICollection<PosOrderLine> PosOrderLines { get; } = new List<PosOrderLine>();

    public virtual ICollection<PosPayment> PosPayments { get; } = new List<PosPayment>();

    public virtual ProductPricelist? Pricelist { get; set; }

    public virtual ProcurementGroup? ProcurementGroup { get; set; }

    public virtual ICollection<ProcurementGroup> ProcurementGroups { get; } = new List<ProcurementGroup>();

    public virtual AccountJournal? SaleJournalNavigation { get; set; }

    public virtual PosSession? Session { get; set; }

    public virtual ICollection<StockPicking> StockPickings { get; } = new List<StockPicking>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
