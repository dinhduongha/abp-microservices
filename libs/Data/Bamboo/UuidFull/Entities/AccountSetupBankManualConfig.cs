using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_setup_bank_manual_config")]
public partial class AccountSetupBankManualConfig
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("res_partner_bank_id")]
    public Guid? ResPartnerBankId { get; set; }

    [Column("num_journals_without_account")]
    public long? NumJournalsWithoutAccount { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("new_journal_name")]
    public string? NewJournalName { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountSetupBankManualConfigCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("ResPartnerBankId")]
    [InverseProperty("AccountSetupBankManualConfigs")]
    public virtual ResPartnerBank? ResPartnerBank { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountSetupBankManualConfigWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
