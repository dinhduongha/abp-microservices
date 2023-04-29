using System;
using System.Collections.Generic;

namespace Bamboo.Core.Models;

public partial class BaseLanguageInstall
{
    public Guid Id { get; set; }

    public Guid? CreateUid { get; set; }

    public Guid? WriteUid { get; set; }

    public bool? Overwrite { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResLangInstallRel> ResLangInstallRels { get; } = new List<ResLangInstallRel>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<Website> Websites { get; } = new List<Website>();
}
