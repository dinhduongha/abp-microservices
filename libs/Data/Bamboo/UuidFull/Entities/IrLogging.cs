using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("ir_logging")]
[Index("Dbname", Name = "ir_logging_dbname_index")]
[Index("Level", Name = "ir_logging_level_index")]
[Index("Type", Name = "ir_logging_type_index")]
public partial class IrLogging
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

    [Column("type")]
    public string? Type { get; set; }

    [Column("dbname")]
    public string? Dbname { get; set; }

    [Column("level")]
    public string? Level { get; set; }

    [Column("path")]
    public string? Path { get; set; }

    [Column("func")]
    public string? Func { get; set; }

    [Column("line")]
    public string? Line { get; set; }

    [Column("message")]
    public string? Message { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }
}
