using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("base_language_export")]
public partial class BaseLanguageExport
{
    [Key]
    [Column("id")]
    public Guid Id { get; set; }

    [Column("create_uid")]
    public Guid? CreateUid { get; set; }

    [Column("write_uid")]
    public Guid? WriteUid { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("lang")]
    public string? Lang { get; set; }

    [Column("format")]
    public string? Format { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [Column("data")]
    public byte[]? Data { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("BaseLanguageExportCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("BaseLanguageExportWriteUs")]
    public virtual ResUser? WriteU { get; set; }

    [ForeignKey("WizId")]
    [InverseProperty("Wizs")]
    public virtual ICollection<IrModuleModule> Modules { get; } = new List<IrModuleModule>();
}
