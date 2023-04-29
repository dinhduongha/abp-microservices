using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_resequence_wizard")]
public partial class AccountResequenceWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("first_name")]
    public string? FirstName { get; set; }

    [Column("ordering")]
    public string? Ordering { get; set; }

    [Column("first_date")]
    public DateOnly? FirstDate { get; set; }

    [Column("end_date")]
    public DateOnly? EndDate { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountResequenceWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountResequenceWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountResequenceWizardId")]
    [InverseProperty("AccountResequenceWizards")]
    public virtual ICollection<AccountMove> AccountMoves { get; } = new List<AccountMove>();
}
