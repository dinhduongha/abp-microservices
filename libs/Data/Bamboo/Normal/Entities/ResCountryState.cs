﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("res_country_state")]
[Index("CountryId", "Code", Name = "res_country_state_name_code_uniq", IsUnique = true)]
public partial class ResCountryState
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("country_id")]
    public long? CountryId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("code")]
    public string? Code { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("ResCountryStates")]
    public virtual ResCountry? Country { get; set; }

    [ForeignKey("CreatorId")]
    //[InverseProperty("ResCountryStateCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("LastModifierId")]
    //[InverseProperty("ResCountryStateWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    /// TODO: DISABLE INVERSE

    [InverseProperty("State")]
    [NotMapped]
    public virtual ICollection<CrmLead> CrmLeads { get; } = new List<CrmLead>();

    [InverseProperty("PartnerState")]
    [NotMapped]
    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; } = new List<PaymentTransaction>();

    [InverseProperty("StateNavigation")]
    [NotMapped]
    public virtual ICollection<ResBank> ResBanks { get; } = new List<ResBank>();

    [InverseProperty("State")]
    [NotMapped]
    public virtual ICollection<ResPartner> ResPartners { get; } = new List<ResPartner>();

    [InverseProperty("State")]
    [NotMapped]
    public virtual ICollection<SnailmailLetterMissingRequiredField> SnailmailLetterMissingRequiredFields { get; } = new List<SnailmailLetterMissingRequiredField>();

    [InverseProperty("StateNavigation")]
    [NotMapped]
    public virtual ICollection<SnailmailLetter> SnailmailLetters { get; } = new List<SnailmailLetter>();

    [ForeignKey("ResCountryStateId")]
    [InverseProperty("ResCountryStates")]
    [NotMapped]
    public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplates { get; } = new List<AccountFiscalPositionTemplate>();

    [ForeignKey("ResCountryStateId")]
    [InverseProperty("ResCountryStates")]
    [NotMapped]
    public virtual ICollection<AccountFiscalPosition> AccountFiscalPositions { get; } = new List<AccountFiscalPosition>();

    [ForeignKey("ResCountryStateId")]
    [InverseProperty("ResCountryStates")]
    [NotMapped]
    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequests { get; } = new List<CrmIapLeadMiningRequest>();

}
