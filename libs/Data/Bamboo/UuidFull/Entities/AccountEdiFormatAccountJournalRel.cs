using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("AccountJournalId", "AccountEdiFormatId")]
[Table("account_edi_format_account_journal_rel")]
[Index("AccountEdiFormatId", "AccountJournalId", Name = "account_edi_format_account_jo_account_edi_format_id_account_idx")]
public partial class AccountEdiFormatAccountJournalRel
{
    [Key]
    [Column("account_journal_id")]
    public Guid AccountJournalId { get; set; }

    [Key]
    [Column("account_edi_format_id")]
    public long AccountEdiFormatId { get; set; }

    [ForeignKey("AccountJournalId")]
    [InverseProperty("AccountEdiFormatAccountJournalRels")]
    public virtual AccountJournal AccountJournal { get; set; } = null!;
}
