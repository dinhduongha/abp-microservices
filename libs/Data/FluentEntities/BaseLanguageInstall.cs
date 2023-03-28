using System;
using System.Collections.Generic;

namespace Bamboo.Core.Entities;

public partial class BaseLanguageInstall
{
    public Guid Id { get; set; }

    public Guid? CreatorId { get; set; }

    public Guid? LastModifierId { get; set; }

    public bool? Overwrite { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModificationTime { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    //public virtual ICollection<ResLang> Langs { get; } = new List<ResLang>();

    //public virtual ICollection<Website> Websites { get; } = new List<Website>();
}
