using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class AccountFiscalPosition
{
    public Guid Id { get; set; }

    public long Sequence { get; set; }

    public Guid? CompanyId { get; set; }

    public long? CountryId { get; set; }

    public long? CountryGroupId { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public string? Name { get; set; }

    public string? ZipFrom { get; set; }

    public string? ZipTo { get; set; }

    public string? ForeignVat { get; set; }

    public string? Note { get; set; }

    public bool? Active { get; set; }

    public bool? AutoApply { get; set; }

    public bool? VatRequired { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccounts { get; } = new List<AccountFiscalPositionAccount>();

    public virtual ICollection<AccountFiscalPositionResCountryStateRel> AccountFiscalPositionResCountryStateRels { get; } = new List<AccountFiscalPositionResCountryStateRel>();

    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxes { get; } = new List<AccountFiscalPositionTax>();

    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();

    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; } = new List<AccountReportExternalValue>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PosConfig> PosConfigsNavigation { get; } = new List<PosConfig>();

    public virtual ICollection<PosOrder> PosOrders { get; } = new List<PosOrder>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingsNavigation { get; } = new List<ResConfigSetting>();

    public virtual ICollection<SaleOrder> SaleOrders { get; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; } = new List<PosConfig>();

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; } = new List<ResConfigSetting>();
}
