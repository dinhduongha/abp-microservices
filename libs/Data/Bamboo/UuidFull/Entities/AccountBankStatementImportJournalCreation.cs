using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_bank_statement_import_journal_creation")]
public partial class AccountBankStatementImportJournalCreation
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("journal_id")]
    public Guid? JournalId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountBankStatementImportJournalCreationCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("AccountBankStatementImportJournalCreations")]
    public virtual AccountJournal? Journal { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountBankStatementImportJournalCreationWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
