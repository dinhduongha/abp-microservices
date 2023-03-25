using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Core.Entities;

[Table("ir_ui_view_custom")]
[Index("RefId", Name = "ir_ui_view_custom_ref_id_index")]
[Index("UserId", Name = "ir_ui_view_custom_user_id_index")]
[Index("UserId", "RefId", Name = "ir_ui_view_custom_user_id_ref_id")]
public partial class IrUiViewCustom
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("ref_id")]
    public Guid? RefId { get; set; }

    [Column("user_id")]
    public Guid? UserId { get; set; }

    [Column("create_uid")]
    public Guid? CreatorId { get; set; }

    [Column("write_uid")]
    public Guid? LastModifierId { get; set; }

    [Column("arch")]
    public string? Arch { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreationTime { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? LastModificationTime { get; set; }

    [ForeignKey("CreatorId")]
    [InverseProperty("IrUiViewCustomCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("RefId")]
    [InverseProperty("IrUiViewCustoms")]
    public virtual IrUiView? Ref { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("IrUiViewCustomUsers")]
    public virtual ResUser? User { get; set; }

    [ForeignKey("LastModifierId")]
    [InverseProperty("IrUiViewCustomWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
