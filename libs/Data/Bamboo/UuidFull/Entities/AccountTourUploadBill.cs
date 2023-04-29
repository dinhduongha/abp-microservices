using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("account_tour_upload_bill")]
public partial class AccountTourUploadBill
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("selection")]
    public string? Selection { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("AccountTourUploadBillCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("AccountTourUploadBillWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("AccountTourUploadBillId")]
    [InverseProperty("AccountTourUploadBills")]
    public virtual ICollection<IrAttachment> IrAttachments { get; } = new List<IrAttachment>();
}
