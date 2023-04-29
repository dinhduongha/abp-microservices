using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_act_client")]
public partial class IrActClient
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("binding_model_id")]
    public Guid? BindingModelId { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("type")]
    public string? Type { get; set; }

    [Column("binding_type")]
    public string? BindingType { get; set; }

    [Column("binding_view_types")]
    public string? BindingViewTypes { get; set; }

    [Column("name", TypeName = "jsonb")]
    public string? Name { get; set; }

    [Column("help", TypeName = "jsonb")]
    public string? Help { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("tag")]
    public string? Tag { get; set; }

    [Column("target")]
    public string? Target { get; set; }

    [Column("res_model")]
    public string? ResModel { get; set; }

    [Column("context")]
    public string? Context { get; set; }

    [Column("params_store")]
    public byte[]? ParamsStore { get; set; }

    [ForeignKey("BindingModelId")]
    [InverseProperty("IrActClients")]
    public virtual IrModel? BindingModel { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("IrActClientCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("IrActClientWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
