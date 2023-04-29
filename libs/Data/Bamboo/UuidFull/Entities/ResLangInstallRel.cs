using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bamboo.Core.Models;

[PrimaryKey("LanguageWizardId", "LangId")]
[Table("res_lang_install_rel")]
[Index("LangId", "LanguageWizardId", Name = "res_lang_install_rel_lang_id_language_wizard_id_idx")]
public partial class ResLangInstallRel
{
    [Key]
    [Column("language_wizard_id")]
    public Guid LanguageWizardId { get; set; }

    [Key]
    [Column("lang_id")]
    public long LangId { get; set; }

    [ForeignKey("LanguageWizardId")]
    [InverseProperty("ResLangInstallRels")]
    public virtual BaseLanguageInstall LanguageWizard { get; set; } = null!;
}
