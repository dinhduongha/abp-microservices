using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResCountry
{
    public long Id { get; set; }

    public Guid? AddressViewId { get; set; }

    public long? CurrencyId { get; set; }

    public long? PhoneCode { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Code { get; set; }

    public string? NamePosition { get; set; }

    public string? Name { get; set; }

    public string? VatLabel { get; set; }

    public string? AddressFormat { get; set; }

    public bool? StateRequired { get; set; }

    public bool? ZipRequired { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    //public virtual ICollection<AccountAccountTag> AccountAccountTags { get; } = new List<AccountAccountTag>();

    //public virtual ICollection<AccountChartTemplate> AccountChartTemplates { get; } = new List<AccountChartTemplate>();

    //public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplates { get; } = new List<AccountFiscalPositionTemplate>();

    //public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; } = new List<AccountFiscalPosition>();

    //public virtual ICollection<AccountReport> AccountReports { get; } = new List<AccountReport>();

    //public virtual ICollection<AccountTaxGroup> AccountTaxGroups { get; } = new List<AccountTaxGroup>();

    //public virtual ICollection<AccountTax> AccountTaxes { get; } = new List<AccountTax>();

    public virtual IrUiView? AddressView { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    public virtual ResCurrency? Currency { get; set; }

    //public virtual ICollection<HrEmployee> HrEmployeeCountries { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrEmployee> HrEmployeeCountryOfBirthNavigations { get; } = new List<HrEmployee>();

    //public virtual ICollection<HrPayrollStructureType> HrPayrollStructureTypes { get; } = new List<HrPayrollStructureType>();

    //public virtual ICollection<MailGuest> MailGuests { get; } = new List<MailGuest>();

    //public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    //public virtual ICollection<ResBank> ResBanks { get; } = new List<ResBank>();

    //public virtual ICollection<ResCompany> ResCompanies { get; } = new List<ResCompany>();

    //public virtual ICollection<ResCountryState> ResCountryStates { get; } = new List<ResCountryState>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    //public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFields { get; } = new List<SnailmailLetterMissingRequiredField>();

    //public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    //public virtual ICollection<WebsiteVisitor> WebsiteVisitors { get; } = new List<WebsiteVisitor>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequests { get; } = new List<CrmIapLeadMiningRequest>();

    //public virtual ICollection<PaymentProvider> Payments { get; } = new List<PaymentProvider>();

    //public virtual ICollection<ResCountryGroup> ResCountryGroups { get; } = new List<ResCountryGroup>();
}
