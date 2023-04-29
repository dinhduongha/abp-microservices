using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class PosConfig
{
    public Guid Id { get; set; }

    public Guid? PickingTypeId { get; set; }

    public Guid? JournalId { get; set; }

    public Guid? InvoiceJournalId { get; set; }

    public long? IfaceStartCategId { get; set; }

    public Guid? SequenceId { get; set; }

    public Guid? SequenceLineId { get; set; }

    public Guid? PricelistId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? GroupPosManagerId { get; set; }

    public Guid? GroupPosUserId { get; set; }

    public Guid? TipProductId { get; set; }

    public Guid? DefaultFiscalPositionId { get; set; }

    public Guid? RoundingMethod { get; set; }

    public Guid? WarehouseId { get; set; }

    public Guid? RouteId { get; set; }

    public long? LimitedProductsAmount { get; set; }

    public long? LimitedPartnersAmount { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? IfaceTaxIncluded { get; set; }

    public string? ProxyIp { get; set; }

    public string? Uuid { get; set; }

    public string? PickingPolicy { get; set; }

    public string? ReceiptHeader { get; set; }

    public string? ReceiptFooter { get; set; }

    public bool? IfaceCashdrawer { get; set; }

    public bool? IfaceElectronicScale { get; set; }

    public bool? IfaceCustomerFacingDisplayViaProxy { get; set; }

    public bool? IfaceCustomerFacingDisplayLocal { get; set; }

    public bool? IfacePrintViaProxy { get; set; }

    public bool? IfaceScanViaProxy { get; set; }

    public bool? IfaceBigScrollbars { get; set; }

    public bool? IfacePrintAuto { get; set; }

    public bool? IfacePrintSkipScreen { get; set; }

    public bool? RestrictPriceControl { get; set; }

    public bool? IsMarginsCostsAccessibleToEveryUser { get; set; }

    public bool? SetMaximumDifference { get; set; }

    public bool? Active { get; set; }

    public bool? IfaceTipproduct { get; set; }

    public bool? UsePricelist { get; set; }

    public bool? TaxRegimeSelection { get; set; }

    public bool? StartCategory { get; set; }

    public bool? LimitCategories { get; set; }

    public bool? ModulePosRestaurant { get; set; }

    public bool? ModulePosDiscount { get; set; }

    public bool? ModulePosMercury { get; set; }

    public bool? IsPosbox { get; set; }

    public bool? IsHeaderOrFooter { get; set; }

    public bool? ModulePosHr { get; set; }

    public bool? OtherDevices { get; set; }

    public bool? CashRounding { get; set; }

    public bool? OnlyRoundCashMethod { get; set; }

    public bool? ManualDiscount { get; set; }

    public bool? ShipLater { get; set; }

    public bool? LimitedProductsLoading { get; set; }

    public bool? ProductLoadBackground { get; set; }

    public bool? LimitedPartnersLoading { get; set; }

    public bool? PartnerLoadBackground { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public double? AmountAuthorizedDiff { get; set; }

    public string? EpsonPrinterIp { get; set; }

    public Guid? CrmTeamId { get; set; }

    public Guid? DownPaymentProductId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmTeam? CrmTeam { get; set; }

    public virtual AccountFiscalPosition? DefaultFiscalPosition { get; set; }

    public virtual ProductProduct? DownPaymentProduct { get; set; }

    public virtual ResGroup? GroupPosManager { get; set; }

    public virtual ResGroup? GroupPosUser { get; set; }

    public virtual AccountJournal? InvoiceJournal { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual StockPickingType? PickingType { get; set; }

    public virtual ICollection<PosCategoryPosConfigRel> PosCategoryPosConfigRels { get; } = new List<PosCategoryPosConfigRel>();

    public virtual ICollection<PosConfigPosPaymentMethodRel> PosConfigPosPaymentMethodRels { get; } = new List<PosConfigPosPaymentMethodRel>();

    public virtual ICollection<PosMakePayment> PosMakePayments { get; } = new List<PosMakePayment>();

    public virtual ICollection<PosSession> PosSessions { get; } = new List<PosSession>();

    public virtual ProductPricelist? Pricelist { get; set; }

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();

    public virtual AccountCashRounding? RoundingMethodNavigation { get; set; }

    public virtual StockRoute? Route { get; set; }

    public virtual IrSequence? Sequence { get; set; }

    public virtual IrSequence? SequenceLine { get; set; }

    public virtual ProductProduct? TipProduct { get; set; }

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; } = new List<AccountFiscalPosition>();

    public virtual ICollection<HrEmployee> HrEmployees { get; } = new List<HrEmployee>();

    public virtual ICollection<PosBill> PosBills { get; } = new List<PosBill>();

    public virtual ICollection<PosDetailsWizard> PosDetailsWizards { get; } = new List<PosDetailsWizard>();

    public virtual ICollection<ProductPricelist> ProductPricelists { get; } = new List<ProductPricelist>();
}
