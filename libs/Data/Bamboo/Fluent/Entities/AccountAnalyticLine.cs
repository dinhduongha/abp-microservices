using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class AccountAnalyticLine
{
    public Guid Id { get; set; }

    public Guid? ProductUomId { get; set; }

    public Guid? AccountId { get; set; }

    public Guid? PartnerId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? TenantId { get; set; }

    public long? CurrencyId { get; set; }

    public Guid? PlanId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Category { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public double? UnitAmount { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? GeneralAccountId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? MoveLineId { get; set; }

    public string? Code { get; set; }

    public string? Ref { get; set; }

    public Guid? SoLine { get; set; }

    public virtual AccountAnalyticAccount? Account { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountAccount? GeneralAccount { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountMoveLine? MoveLine { get; set; }

    //public virtual ICollection<MrpWorkorder> MrpWorkorderMoAnalyticAccountLines { get; } = new List<MrpWorkorder>();

    //public virtual ICollection<MrpWorkorder> MrpWorkorderWcAnalyticAccountLines { get; } = new List<MrpWorkorder>();

    public virtual ResPartner? Partner { get; set; }

    public virtual AccountAnalyticPlan? Plan { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom? ProductUom { get; set; }

    public virtual SaleOrderLine? SoLineNavigation { get; set; }

    //public virtual ICollection<StockMove> StockMoves { get; } = new List<StockMove>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
