using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class ResLangInstallRel
{
    public Guid LanguageWizardId { get; set; }

    public long LangId { get; set; }

    public virtual BaseLanguageInstall LanguageWizard { get; set; } = null!;
}
