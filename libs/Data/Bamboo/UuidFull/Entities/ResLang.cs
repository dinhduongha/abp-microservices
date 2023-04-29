using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[Table("res_lang")]
[Index("Code", Name = "res_lang_code_uniq", IsUnique = true)]
[Index("Name", Name = "res_lang_name_uniq", IsUnique = true)]
[Index("UrlCode", Name = "res_lang_url_code_uniq", IsUnique = true)]
public partial class ResLang
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

    [Column("code")]
    public string? Code { get; set; }

    [Column("iso_code")]
    public string? IsoCode { get; set; }

    [Column("url_code")]
    public string? UrlCode { get; set; }

    [Column("direction")]
    public string? Direction { get; set; }

    [Column("date_format")]
    public string? DateFormat { get; set; }

    [Column("time_format")]
    public string? TimeFormat { get; set; }

    [Column("week_start")]
    public string? WeekStart { get; set; }

    [Column("grouping")]
    public string? Grouping { get; set; }

    [Column("decimal_point")]
    public string? DecimalPoint { get; set; }

    [Column("thousands_sep")]
    public string? ThousandsSep { get; set; }

    [Column("active")]
    public bool? Active { get; set; }

    [Column("create_date", TypeName = "timestamp without time zone")]
    public DateTime? CreateDate { get; set; }

    [Column("write_date", TypeName = "timestamp without time zone")]
    public DateTime? WriteDate { get; set; }

    [ForeignKey("CreateUid")]
    [InverseProperty("ResLangCreateUs")]
    public virtual ResUser? CreateU { get; set; }

    [ForeignKey("WriteUid")]
    [InverseProperty("ResLangWriteUs")]
    public virtual ResUser? WriteU { get; set; }
}
