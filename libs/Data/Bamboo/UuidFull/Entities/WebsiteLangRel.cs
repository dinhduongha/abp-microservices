using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("WebsiteId", "LangId")]
[Table("website_lang_rel")]
[Index("LangId", "WebsiteId", Name = "website_lang_rel_lang_id_website_id_idx")]
public partial class WebsiteLangRel
{
    [Key]
    [Column("website_id")]
    public Guid WebsiteId { get; set; }

    [Key]
    [Column("lang_id")]
    public long LangId { get; set; }

    [ForeignKey("WebsiteId")]
    [InverseProperty("WebsiteLangRels")]
    public virtual Website Website { get; set; } = null!;
}
