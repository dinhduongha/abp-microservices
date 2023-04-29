using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("pos_close_session_wizard")]
public partial class PosCloseSessionWizard
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("account_id")]
    public Guid? AccountId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("message")]
    public string? Message { get; set; }

    [Column("account_readonly")]
    public bool? AccountReadonly { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("amount_to_balance")]
    public double? AmountToBalance { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("PosCloseSessionWizards")]
    public virtual AccountAccount? Account { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("PosCloseSessionWizardCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("PosCloseSessionWizardWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
