using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class ResCountryState
{
    public long Id { get; set; }

    public long? CountryId { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    //public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    //public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    //public virtual ICollection<ResBank> ResBanks { get; } = new List<ResBank>();

    //public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    //public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFields { get; } = new List<SnailmailLetterMissingRequiredField>();

    //public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplates { get; } = new List<AccountFiscalPositionTemplate>();

    //public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; } = new List<AccountFiscalPosition>();

    //public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequests { get; } = new List<CrmIapLeadMiningRequest>();
}
